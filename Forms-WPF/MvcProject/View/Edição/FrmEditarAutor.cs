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
    public partial class FrmEditarAutor : Form
    {
        public FrmEditarAutor()
        {
            InitializeComponent();
        }

        public MvcProject.SistemaBibiotecaDBDataSet.AutoresRow AutoresRow;

        private void Button1_Click(object sender, EventArgs e)
        {
            AutoresRow.Nome = textBox1.Text;
            AutoresRow.Descricao = textBox2.Text;
        }

        private void FrmEditarAutor_Load(object sender, EventArgs e)
        {
            textBox1.Text = AutoresRow.Nome;
            textBox2.Text = AutoresRow.Descricao;
        }
    }
}
