namespace CalculatorWPFLibrery
{
    public class NumbersEnter
    {
        public string Method(string result, string buttonText)
        {
            if (Perems.FlagOper) 
            {
                Perems.FlagOper = false;
                result += buttonText;
                return result;
            
            
            }
            else {
                if (result == "0")
                {
                    result = buttonText;
                    return result;
                }
                else
                {
                    result += buttonText;
                    return result;
                }
            }
            


        }
    }
}