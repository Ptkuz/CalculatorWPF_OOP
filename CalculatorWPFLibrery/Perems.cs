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
        public static string? Radical { get; set; }
        public static string? Degree { get; set; }

        public static double Number1Double { get; set; }
        public static double Number2Double { get; set; }
        public static double RadicalDouble { get; set; }
        public static double DegreeDouble { get; set; }
        public static double Result { get; set; }

        public static bool FlagOper { get; set; } = false;
        public static bool FlagDegree { get; set; } = false;
        public static bool FlagRadical { get; set; } = false;


        public static void DropPerem() 
        {
            Operation = null;
            Number1 = null;
            Number2 = null;
            Radical = null;
            Degree = null;

            Number1Double = 0;
            Number2Double = 0;
            RadicalDouble = 0;
            DegreeDouble = 0;
            Result = 0;

            FlagOper = false;
            FlagDegree = false;
            FlagRadical = false;
        }

        
    }


}
