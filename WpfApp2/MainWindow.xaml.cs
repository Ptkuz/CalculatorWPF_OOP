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
    // Изменение для гита
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
            //// Ввод первого числа
            Button? number = sender as Button;
            string? ButtonText = number.Content.ToString();
            string TextBoxStr = TextResult.Text;
            string OperationOne = NumbersEnter.Method(TextBoxStr, ButtonText);
            TextResult.Text = OperationOne;
            //// Ввод первого числа
        }

        public void ComplexOperation( object sender) 
        {
            Perems.PrevNumber1 = Perems.Number1;
            Perems.FlagOper = true;
            string str = TextResult.Text;
            Perems.PrevOperationComp = Perems.Operation;
            string EnterResult = ClassResult.MethodResult(str);
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
                    Perems.Number2 = TextResult.Text;
                    Perems.FlagOperComp = true;
                }
                else
                {
                    Perems.Number1 = EnterResult;
                }
                TextOperation.Text = ChoiseOperation.ChoiseMethod();
                TextResult.Clear();
            }
            //// Первая операция
            else if (Perems.Number1 == null)
            {
                Perems.FlagOper = true;
                Button? operation = sender as Button;
                Perems.Operation = operation.Content.ToString();
                Perems.Number1 = TextResult.Text;
                TextOperation.Text = ChoiseOperation.ChoiseMethod();
                TextResult.Clear();

            }
            //// Первая операция
        
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
    }
}
