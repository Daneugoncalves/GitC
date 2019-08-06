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
    public partial class FrmEditarLivro : Form
    {
        public FrmEditarLivro()
        {
            InitializeComponent();
        }
        public MvcProject.SistemaBibiotecaDBDataSet.LivrosRow LivrosRow;
        private void FrmEditarLivro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibiotecaDBDataSet.Editora' table. You can move, or remove it, as needed.
            this.editoraTableAdapter.Fill(this.sistemaBibiotecaDBDataSet.Editora);
            // TODO: This line of code loads data into the 'sistemaBibiotecaDBDataSet.Genero' table. You can move, or remove it, as needed.
            this.generoTableAdapter.Fill(this.sistemaBibiotecaDBDataSet.Genero);
            // TODO: This line of code loads data into the 'sistemaBibiotecaDBDataSet.Livros' table. You can move, or remove it, as needed.
            this.livrosTableAdapter.Fill(this.sistemaBibiotecaDBDataSet.Livros);
            numericUpDown1.Value = LivrosRow.Registro;
            textBox1.Text = LivrosRow.Titulo;
            textBox2.Text = LivrosRow.Isbn;
            comboBox1.SelectedValue = LivrosRow.Genero;
            comboBox2.SelectedValue = LivrosRow.Editora;
            richTextBox1.Text = LivrosRow.Observações;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            LivrosRow.Registro = (int)numericUpDown1.Value;
            LivrosRow.Titulo = textBox1.Text;
            LivrosRow.Isbn = textBox2.Text;
            LivrosRow.Genero = (int)comboBox1.SelectedValue;
            LivrosRow.Editora = (int)comboBox2.SelectedValue;
            LivrosRow.Sinopse = richTextBox1.Text;
            LivrosRow.Observações = richTextBox2.Text;
            LivrosRow.UsuAlt = Session.user.Id;
        }
    }
}
