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

        public static bool SimpleOper() 
        {
            if (Perems.Operation == ButtonNames.ButtonPlus || 
                Perems.Operation == ButtonNames.ButtonMinus || 
                Perems.Operation == ButtonNames.ButtonMulti || 
                Perems.Operation == ButtonNames.ButtonDevide) 
            { 
                return true;
            }
            return false;
        
        }

        public static string ChoiseMethod() 
        {
            // ПРОСТЫЕ ОПЕРАЦИИ

            if ((Perems.Number1 == null && Perems.FlagOper == true && SimpleOper()) ||
                (Perems.Number1 != null && Perems.Number2 != null && Perems.FlagOper == true && SimpleOper()) ||
                (Perems.Number1 != null && Perems.Number2 != null && Perems.FlagOperComp == true && SimpleOper()))
            {
                result = PrintOperations.OperationPrintNO();
                return result;
            }
            else if ((Perems.Number1 != null && Perems.Number2 == null && SimpleOper()) ||
                (Perems.Number1 != null && Perems.Number2 != null && Perems.FlagOper == false && SimpleOper()))
            {
                result = PrintOperations.OperationPrintNON();
                return result;
            }


            // КОРЕНЬ
            else if (((Perems.Number1 != null && Perems.FlagOper == true && Perems.Operation == ButtonNames.ButtonSqrt && Perems.FlagOperComp == false) ||
                (Perems.Number1 != null && Perems.Number2 != null && Perems.FlagOper == true && Perems.Operation == ButtonNames.ButtonSqrt && Perems.FlagOperComp == false)))
            {
                result = PrintOperations.OperationPrintsqrtN();
                return result;

            }
            else if (Perems.Number1 != null && Perems.Number2 != null && Perems.FlagOper == false && Perems.Operation == ButtonNames.ButtonSqrt)
            {
                result = PrintOperations.OperationPrintsqrtNR();
                return result;
            }
            else if (Perems.Number1 != null && Perems.Number2 != null && Perems.FlagOperComp == true && Perems.Operation == ButtonNames.ButtonSqrt)
            {
                result = PrintOperations.OperationPrintNOsqrtN();
                return result;
            }
            else if (Perems.Operation == ButtonNames.ButtonEquals && Perems.Number1 != null && Perems.PrevOperationComp == ButtonNames.ButtonSqrt)
            {
                result = PrintOperations.OperationPrintNOsqrtNR();
                return result;
            }


            // СТЕПЕНЬ 
            else if (((Perems.Number1 != null && Perems.FlagOper == true && Perems.Operation == ButtonNames.ButtonDegree && Perems.FlagOperComp == false) ||
                (Perems.Number1 != null && Perems.Number2 != null && Perems.FlagOper == true && Perems.Operation == ButtonNames.ButtonDegree && Perems.FlagOperComp == false)))
            {
                result = PrintOperations.OperationPrintStepenN();
                return result;

            }
            else if (Perems.Number1 != null && Perems.Number2 != null && Perems.FlagOper == false && Perems.Operation == ButtonNames.ButtonDegree)
            {
                result = PrintOperations.OperationPrintStepenND();
                return result;
            }
            else if (Perems.Number1 != null && Perems.Number2 != null && Perems.FlagOperComp == true && Perems.Operation == ButtonNames.ButtonDegree)
            {
                result = PrintOperations.OperationPrintNOStepenN();
                return result;
            }
            else if (Perems.Operation == ButtonNames.ButtonEquals && Perems.Number1 != null && Perems.PrevOperationComp == ButtonNames.ButtonDegree)
            {
                result = PrintOperations.OperationPrintNOStepenND();
                return result;
            }

            // 1/X
            else if (((Perems.Number1 != null && Perems.Number2 == null && Perems.FlagOper == true && Perems.Operation == ButtonNames.Button1DevideX && Perems.FlagOperComp == false) ||
                (Perems.Number1 != null && Perems.Number2 == null && Perems.FlagOper == true && Perems.Operation == ButtonNames.Button1DevideX && Perems.FlagOperComp == false)))
            {
                result = PrintOperations.OperationPrint1DevideX();
                return result;

            }

            // 1+(2/X)
            else if (Perems.Number1 != null && Perems.Number2 != null && Perems.Operation == ButtonNames.Button1DevideX) 
            {
                result = PrintOperations.OperationPrintNODevideN();
                return result;
            }

            //1-20%
            else if (Perems.Number1 != null && Perems.Number2 != null && Perems.Operation == ButtonNames.ButtonProcent)
            {
                result = PrintOperations.OperationPrintNOperProcent();
                return result;
            }


            return result;
        }
    }
}
