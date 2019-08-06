using MvcProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MvcProject.View.Adicionar
{
    public partial class FrmAdicionarGenero : Form
    {
        public FrmAdicionarGenero()
        {
            InitializeComponent();
        }

        public Genero GeneroRows;

        private void FrmAdicionarGenero_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            GeneroRows = new Genero

            {
                Tipo = textBox1.Text,
                Descricao = textBox2.Text
            };

            this.Close();
        }
    }
}
