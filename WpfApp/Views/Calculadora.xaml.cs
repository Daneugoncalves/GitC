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
using System.Windows.Shapes;

namespace WpfApp.Views
{
    /// <summary>
    /// Interaction logic for Calculadora.xaml
    /// </summary>
    /// 

    public partial class Calculadora : Window
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        double acumula = 0;
        string operacao = "";
   

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (operacao == "-" || operacao == "+" || operacao == "/")
            {
                operacao = "*";
            }
            else
            {
                acumula = double.Parse(display.Text);
                display.Text = "";
                operacao = "*";
            }
        }

    

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            display.Text += "1";
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "2";
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "3";
        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "4";
        }

        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "5";
        }

        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "6";
        }

        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "7";
        }

        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "8";
        }

        private void Btn9_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "9";
        }

        private void Btnigual_Click(object sender, RoutedEventArgs e)
        {
            if (operacao == "+")
            {
                acumula += double.Parse(display.Text);
                display.Text = acumula.ToString();
            }
            else if (operacao == "-")
            {
                acumula -= double.Parse(display.Text);
                display.Text = acumula.ToString();
            }
            else if (operacao == "*")
            {
                acumula *= double.Parse(display.Text);
                display.Text = acumula.ToString();
            }
            else if (operacao == "/")
            {
                if (double.Parse(display.Text) != 0)
                {
                    acumula /= double.Parse(display.Text);
                    display.Text = acumula.ToString();
                }
                else
                {
                    display.Text = "Dividindo por zero";
                }
            }
        }

        private void Btnsom_Click(object sender, RoutedEventArgs e)
        {

            if (operacao == "*" || operacao == "-" || operacao == "/")
            {
                operacao = "+";
            }
            else
            {
                acumula = double.Parse(display.Text);
                display.Text = "";
                operacao = "+";
            }
        }

        private void Btnvir_Click(object sender, RoutedEventArgs e)
        {
             display.Text += ",";
        }

        private void subtracao_Click(object sender, RoutedEventArgs e)
        {
            if (operacao == "*" || operacao == "+" || operacao == "/")
            {
                operacao = "-";
            }  else {
                acumula = double.Parse(display.Text);
                display.Text = "";
                operacao = "-";
            }
        }

        

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (operacao == "*" || operacao == "+" || operacao == "-")
            {
                operacao = "/";
            }
            else
            {
                acumula = double.Parse(display.Text);
                display.Text = "";
                operacao = "/";
            }
        }

        private void Btnapagar_Click(object sender, RoutedEventArgs e)
        {
            int x = display.Text.Length - 1;
            if (x >= 0)
            {
                display.Text = display.Text.Substring(0, x);
            }
        }

        private void CE_Click(object sender, RoutedEventArgs e)
        {
            display.Text = "";
            
        }

        private void C_Click(object sender, RoutedEventArgs e)
        {
            acumula = 0;
            display.Text = "";
        }

        private void Btnsub_Click(object sender, RoutedEventArgs e)
        {
            if (operacao == "*" || operacao == "+" || operacao == "/")
            {
                operacao = "-";
            }
            else
            {
                acumula = double.Parse(display.Text);
                display.Text = "";
                operacao = "-";
            }
        }
    }
}
