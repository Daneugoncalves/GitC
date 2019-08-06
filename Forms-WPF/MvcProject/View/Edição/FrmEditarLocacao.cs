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

namespace MvcProject.View.Edição
{
    public partial class FrmEditarLocacao : Form
    {
        public FrmEditarLocacao()
        {
            InitializeComponent();
        }

        public MvcProject.SistemaBibiotecaDBDataSet.LocacaoRow LocacaoRow;

        private void FrmEditarLocacao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibiotecaDBDataSet.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.Fill(this.sistemaBibiotecaDBDataSet.Usuarios);
            // TODO: This line of code loads data into the 'sistemaBibiotecaDBDataSet.Livros' table. You can move, or remove it, as needed.
            this.livrosTableAdapter.Fill(this.sistemaBibiotecaDBDataSet.Livros);

            textBox1.Text = Convert.ToString(LocacaoRow.Tipo);
            dateTimePicker1.Value = LocacaoRow.Devolucao;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            LocacaoRow.Livro = (int)comboBox1.SelectedValue;
            LocacaoRow.Usuario = (int)comboBox2.SelectedValue;
            LocacaoRow.Tipo = int.Parse(textBox1.Text);
            LocacaoRow.Devolucao = dateTimePicker1.Value;
            LocacaoRow.UsuAlt = Session.user.Id;
        }
    }
}
