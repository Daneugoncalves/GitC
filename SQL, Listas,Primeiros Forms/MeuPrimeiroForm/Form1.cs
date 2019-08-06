using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeuPrimeiroForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //variavel para contar o clik do botao
        int Countpress = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Clik event{Countpress}");

            Countpress++;//increment na contagem
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
