using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MvcProject.View.Edição
{
    public partial class FrmEditarGenero : Form
    {
        public FrmEditarGenero()
        {
            InitializeComponent();
        }

        public MvcProject.SistemaBibiotecaDBDataSet.GeneroRow GeneroRow;

        private void FrmEditarGenero_Load(object sender, EventArgs e)
        {
            textBox1.Text = GeneroRow.Tipo;
            textBox2.Text = GeneroRow.Descricao;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            GeneroRow.Tipo = textBox1.Text;
            GeneroRow.Descricao = textBox2.Text;
        }
    }
}
