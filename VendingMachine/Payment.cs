using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public static class Payment
    {
        //Transaction : Pay and update Qty
        public static long Pay(long money, string food)
        {
            long change = 0;
            if (food == Strings.sBiskuit)
            {
                change = money - ((long)Enums.Price.BISKUIT);
                Biskuit.UpdateBiskuit();
            }
            else if (food == Strings.sChips)
            {
                change = money - ((long)Enums.Price.CHIPS);
                Chips.UpdateChips();
            }
            else if (food == Strings.sOreo)
            {
                change = money - ((long)Enums.Price.OREO);
                Oreo.UpdateOreo();
            } else if (food == Strings.sTango)
            {
                change = money - ((long)Enums.Price.TANGO);
                Tango.UpdateTango();
            } else if (food == Strings.sCokelat)
            {
                change = money - ((long)Enums.Price.COKELAT);
                Cokelat.UpdateCokelat();
            }
            return change;
        }

        //Transaction : Validate to ONLY do transaction if user's money ENOUGH to buy the item
        public static string Transaction(long money, string food)
        {
            string paymentResult = Strings.sFailed;
            if (food == Strings.sBiskuit)
            {
                if(money >= ((long)Enums.Price.BISKUIT))
                {
                    paymentResult = Pay(money, food).ToString(); // If it is enough, process to pay
                }
            }
            else if (food == Strings.sChips)
            {
                if (money >= ((long)Enums.Price.CHIPS))
                {
                    paymentResult = Pay(money, food).ToString();
                }
            }
            else if (food == Strings.sOreo)
            {
                if (money >= ((long)Enums.Price.OREO))
                {
                    paymentResult = Pay(money, food).ToString();
                }
            }
            else if (food == Strings.sTango)
            {
                if (money >= ((long)Enums.Price.TANGO))
                {
                    paymentResult = Pay(money, food).ToString();
                }
            }
            else if (food == Strings.sCokelat)
            {
                if (money >= ((long)Enums.Price.COKELAT))
                {
                    paymentResult = Pay(money, food).ToString();
                }
            }
            return paymentResult;
        }
    }
}
