using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class Chips : Item
    {
        public Chips() { }
        public static void UpdateChips()
        {
            qtyChips -= 1;
        }
        public static bool IsChipsAvailable()
        {
            if (qtyChips > 0)
            {
                return true;
            }
            return false;
        }
    }
}
