using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorWPFLibrery
{
    public static class ButtonNames
    {
        public static string ButtonPlus = "+";
        public static string ButtonMinus = "-";
        public static string ButtonDevide = "/";
        public static string ButtonMulti = "*";
        public static string ButtonEquals = "=";
        public static string Button1DevideX = "1/X";
        public static string ButtonSqrt = "Sqrt";
        public static string ButtonDegree = "X^Y";
        public static string ButtonProcent = "%";

        public static bool EqualsOperations() 
        {
            if(Perems.Operation == ButtonSqrt)
                return true;
            if (Perems.Operation == ButtonDegree)
                return true;
            return false;
        }
    }



}
