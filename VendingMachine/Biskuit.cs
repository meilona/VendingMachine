using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class Biskuit : Item
    {
        public Biskuit() { }

        public static void UpdateBiskuit()
        {
            qtyBiskuit -= 1;
        }

        public static bool IsBiskuitAvailable()
        {
            if (qtyBiskuit > 0)
            {
                return true;
            }
            return false;
        }
    }
}
