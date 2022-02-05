using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorWPFLibrery
{
    public class ClassResult
    {
        SimpleOperation simpleOperation = new SimpleOperation();
        public string MethodResult(string TextResultStr) 
        {
                Perems.Number2 = TextResultStr;
                simpleOperation.Oper();
                TextResultStr = Convert.ToString(Perems.Result);
                return TextResultStr;
        }

        public static string MethodResultAndOper(string TextR)
        {
            string TextResultStr = TextR;
            string EnterResult;
            ClassResult classResult = new ClassResult();
            EnterResult = classResult.MethodResult(TextResultStr);
            return EnterResult;

        }

    }
}
