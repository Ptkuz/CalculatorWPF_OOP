using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorWPFLibrery
{
    public class SimpleOperation : IOperations
    {
        public double Oper() 
        {
            Perems.Number1Double = Convert.ToDouble(Perems.Number1);
            Perems.Number2Double = Convert.ToDouble(Perems.Number2);

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



            }
            return Perems.Result;

        }

   
    }
}
