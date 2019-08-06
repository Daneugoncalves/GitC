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
    public partial class FrmAdicionarLivro : Form
    {
        public FrmAdicionarLivro()
        {
            InitializeComponent();
        }

        public Livro LivroRows;

        private void FrmAdicionarLivro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibiotecaDBDataSet.Editora' table. You can move, or remove it, as needed.
            this.editoraTableAdapter.Fill(this.sistemaBibiotecaDBDataSet.Editora);
            // TODO: This line of code loads data into the 'sistemaBibiotecaDBDataSet.Genero' table. You can move, or remove it, as needed.
            this.generoTableAdapter.Fill(this.sistemaBibiotecaDBDataSet.Genero);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            LivroRows = new Livro

            {
                Registro = (int)numericUpDown1.Value,
                Titulo = textBox1.Text,
                Isbn = textBox2.Text,
                Genero = (int)comboBox1.SelectedValue,
                Editora = (int)comboBox2.SelectedValue,
                Sinopse = richTextBox1.Text,
                Observacoes = richTextBox2.Text

            };
            this.Close();
        }
    }
}
