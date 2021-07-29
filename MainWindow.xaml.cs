using System;
using System.Windows;
using System.Windows.Input;
using Z.Expressions;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Console.WriteLine(Eval.Execute("2+6*8"));
            // outputField.Content = calculate_num(2, "+", 3);
        }

        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            if (inputField.Text == "Please start typing...")
            {
                inputField.Text = "";
            }
            else if (inputField.Text == "")
            {
                inputField.Text = "Please start typing...";
            }

            string Result = outputField.Text;

            try
            {
                object NumPlaceholder = Eval.Execute(inputField.Text);
                if (NumPlaceholder != null)
                {
                    Result = NumPlaceholder.ToString();
                }
            }
            catch
            {
                Result = "";                
            }
            outputField.Text = Result;
        }
        private void calc_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Button has been pressed");
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            string text;
            text = $"{inputField.Text}7";
            inputField.Text = text;
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            string text;
            text = $"{inputField.Text}8";
            inputField.Text = text;
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            string text;
            text = $"{inputField.Text}9";
            inputField.Text = text;
        }

        private void btnAC_Click(object sender, RoutedEventArgs e)
        {
            inputField.Text = "";
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            string text;
            text = $"{inputField.Text}4";
            inputField.Text = text;
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            string text;
            text = $"{inputField.Text}5";
            inputField.Text = text;
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            string text;
            text = $"{inputField.Text}6";
            inputField.Text = text;
        }

        private void btnMltp_Click(object sender, RoutedEventArgs e)
        {
            string text;
            text = $"{inputField.Text}*";
            inputField.Text = text;
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            string text;
            text = $"{inputField.Text}1";
            inputField.Text = text;
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            string text;
            text = $"{inputField.Text}2";
            inputField.Text = text;
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            string text;
            text = $"{inputField.Text}3";
            inputField.Text = text;
        }

        private void btnEql_Click(object sender, RoutedEventArgs e)
        {
            // Calculate all numbers in inputField
            // Set outputField.Content to result
        }
    }
}
