using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class Tango : Item
    {
        public static void UpdateTango()
        {
            qtyTango -= 1;
        }

        public static bool IsTangoAvailable()
        {
            if (qtyTango > 0)
            {
                return true;
            }
            return false;
        }
    }
}
