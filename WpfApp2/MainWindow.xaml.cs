using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CalculatorWPFLibrery;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        

        private void Numbers_Click(object sender, RoutedEventArgs e)
        {
            Button? number = sender as Button;
            string? ButtonText = number.Content.ToString();
            string TextBoxStr = TextResult.Text;
            string OperationOne = NumbersEnter.Method(TextBoxStr, ButtonText);
            TextResult.Text = OperationOne;
        }

        public void ComplexOperation( object sender) 
        {
            Perems.PrevNumber1 = Perems.Number1;
            Perems.FlagOper = true;
            string str = TextResult.Text;
            Perems.PrevOperationComp = Perems.Operation;
            string EnterResult = ClassResult.MethodResult(str);
            Perems.SQR_SQRT = Perems.Radical != null ? Perems.Radical : Perems.Degree;
            Perems.Number1 = EnterResult;
            Button? operation = sender as Button;
            Perems.Operation = operation.Content.ToString();
            TextOperation.Text = ChoiseOperation.ChoiseMethod();
            Perems.DropPerem();
            Perems.Number1 = EnterResult;
            Perems.Operation = operation.Content.ToString();
            

        }

        private void Operations_Click(object sender, RoutedEventArgs e)
        {
            if (Perems.Number1 != null && Perems.Number2 != null && Perems.FlagOperComp) 
            {
               
                ComplexOperation(sender);
                TextResult.Clear();

            }
            else if (Perems.Number1 != null)
            {
                Perems.FlagOper = true;
                string str = TextResult.Text;
                string EnterResult = ClassResult.MethodResult(str);
                Perems.PrevOperation = Perems.Operation;
                Button? operation = sender as Button;
                Perems.Operation = operation.Content.ToString();
                if (ButtonNames.EqualsOperations() && Perems.Number1 != null)
                {
                    EnterResult = ClassResult.MethodResult(str);
                    if (Perems.Operation == ButtonNames.Button1DevideX || Perems.Operation == ButtonNames.ButtonProcent) 
                    { 
                        TextResult.Text = EnterResult;
                        TextOperation.Text = ChoiseOperation.ChoiseMethod();
                    }
                    else
                    {

                        Perems.Number2 = TextResult.Text;
                        Perems.FlagOperComp = true;
                        TextOperation.Text = ChoiseOperation.ChoiseMethod();
                        TextResult.Clear();
                    }
                }
                else
                {
                    Perems.Number1 = EnterResult;
                    TextOperation.Text = ChoiseOperation.ChoiseMethod();
                    TextResult.Clear();
                }
                
            }
            else if (Perems.Number1 == null)
            {
                Perems.FlagOper = true;
                Button? operation = sender as Button;
                Perems.Operation = operation.Content.ToString();
                if (ButtonNames.EqualsOperations())
                {
                    Perems.Number1 = TextResult.Text;
                    string str = TextResult.Text;
                    string EnterResult = ClassResult.MethodResult(str);
                    TextResult.Text = EnterResult;


                }
                else
                {
                    Perems.Number1 = TextResult.Text;
                    TextResult.Clear();
                }
                TextOperation.Text = ChoiseOperation.ChoiseMethod();

            }
        
        }

        private void Result_Click(object sender, RoutedEventArgs e)
        {
            if (Perems.Number1 != null && Perems.Number2 != null && Perems.FlagOperComp)
            {
                ComplexOperation(sender);
                TextResult.Text = Perems.Number1;

            }
            else
            {
                string str = TextResult.Text;
                string EnterResult = ClassResult.MethodResult(str);
                TextResult.Text = EnterResult;
                Perems.FlagOper = false;
                TextOperation.Text = ChoiseOperation.ChoiseMethod();
            }
            Perems.DropPerem();
        }

        private void C_Click(object sender, RoutedEventArgs e)
        {
            TextResult.Clear();
            TextOperation.Clear();
            TextResult.Text = "0";
            Perems.DropPerem();
        }

        private void CE_Click(object sender, RoutedEventArgs e)
        {
            if (TextResult.Text!=null && TextResult.Text!="0") 
            {
                TextResult.Clear();
                TextResult.Text = "0";
            }
        }

        private void NumberProcent_Copy11_Click(object sender, RoutedEventArgs e)
        {
            if (TextResult.Text.Length>1)  
            TextResult.Text = TextResult.Text.Remove(TextResult.Text.Length - 1);
            else
                TextResult.Text = "0";
        }
    }
}
