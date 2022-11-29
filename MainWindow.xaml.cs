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

namespace rekenmachine_variant_true
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // decimal met een ? zorgt ervoor dat je een variabel met NULL kan zetten.
        // zonder een ? is het 0 default
        decimal? valueFirst = null;
        decimal? valueSecond = null;

        string operators;

        private void decimal_Click(object sender, RoutedEventArgs e)
        {
            if (!TxtBox.Text.Contains("."))
            {
                TxtBox.Text += '.';
            }
        }

        private void num_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            TxtBox.Text += btn.Content.ToString();
            if (valueFirst == null)
            {
                valueFirst = decimal.Parse(TxtBox.Text);
            } else {
                valueSecond = decimal.Parse(TxtBox.Text);
            }
        }

        private void minusPlus_Click(object sender, RoutedEventArgs e)
        {
            if (TxtBox.Text.Contains("-"))
            {
                TxtBox.Text = TxtBox.Text.Trim('-');
            }
            else {
                TxtBox.Text = "-" + TxtBox.Text;
            }
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            TxtBox.Clear();
            operators = "-";
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            TxtBox.Clear();
            operators = "+";
        }

        private void keer_Click(object sender, RoutedEventArgs e)
        {
            TxtBox.Clear();
            operators = "*";
        }

        private void deel_Click(object sender, RoutedEventArgs e)
        {
            TxtBox.Clear();
            operators = "/";
        }

        private void modulo_Click(object sender, RoutedEventArgs e)
        {

            TxtBox.Clear();
            operators = "%";
        }

        private void is_Click(object sender, RoutedEventArgs e)
        {

            switch(operators)
            {
                case "+":
                    TxtBox.Text = (valueFirst + valueSecond).ToString();
                    break;

                case "-":
                    TxtBox.Text = (valueFirst - valueSecond).ToString();
                    break;

                case "*":
                    TxtBox.Text = (valueFirst * valueSecond).ToString();
                    break;

                case "/":
                    TxtBox.Text = (valueFirst / valueSecond).ToString();
                    break;

                case "%":
                    TxtBox.Text = (valueFirst % valueSecond).ToString();
                    break;

            }

        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            TxtBox.Clear();
            valueFirst = null;
            valueSecond = null;
        }

        public MainWindow()
        {
            InitializeComponent();
        }
    }
}