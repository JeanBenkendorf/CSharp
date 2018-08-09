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

namespace WpfApp3
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        long n1 = 0;
        long n2 = 0;
        String op = "";

        public MainWindow()

        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if(String.IsNullOrEmpty(op))
            {
                n1 = (n1 * 10) + 1;
                txtResultado.Text = n1.ToString();
            }
            else
            {

                n2 = (n2 * 10) + 1;
                txtResultado.Text = n2.ToString();
            }
           
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(op))
            {
                n1 = (n1 * 10) + 2;
                txtResultado.Text = n1.ToString();
            }
            else
            {

                n2 = (n2 * 10) + 2;
                txtResultado.Text = n2.ToString();
            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(op))
            {
                n1 = (n1 * 10) + 3;
                txtResultado.Text = n1.ToString();
            }
            else
            {

                n2 = (n2 * 10) + 3;
                txtResultado.Text = n2.ToString();
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(op))
            {
                n1 = (n1 * 10) + 4;
                txtResultado.Text = n1.ToString();
            }
            else
            {

                n2 = (n2 * 10) + 4;
                txtResultado.Text = n2.ToString();
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(op))
            {
                n1 = (n1 * 10) + 5;
                txtResultado.Text = n1.ToString();
            }
            else
            {

                n2 = (n2 * 10) + 5;
                txtResultado.Text = n2.ToString();
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(op))
            {
                n1 = (n1 * 10) + 6;
                txtResultado.Text = n1.ToString();
            }
            else
            {

                n2 = (n2 * 10) + 6;
                txtResultado.Text = n2.ToString();
            }
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(op))
            {
                n1 = (n1 * 10) + 7;
                txtResultado.Text = n1.ToString();
            }
            else
            {

                n2 = (n2 * 10) + 7;
                txtResultado.Text = n2.ToString();
            }
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(op))
            {
                n1 = (n1 * 10) + 8;
                txtResultado.Text = n1.ToString();
            }
            else
            {

                n2 = (n2 * 10) + 8;
                txtResultado.Text = n2.ToString();
            }
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(op))
            {
                n1 = (n1 * 10) + 9;
                txtResultado.Text = n1.ToString();
            }
            else
            {

                n2 = (n2 * 10) + 9;
                txtResultado.Text = n2.ToString();
            }
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(op))
            {
                n1 = (n1 * 10);
                txtResultado.Text = n1.ToString();
            }
            else
            {

                n2 = (n2 * 10);
                txtResultado.Text = n2.ToString();
            }
        }

        private void ctna_Click(object sender, RoutedEventArgs e)
        {
            op = "+";
            //O número 0 será mostrado na tela assim que o símbolo for pressionado
            txtResultado.Text = "";
        }

        private void btns_Click(object sender, RoutedEventArgs e)
        {
            op = "-";
            //O número 0 será mostrado na tela assim que o símbolo for pressionado
            txtResultado.Text = "";
        }

        private void btnm_Click(object sender, RoutedEventArgs e)
        {
            op = "*";
            //O número 0 será mostrado na tela assim que o símbolo for pressionado
            txtResultado.Text = "";
        }

        private void btnd_Click(object sender, RoutedEventArgs e)
        {
            op = "/";
            //O número 0 será mostrado na tela assim que o símbolo for pressionado
            txtResultado.Text = "";
        }

        private void btni_Click(object sender, RoutedEventArgs e)
        {
            switch (op)
            {
                //caso "op" esteja preenchido com +, a conta será efetuada
                case "+":
                    txtResultado.Text = (n1 + n2).ToString();
                    break;

                //caso "op" esteja preenchido com -, a conta será efetuada
                case "-":
                    txtResultado.Text = (n1 - n2).ToString();
                    break;

                //caso "op" esteja preenchido com *, a conta será efetuada
                case "*":
                    txtResultado.Text = (n1 * n2).ToString();
                    break;

                //caso "op" esteja preenchido com /, a conta será efetuada
                case "/":
                    txtResultado.Text = (n1 / n2).ToString();
                    break;

            }
        }

        private void btnc_Click(object sender, RoutedEventArgs e)
        {
            //Zerar as variáveis para resetar a conta
            //Símbolo: ALT + 0140
            n1 = 0;
            n2 = 0;
            op = "";
            //Zerar o resultado na tela ao pressionar o botão
            txtResultado.Text = "0";
        }
    }
}
