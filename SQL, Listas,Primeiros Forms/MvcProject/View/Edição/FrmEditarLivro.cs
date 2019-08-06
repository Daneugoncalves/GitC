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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public MvcProject.SistemaBibiotecaDBDataSet.LivrosRow LivrosRow;
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibiotecaDBDataSet.Editora' table. You can move, or remove it, as needed.
            this.editoraTableAdapter.Fill(this.sistemaBibiotecaDBDataSet.Editora);
            // TODO: This line of code loads data into the 'sistemaBibiotecaDBDataSet.Genero' table. You can move, or remove it, as needed.
            this.generoTableAdapter.Fill(this.sistemaBibiotecaDBDataSet.Genero);

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



        }
    }
}
