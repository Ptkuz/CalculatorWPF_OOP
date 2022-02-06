using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorWPFLibrery
{
    public static class ChoiseOperation
    {
        static string? result = null;
        public static string ChoiseMethod() 
        {
            if (Perems.Number1==null || (Perems.Number1!=null && Perems.Number2!=null && Perems.FlagOper == true))
            {
                result = PrintOperations.OperationPrintNO();
                return result;
            }
            else if ((Perems.Number1!=null && Perems.Number2==null) || (Perems.Number1 != null && Perems.Number2 != null && Perems.FlagOper == false))
            {
                result = PrintOperations.OperationPrintNON();
                return result;
            }
            return null;
        }
    }
}
