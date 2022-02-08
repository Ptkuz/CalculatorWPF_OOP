using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorWPFLibrery
{
    public static class SimpleOperation
    {
        public static double Oper() 
        {
            Perems.Number1Double = Convert.ToDouble(Perems.Number1);
            Perems.Number2Double = Convert.ToDouble(Perems.Number2);
            Perems.RadicalDouble = Convert.ToDouble(Perems.Radical);

            if (Perems.PrevOperation != null && Perems.FlagOperComp)
            {
                switch (Perems.PrevOperation)
                {
                    case "+":
                        if (Perems.PrevOperationComp == ButtonNames.ButtonSqrt)
                            Perems.Result = Perems.Number1Double + (Math.Pow(Perems.Number2Double, 1 / Perems.RadicalDouble));
                        break;
                    case "-":
                        if (Perems.PrevOperationComp == ButtonNames.ButtonSqrt)
                            Perems.Result = Perems.Number1Double - (Math.Pow(Perems.Number2Double, 1 / Perems.RadicalDouble));
                        break;
                    case "*":
                        if (Perems.PrevOperationComp == ButtonNames.ButtonSqrt)
                            Perems.Result = Perems.Number1Double * (Math.Pow(Perems.Number2Double, 1 / Perems.RadicalDouble));
                        break;
                    case "/":
                        if (Perems.PrevOperationComp == ButtonNames.ButtonSqrt)
                            Perems.Result = Perems.Number1Double / (Math.Pow(Perems.Number2Double, 1 / Perems.RadicalDouble));
                        break;



                }
            }
            else 
            {
                switch (Perems.Operation)
                {
                    case "+":
                            Perems.Result = Perems.Number1Double + Perems.Number2Double;
                        break;
                    case "-":
                            Perems.Result = Perems.Number1Double - Perems.Number2Double;
                        break;
                    case "*":
                            Perems.Result = Perems.Number1Double * Perems.Number2Double;
                        break;
                    case "/":
                            Perems.Result = Perems.Number1Double / Perems.Number2Double;
                        break;
                    case "Sqrt":
                        Perems.Result = (Math.Pow(Perems.Number1Double, 1 / Perems.Number2Double));
                        break;



                }
            }

            return Perems.Result;

        }

   
    }
}
