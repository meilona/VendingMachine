using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            // Looping so the program stays
            while (true)
            {
                // First Time Screen
                Print(Strings.sWelcomeVendingMachine);

                int count = 1;
                Print(Strings.sMenu);
                foreach (Enums.Price p in (Enums.Price[])Enum.GetValues(typeof(Enums.Price)))
                {
                    Print($"{count}. {p.ToString()} - Rp. {(int)p}");
                    count++;
                }

                // Transaction
                try
                {
                    // User input the money first
                    string sAcceptedMoneyList = string.Join(",", Strings.lAcceptedMoney.ToArray());
                    Print($"{Strings.sInsertMoney} ({Strings.sAcceptedMoney} {sAcceptedMoneyList})");
                    long insertedMoney = Convert.ToInt64(Console.ReadLine());

                    if (Strings.lAcceptedMoney.Contains(insertedMoney)) // Check if user's only input the accepted value
                    {
                        ChooseItem(insertedMoney);
                    }
                    else
                    {
                        Print(Strings.sInputNotValid);
                    }
                }
                catch
                {
                    Print(Strings.sInputNotValid);
                };


                // Do Transaction Again ?
                Print(String.Empty);
                Console.WriteLine(Strings.sTransactionAgain);
                foreach (Enums.Choice c in (Enums.Choice[])Enum.GetValues(typeof(Enums.Choice)))
                {
                    Print($"{(int)c}. {c.ToString()}");
                }
                Console.WriteLine(Strings.sInputNumber);
                int number = Convert.ToInt32(Console.ReadLine());
                try
                {
                    if (number == 0)
                    {
                        break;
                    } else if (number == 1) continue;
                    else {
                        Print(Strings.sInputNotValid);
                        Print(Strings.sTransactionFailed);
                        break;
                    };
                }
                catch
                {
                    Print(Strings.sInputNotValid);
                    Print(Strings.sTransactionFailed);
                    break;
                }
            }
        }

        // Transaction : Choosing item
        static void ChooseItem(long insertedMoney)
        {
            string paymentResult = Strings.sNotAvailable;
            try
            {
                Console.WriteLine(Strings.sSelectItem);
                int number = Convert.ToInt32(Console.ReadLine());
                // Transaction : Validate user item's pick
                if (number <= 5 && number > 0)
                {
                    if (number == ((int)Enums.Product.Biskuit) && Biskuit.IsBiskuitAvailable())
                    {
                        paymentResult = Payment.Transaction(insertedMoney, Strings.sBiskuit); // Go to Transaction : Payment
                    }
                    else if (number == ((int)Enums.Product.Chips) && Chips.IsChipsAvailable())
                    {
                        paymentResult = Payment.Transaction(insertedMoney, Strings.sChips);
                    }
                    else if (number == ((int)Enums.Product.Oreo) && Oreo.IsOreoAvailable())
                    {
                        paymentResult = Payment.Transaction(insertedMoney, Strings.sOreo);
                    }
                    else if (number == ((int)Enums.Product.Tango) && Tango.IsTangoAvailable())
                    {
                        paymentResult = Payment.Transaction(insertedMoney, Strings.sTango);
                    }
                    else if (number == ((int)Enums.Product.Cokelat) && Cokelat.IsCokelatAvailable())
                    {paymentResult = Payment.Transaction(insertedMoney, Strings.sCokelat);
                        
                    }

                    if (paymentResult.Equals(Strings.sFailed))
                    {
                        //When payment failed because of not enough money
                        Print(Strings.sNotEnoughMoney);
                        Print(String.Empty);
                    } else if (paymentResult.Equals(Strings.sNotAvailable))
                    {
                        //When payment failed because of Qty not available
                        Print(paymentResult);
                        Print(String.Empty);
                    }
                    else
                    {
                        //When payment success, gives changes
                        Print($"\n{Strings.sTransactionSuccsess} {paymentResult}\n");
                        Print(String.Empty);
                    }
                }
                else {
                    Print(Strings.sInputNotValid);
                    ChooseItem(insertedMoney);
                }
            }
            catch
            {
                Print(Strings.sInputNotValid);
                ChooseItem(insertedMoney);
            };
        }

        // Printing string
        static void Print(string s)
        {
            Console.WriteLine(s);
        }
    }
}
