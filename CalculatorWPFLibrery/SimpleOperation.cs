namespace CalculatorWPFLibrery
{
    public static class SimpleOperation
    {



        public static double Oper()
        {
            Perems.Number1Double = Convert.ToDouble(Perems.Number1);
            Perems.Number2Double = Convert.ToDouble(Perems.Number2);
            Perems.RadicalDouble = Convert.ToDouble(Perems.Radical);
            Perems.DegreeDouble = Convert.ToDouble(Perems.Degree);

            double OperProcent = (Perems.Number1Double * Perems.Number2Double) / 100;
            double OperSqrt = Math.Pow(Perems.Number2Double, 1 / Perems.RadicalDouble);
            double OperDegree = Math.Pow(Perems.Number2Double, Perems.DegreeDouble);
            double OperDevide = 1 / Perems.Number2Double;


            if (Perems.PrevOperation != null && Perems.FlagOperComp)
            {
                switch (Perems.PrevOperation)
                {
                    case ButtonNames.ButtonPlus:
                        if (Perems.PrevOperationComp == ButtonNames.ButtonSqrt)
                            Perems.Result = Perems.Number1Double + OperSqrt;

                        else if (Perems.PrevOperationComp == ButtonNames.ButtonDegree)
                            Perems.Result = Perems.Number1Double + OperDegree;
                        else if (Perems.PrevOperationComp == ButtonNames.Button1DevideX)
                            Perems.Result = Perems.Number1Double + OperDevide;
                        break;
                    case ButtonNames.ButtonMinus:
                        if (Perems.PrevOperationComp == ButtonNames.ButtonSqrt)
                            Perems.Result = Perems.Number1Double - OperSqrt;

                        else if (Perems.PrevOperationComp == ButtonNames.ButtonDegree)
                            Perems.Result = Perems.Number1Double - OperDegree;
                        else if (Perems.PrevOperationComp == ButtonNames.Button1DevideX)
                            Perems.Result = Perems.Number1Double - OperDevide;
                        break;
                    case ButtonNames.ButtonMulti:
                        if (Perems.PrevOperationComp == ButtonNames.ButtonSqrt)
                            Perems.Result = Perems.Number1Double * OperSqrt;

                        else if (Perems.PrevOperationComp == ButtonNames.ButtonDegree)
                            Perems.Result = Perems.Number1Double * OperDegree;
                        else if (Perems.PrevOperationComp == ButtonNames.Button1DevideX)
                            Perems.Result = Perems.Number1Double * OperDevide;
                        break;
                    case ButtonNames.ButtonDevide:
                        if (Perems.PrevOperationComp == ButtonNames.ButtonSqrt)
                            Perems.Result = Perems.Number1Double / OperSqrt;

                        else if (Perems.PrevOperationComp == ButtonNames.ButtonDegree)
                            Perems.Result = Perems.Number1Double / OperDegree;
                        else if (Perems.PrevOperationComp == ButtonNames.Button1DevideX)
                            Perems.Result = Perems.Number1Double / OperDevide;
                        break;



                }
            }
            else
            {
                switch (Perems.Operation)
                {
                    case ButtonNames.ButtonPlus:
                        Perems.Result = Perems.Number1Double + Perems.Number2Double;
                        break;
                    case ButtonNames.ButtonMinus:
                        Perems.Result = Perems.Number1Double - Perems.Number2Double;
                        break;
                    case ButtonNames.ButtonMulti:
                        Perems.Result = Perems.Number1Double * Perems.Number2Double;
                        break;
                    case ButtonNames.ButtonDevide:
                        Perems.Result = Perems.Number1Double / Perems.Number2Double;
                        break;
                    case ButtonNames.ButtonSqrt:
                        Perems.Result = (Math.Pow(Perems.Number1Double, 1 / Perems.Number2Double));
                        break;
                    case ButtonNames.ButtonDegree:
                        Perems.Result = (Math.Pow(Perems.Number1Double, Perems.Number2Double));
                        break;
                    case ButtonNames.Button1DevideX:
                        if (Perems.Number2 != null)
                        {
                            switch (Perems.PrevOperation)
                            {
                                case ButtonNames.ButtonPlus:
                                    Perems.Result = Perems.Number1Double + OperDevide;
                                    break;
                                case ButtonNames.ButtonMinus:
                                    Perems.Result = Perems.Number1Double - OperDevide;
                                    break;
                                case ButtonNames.ButtonMulti:
                                    Perems.Result = Perems.Number1Double * OperDevide;
                                    break;
                                case ButtonNames.ButtonDevide:
                                    Perems.Result = Perems.Number1Double / OperDevide;
                                    break;

                            }
                        }
                        else
                            Perems.Result = 1 / Perems.Number1Double;


                        break;
                    case ButtonNames.ButtonProcent:
                        switch (Perems.PrevOperation)
                        {
                            case ButtonNames.ButtonPlus:
                                Perems.Result = Perems.Number1Double + OperProcent;
                                break;
                            case ButtonNames.ButtonMinus:
                                Perems.Result = Perems.Number1Double - OperProcent;
                                break;
                            case ButtonNames.ButtonMulti:
                                Perems.Result = Perems.Number1Double * OperProcent;
                                break;
                            case ButtonNames.ButtonDevide:
                                Perems.Result = Perems.Number1Double / OperProcent;
                                break;

                        }
                        break;




                }
            }

            return Perems.Result;

        }


    }
}
