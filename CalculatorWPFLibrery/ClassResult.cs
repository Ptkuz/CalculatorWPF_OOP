namespace CalculatorWPFLibrery
{
    public static class ClassResult
    {
        public static string MethodResult(string TextResultStr)
        {
            if (Perems.FlagOperComp)
                Perems.Radical = TextResultStr;
            else
                Perems.Number2 = TextResultStr;
            SimpleOperation.Oper();
            TextResultStr = Convert.ToString(Perems.Result);
            return TextResultStr;
        }
    }
}
