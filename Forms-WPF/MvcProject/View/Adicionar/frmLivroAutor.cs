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
    public partial class frmLivroAutor : Form
    {
        public frmLivroAutor()
        {
            InitializeComponent();
        }

        public MvcProject.SistemaBibiotecaDBDataSet.LivrosRow LivrosRow;

        private void LivroAutor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibiotecaDBDataSet.LivroAutor' table. You can move, or remove it, as needed.
            this.livroAutorTableAdapter.FillBy(this.sistemaBibiotecaDBDataSet.LivroAutor, LivrosRow.Id);
            // TODO: This line of code loads data into the 'sistemaBibiotecaDBDataSet.Autores' table. You can move, or remove it, as needed.
            this.autoresTableAdapter.Fill(this.sistemaBibiotecaDBDataSet.Autores);

            label2.Text = LivrosRow.Titulo;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.livroAutorTableAdapter.Insert(LivrosRow.Id,
                    (int)comboBox1.SelectedValue);

            this.livroAutorTableAdapter.FillBy(this.sistemaBibiotecaDBDataSet.LivroAutor, LivrosRow.Id);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
