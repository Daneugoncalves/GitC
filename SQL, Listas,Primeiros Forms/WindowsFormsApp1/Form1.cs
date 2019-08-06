using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Class;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public carro listaDeCarros = new carro();

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            listaDeCarros.Modelo = tbxModelo.Text;
            listaDeCarros.Ano = int.Parse(tbxAno.Text);
            listaDeCarros.Placa = tbxPlaca.Text;

            this.Close();
        }

        
    }
}
