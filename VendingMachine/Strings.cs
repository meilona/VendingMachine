using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class Strings
    {
        public readonly static string sWelcomeVendingMachine = "Welcome to Vending MEI-chine :)";
        public readonly static string sInsertMoney = "Please Insert your Money";
        public readonly static string sMenu = "Today's Item :";
        public readonly static string sBiskuit = "BISKUIT";
        public readonly static string sChips = "CHIPS";
        public readonly static string sOreo = "OREO";
        public readonly static string sTango = "TANGO";
        public readonly static string sCokelat = "COKELAT";
        public readonly static string sSelectItem = "Please Select the item number";
        public readonly static string sNotAvailable = "Sorry, the item is currently Unavailable :(";
        public readonly static string sNotEnoughMoney = "Unable to process payment: Not enough money";
        public readonly static string sInputNotValid = "Please input valid number only!";
        public readonly static string sFailed = "Failed";
        public readonly static string sTransactionAgain = "Do you want to do another transaction?";
        public readonly static string sInputNumber = "Input Number";
        public readonly static string sTransactionFailed = "Transaction Failed.";
        public readonly static string sTransactionSuccsess = "Transaction Succsess. Please take the item and the change Rp.";
        public readonly static string sAcceptedMoney = "We only accepted";

        public static List<long> lAcceptedMoney = new List<long> { 2000, 5000, 10000, 20000, 50000 };

    }
}
