using CadstroValidacaodeCampos.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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


namespace CadstroValidacaodeCampos
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
        string email, numero;

        private void BtnSalvar_Click(object sender, RoutedEventArgs e)
        {
            email = txtEmail.Text;
            numero = txtNumero.Text;

            ValidatesCustom validatesCustom = new ValidatesCustom();

            Regex regexTelefone = new Regex(@"^([+][0-9]{2})\([1-9]{2}\) (?:[2-8]|9[1-9])[0-9]{3}\-[0-9]{4}$");
            
            Match match1 = regexTelefone.Match(numero);
           

            if (match1.Success)
            { MessageBox.Show(numero + " Numero correto"); }
            else
            { MessageBox.Show(numero + " Formato de numero inválido, \r tente o formato +DDI(DDD) XXXXX-XXXX"); }


            if (match.Success)
                MessageBox.Show(email + " email correto");
            else
                MessageBox.Show(email + " Formato de email inválido");

        }
    }
}
