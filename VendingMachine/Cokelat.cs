using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class Cokelat : Item 
    {
        public static void UpdateCokelat()
        {
            qtyCokelat -= 1;
        }

        public static bool IsCokelatAvailable()
        {
            if (qtyCokelat > 0)
            {
                return true;
            }
            return false;
        }
    }
}
