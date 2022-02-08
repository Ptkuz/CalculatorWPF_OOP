namespace CalculatorWPFLibrery
{
    public static class ClassResult
    {
        public static string MethodResult(string TextResultStr)
        {
            if (Perems.FlagOperComp && Perems.PrevOperationComp == ButtonNames.ButtonSqrt)
                Perems.Radical = TextResultStr;
            else if (Perems.FlagOperComp && Perems.PrevOperationComp == ButtonNames.ButtonDegree)
                Perems.Degree = TextResultStr;
            else if (Perems.Operation == ButtonNames.Button1DevideX || Perems.Operation == ButtonNames.ButtonProcent) { }
            else
                Perems.Number2 = TextResultStr;
            SimpleOperation.Oper();
            TextResultStr = Convert.ToString(Perems.Result);
            return TextResultStr;
        }
    }
}
