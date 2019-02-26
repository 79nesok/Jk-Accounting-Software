using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jk_Accounting_Software.Internal.Classes
{
    public static class IDateHandler
    {
        private static DateTime Parse(String date)
        {
            return DateTime.ParseExact(date, "MM/dd/yyyy", null);
        }

        public static DateTime AllDates(bool FromDate)
        {
            DateTimePicker dt = new DateTimePicker();

            if (FromDate)
                return dt.MinDate;
            else
                return dt.MaxDate;
        }

        public static DateTime PreviousYear(bool FromDate)
        {
            return CurrentYear(FromDate).AddYears(-1);
        }

        public static DateTime CurrentYear(bool FromDate)
        {
            if (FromDate)
                return Parse("01/01/" + (DateTime.Now.Year).ToString());
            else
                return Parse("12/31/" + (DateTime.Now.Year).ToString());
        }

        public static DateTime NextYear(bool FromDate)
        {
            return CurrentYear(FromDate).AddYears(1);
        }

        public static DateTime PreviousMonth(bool FromDate)
        {
            if (FromDate)
                return CurrentMonth(FromDate).AddMonths(-1);
            else
                return CurrentMonth(true).AddDays(-1);
        }

        public static DateTime CurrentMonth(bool FromDate)
        {
            if (FromDate)
                return Parse(String.Format("{0}/01/{1}", DateTime.Now.Month.ToString().PadLeft(2, '0'), DateTime.Now.Year.ToString()));
            else
            {
                DateTime date = Parse(String.Format("{0}/01/{1}", (DateTime.Now.Month + 1).ToString().PadLeft(2, '0'), DateTime.Now.Year.ToString()));
                date = date.Subtract(TimeSpan.FromDays(1));

                return date;
            }
        }

        public static DateTime NextMonth(bool FromDate)
        {
            if (FromDate)
                return CurrentMonth(FromDate).AddMonths(1);
            else
                return CurrentMonth(true).AddMonths(2).AddDays(-1);
        }
    }
}
