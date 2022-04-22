using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class Oreo : Item
    {
        public static void UpdateOreo()
        {
            qtyOreo -= 1;
        }

        public static bool IsOreoAvailable()
        {
            if (qtyOreo > 0)
            {
                return true;
            }
            return false;
        }
    }
}
