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
            // Sum all numbers in inputField
        }
    }
    public class TextInputToVisibilityConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            // Always test MultiValueConverter inputs for non-null
            // (to avoid crash bugs for views in the designer)
            if (values[0] is bool && values[1] is bool)
            {
                bool hasText = !(bool)values[0];
                bool hasFocus = (bool)values[1];

                if (hasFocus || hasText)
                    return Visibility.Collapsed;
            }

            return Visibility.Visible;
        }


        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
