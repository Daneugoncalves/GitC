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
    public partial class FrmAdicionarLocacao : Form
    {
        public FrmAdicionarLocacao()
        {
            InitializeComponent();
        }

        public Locacao LocacaoRows;

        private void FrmAdicionarLocacao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibiotecaDBDataSet.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.Fill(this.sistemaBibiotecaDBDataSet.Usuarios);
            // TODO: This line of code loads data into the 'sistemaBibiotecaDBDataSet.Livros' table. You can move, or remove it, as needed.
            this.livrosTableAdapter.Fill(this.sistemaBibiotecaDBDataSet.Livros);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            LocacaoRows = new Locacao
            {
                Livro = (int)comboBox1.SelectedValue,
                Usuario = (int)comboBox2.SelectedValue,
                Tipo = int.Parse(textBox1.Text),
                Devolucao = dateTimePicker1.Value

            };

            this.Close();
        }
    }
}
