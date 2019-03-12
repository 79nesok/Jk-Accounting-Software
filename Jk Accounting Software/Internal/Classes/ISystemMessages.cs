using System;

namespace Jk_Accounting_Software.Internal.Classes
{
    public static class ISystemMessages
    {
        //Questions
        public const String SavingQuestion = "Are you sure do you want to save this data entry?";
        public const String ClosingOrCancellingQuestion = "Are you sure do you want to cancel this data entry?";
        public const String ColumnReloadQuestion = "Columns are already loaded, do you want to remove it?";
        public const String LogoutQuestion = "Are you sure do you want to logout?";
        public const String RestartQuestion = "Are you sure do you want to restart the application?";
        public const String DeleteGridRow = "Delete selected row(s)?";
        public const String RemoveGridValue = "Remove assigned value on this cell?";
        public const String RemovePaidInvoice = "Invoice(s) are already paid, Are you sure do you want to remove the applied payment?";
        public const String RemoveAppliedAmount = "Do you want to remove Applied Amount";
        public const String RemovePaidBills = "Bills are already paid, Are you sure do you want to remove the applied payment?";

        //Errors
        public const String LoadDataError = "Unable to load data: ";
        public const String SaveDataError = "Unable to save data: ";
        public const String EditDataError = "Unable to edit data: ";
        public const String LoadColumnsError = "Unable to load columns: ";
        public static String RecordCountInputError(String allowedNum)
        {
            return "Invalid input!\rAllowed values are 1 up to " + allowedNum + " only.";
        }
        public const String InvalidInputError = "Invalid input!";
        public static String DevelopmentError(String error)
        {
            return "Development Error: " + error;
        }
        public const String DebitCreditNotEqual = "Total debit must be equal to total credit.";
        public const String PrintoutNotSet = "Printout not set properly.";
        public static String ErrorOnPosting(String error, bool IsPost)
        {
            if (IsPost)
                return "Unable to post transaction: " + error;
            else
                return "Unable to unpost transaction: " + error;
        }
        public const String AmountToApplyExceedsBalance = "Amount cannot be apply because it exceeds on Balance.";
        public const String AmountPaidInsufficient = "Amount Applied exceeds on Amount Paid.";
        public const String NoATCAssigned = "Please assign an ATC on this subsidiary.";
        public static String NoFormFound(String formname)
        {
            return String.Format("No form named '{0}' found.", formname);
        }
        public static String ErrorExecutingCommand(String error)
        {
            return "Error executing command: " + error;
        }

        //Messages
        public const String NoFormMessage = "No form available";
        public static String AboutMessage =
            "Product Name: " + ISecurityHandler.ProductName + "\r" +
            "Product Version: " + ISecurityHandler.ProductVersion + "\r" +
            "\r" +
            "   Thank you for using this software and for questions feel free to contact developer." + "\r" +
            "\r" +
            "Name: Jake A. Oandasan" + "\r" +
            "Country: Philippines" + "\r" +
            "E-mail: jake.oandasan@yahoo.com";
        public const String TestConnectionSuccess = "Test connection succeded.";
        public const String FillRequiredFieldMessage = "Please fill up all required fields.";
        public const String NoPendingInvoice = "No pending invoice(s) for the selected subsidiary.";
        public const String NoPendingBills = "No pending bills for the selected subsidiary.";
        public static String FillRequiredFieldOnGridMessage(String column)
        {
            return String.Format("Please fill up '{0}', it is a required field.", column);
        }
    }
}
