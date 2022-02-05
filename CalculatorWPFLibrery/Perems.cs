using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorWPFLibrery
{
    public static class Perems
    {
        public static string? Operation { get; set; }
        public static string? Number1 { get; set; }
        public static string? Number2 { get; set; }
        public static double Number1Double { get; set; }
        public static double Number2Double { get; set; }

        public static double Result { get; set; }
        public static bool FlagOper { get; set; }


        public static void DropPerem() 
        {
            Operation = null;
            Number1 = null;
            Number2 = null;
            Number1Double = 0;
            Number2Double = 0;
            Result = 0;
        }

        
    }


}
