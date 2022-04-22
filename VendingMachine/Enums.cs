using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    // Vending machine dapat menerima uang dengan pecahan : 2000, 5000, 10000, 20000, 50000
    
    public static class Enums
    {
        public enum Product
        {
            Biskuit = 1,
            Chips,
            Oreo,
            Tango,
            Cokelat
        }

        //public enum Money
        //{
        //    DUA_RIBU = 2000,
        //    LIMA_RIBU = 5000,
        //    SEPULUH_RIBU = 10000,
        //    DUAPULUH_RIBU = 20000,
        //    LIMAPULUH_RIBU = 50000
        //}

        public enum Price
        {
            BISKUIT = 6000,
            CHIPS = 8000,
            OREO = 10000,
            TANGO = 12000,
            COKELAT = 15000
        }

        public enum Choice
        {
            YES = 1,
            NO = 0
        }
    }
}
