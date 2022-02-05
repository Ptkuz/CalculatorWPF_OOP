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
            NumbersEnter numbersEnter = new NumbersEnter();
            string OperationOne = numbersEnter.Method(TextBoxStr, ButtonText);
            TextResult.Text = OperationOne;
            //// Ввод первого числа
        }

        private void Operations_Click(object sender, RoutedEventArgs e)
        {
            if (Perems.Number1 != null)
            {
                string str = TextResult.Text;
                string EnterResult = ClassResult.MethodResultAndOper(str);
                Button? operation = sender as Button;
                Perems.Operation = operation.Content.ToString();
                TextOperation.Text = $"{EnterResult} {Perems.Operation}";
                Perems.Number1 = EnterResult;
                TextResult.Clear();
            }
            //// Первая операция
            else if (Perems.Number1==null) 
            {
                Button? operation = sender as Button;
                Perems.Operation = operation.Content.ToString();
                Perems.Number1 = TextResult.Text;
                TextResult.Clear();
                TextOperation.Text = $"{Perems.Number1} {Perems.Operation}";
            }
            //// Первая операция
        
        }

        private void Result_Click(object sender, RoutedEventArgs e)
        {
            //// Результат первой операции
            string str = TextResult.Text;
            string EnterResult = ClassResult.MethodResultAndOper(str);
            TextResult.Text = EnterResult;
            TextOperation.Text = $"{Perems.Number1} {Perems.Operation} {Perems.Number2}";
            Perems.DropPerem();
            //// Результат первой операции
        }
    }
}
