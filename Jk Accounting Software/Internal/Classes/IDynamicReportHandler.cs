using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Data;

namespace Jk_Accounting_Software.Internal.Classes
{
    public static class IDynamicReportHandler
    {
        public static MemoryStream LoadDynamicReport(string reporthPath, DataTable dataTable)
        {
            XmlDocument doc = addColumns(reporthPath, dataTable);
            byte[] bytes = Encoding.UTF8.GetBytes(doc.OuterXml);
            MemoryStream stream = new MemoryStream(bytes);

            return stream;
        }

        private static XmlDocument addColumns(string reporthPath, DataTable dataTable)
        {
            List<DynamicColumnProperties> columns = new List<DynamicColumnProperties>();

            foreach (DataColumn column in dataTable.Columns)
            {
                DynamicColumnProperties prop = new DynamicColumnProperties(column.ColumnName.Replace(" ", ""), column.ColumnName, column.DataType.ToString());

                columns.Add(prop);
            }

            int numOfColumns = columns.Count;

            XmlDocument objXML = new XmlDocument();
            objXML.Load(reporthPath);

            XmlNamespaceManager mgr = new XmlNamespaceManager(objXML.NameTable);
            string uri = "http://schemas.microsoft.com/sqlserver/reporting/2008/01/reportdefinition";

            mgr.AddNamespace("df", uri);

            //get the tablix node
            XmlNode tablixNode = objXML.SelectSingleNode(string.Format("/df:Report/df:Body/df:ReportItems/df:Tablix[@Name='{0}']/df:TablixBody", @"Tablix1"), mgr);

            //get current nodes
            //column Node
            XmlNode colNode = tablixNode.ChildNodes[0];

            //row one column one
            XmlNode rowNode1 = tablixNode.ChildNodes[1].ChildNodes[0].ChildNodes[1];

            //row tow column one
            XmlNode rowNode2 = tablixNode.ChildNodes[1].ChildNodes[1].ChildNodes[1];

            //add the number of columns to the sheet
            for(int i = 0; i <= numOfColumns - 1; i++)
            {
                XmlNode newCol = colNode.ChildNodes[0].Clone();
         
                colNode.AppendChild(newCol);
            }

            //resize the first column
            colNode.ChildNodes[0].ChildNodes[0].InnerText = "0.01cm";

            foreach(DynamicColumnProperties item in columns)
            {
                //create header row
                XmlNode newRow1;

                newRow1 = rowNode1.ChildNodes[0].Clone();

                newRow1.ChildNodes[0].ChildNodes[0].Attributes[0].Value = item.ColumnName;
                newRow1.ChildNodes[0].ChildNodes[0].ChildNodes[2].ChildNodes[0].ChildNodes[0].ChildNodes[0].ChildNodes[0].InnerText = item.Caption;

                //create data row
                XmlNode newRow2;

                newRow2 = rowNode2.ChildNodes[0].Clone();

                newRow2.ChildNodes[0].ChildNodes[0].Attributes[0].Value = item.ColumnName + "Data";
                newRow2.ChildNodes[0].ChildNodes[0].ChildNodes[2].ChildNodes[0].ChildNodes[0].ChildNodes[0].ChildNodes[0].InnerText = "=Fields!" + item.ColumnName + ".Value";
                
                //add the rows to the report
                rowNode1.AppendChild(newRow1);
                rowNode2.AppendChild(newRow2);
            }

            //add to tablixcolumn
            XmlNode tablixColumnNode = objXML.SelectSingleNode(String.Format("/df:Report/df:Body/df:ReportItems/df:Tablix[@Name='{0}']/df:TablixColumnHierarchy", "Tablix1"), mgr);
            XmlNode tablixColumnAdd = tablixColumnNode.ChildNodes[0];

            for(int i = 0; i <= numOfColumns - 1; i++)
            {
                XmlNode newColumnNode = tablixColumnAdd.ChildNodes[0].Clone();

                tablixColumnAdd.AppendChild(newColumnNode);
            }

            //get datasets and assign
            XmlNode dataSets = objXML.SelectSingleNode("/df:Report/df:DataSets", mgr).ChildNodes[0];

            //get fields
            XmlNode fields = objXML.SelectSingleNode("/df:Report/df:DataSets", mgr).ChildNodes[1].ChildNodes[1].CloneNode(false);

            foreach (DynamicColumnProperties item in columns)
            {
                //get field
                XmlNode field = objXML.SelectSingleNode("/df:Report/df:DataSets", mgr).ChildNodes[1].ChildNodes[1].ChildNodes[0].Clone();

                //name
                field.Attributes[0].Value = item.ColumnName;

                //datafield
                field.ChildNodes[0].InnerText = item.Caption;

                //datatype
                field.ChildNodes[1].InnerText = item.DataType;

                fields.AppendChild(field);
            }

            dataSets.AppendChild(fields);

            return objXML;
        }
    }

    public class DynamicColumnProperties
    {
        public String ColumnName { get; set; }
        public String Caption { get; set; }
        public String DataType { get; set; }

        public DynamicColumnProperties(String _ColumnName, String _Caption, String _DataType)
        {
            ColumnName = _ColumnName;
            Caption = _Caption;
            DataType = _DataType;
        }
    }
}
