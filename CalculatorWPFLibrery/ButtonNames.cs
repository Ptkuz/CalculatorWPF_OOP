using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorWPFLibrery
{
    public static class ButtonNames
    {
        public const string ButtonPlus = "+";
        public const string ButtonMinus = "-";
        public const string ButtonDevide = "/";
        public const string ButtonMulti = "*";
        public const string ButtonEquals = "=";
        public const string Button1DevideX = "1/X";
        public const string ButtonSqrt = "Sqrt";
        public const string ButtonDegree = "X^Y";
        public const string ButtonProcent = "%";

        public static bool EqualsOperations() 
        {
            if (Perems.Operation == ButtonSqrt)
                return true;
            else if (Perems.Operation == ButtonDegree)
                return true;
            else if (Perems.Operation == Button1DevideX)
                return true;
            else if (Perems.Operation == ButtonProcent)
                return true;
            return false;
        }
    }



}
