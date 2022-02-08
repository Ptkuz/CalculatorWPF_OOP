using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorWPFLibrery
{
    
    public static class PrintOperations
    {
       static string? result = null;




        static string stepenN1 = $"({Perems.Number1})^";
        static string stepenN2 = $"({Perems.Number2})^";
        static string stepenN1D = $"({Perems.Number1})^{Perems.Degree}";
        static string stepenN2D = $"({Perems.Number2})^{Perems.Degree}";

        static string OneDevideN = $"1/{Perems.Number1}";
        static string procentOper = $"{Perems.Number1} {Perems.Operation} {Perems.Number2}%";

        // 1 + 2
        public static string OperationPrintNON() 
        {
            result = $"{Perems.Number1} {Perems.Operation} {Perems.Number2}";
            return result;
        
        }

        // 1 + 
        public static string OperationPrintNO() 
        {
            result = $"{Perems.Number1} {Perems.Operation}";
            return result;                
        }

        // sqrt(1)
        public static string OperationPrintsqrtN() 
        {
            result = $"sqrt({Perems.Number1})";
            return result;
        
        }

        //sqrt(1)^1/2
        public static string OperationPrintsqrtNR() 
        {
            result = $"sqrt({Perems.Number1})^{Perems.Number2}";
            return result;
        
        }


        //1+sqrt(2)
        public static string OperationPrintNOsqrtN() 
        {
            result = $"{Perems.Number1} {Perems.PrevOperation} sqrt({Perems.Number2})";
            return result;
        }

        // 1+sqrt(2)^1/3
        public static string OperationPrintNOsqrtNR() 
        {
            result = $"{Perems.PrevNumber1} {Perems.PrevOperation} sqrt({Perems.Number2})^{Perems.Radical}";
            return result;
        }




        // 1^
        public static string OperationPrintStepenN()
        {
            result = $"({Perems.Number1})^"; ;
            return result;

        }

        //1^2
        public static string OperationPrintStepenND()
        {
            result = stepenN1D;
            return result;

        }

        // 1+2^
        public static string OperationPrintNOStepenN()
        {
            result = $"{Perems.Number1} {Perems.Operation} {stepenN2}";
            return result;
        }

        // 1+2^3
        public static string OperationPrintNOStepenND()
        {
            result = $"{Perems.Number1} {Perems.Operation} {stepenN2D}";
            return result;
        }




        // 1/20
        public static string OperationPrintProcent() 
        {
            result = OneDevideN;
            return result;        
        }

        // 100 - 10%
        public static string OperationPrintNOperProcent() 
        {
            result = procentOper;
            return result;
        
        }




    }
}
