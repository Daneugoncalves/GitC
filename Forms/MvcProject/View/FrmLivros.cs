using MvcProject.Model;
using MvcProject.View.Adicionar;
using MvcProject.View.Edição;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MvcProject.View
{
    public partial class FrmLivros : Form
    {
        public FrmLivros()
        {
            InitializeComponent();
        }

        private void FrmLivros_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibiotecaDBDataSet.Livros' table. You can move, or remove it, as needed.
            this.livrosTableAdapter.Fill(this.sistemaBibiotecaDBDataSet.Livros);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FrmAdicionarLivro formAddLivro = new FrmAdicionarLivro();
            formAddLivro.ShowDialog();

            if (!string.IsNullOrEmpty(formAddLivro.LivroRows?.Titulo))

            {
                this.livrosTableAdapter.Insert(
                formAddLivro.LivroRows.Registro,
                formAddLivro.LivroRows.Titulo,
                formAddLivro.LivroRows.Isbn,
                formAddLivro.LivroRows.Genero,
                formAddLivro.LivroRows.Editora,
                formAddLivro.LivroRows.Sinopse,
                formAddLivro.LivroRows.Observacoes,
                true,
                Session.user.Id,
                Session.user.Id,
                DateTime.Now,
                DateTime.Now
                 );

            }

            this.livrosTableAdapter.Fill(this.sistemaBibiotecaDBDataSet.Livros);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var LivroSelect = ((System.Data.DataRowView)
            this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row as
            MvcProject.SistemaBibiotecaDBDataSet.LivrosRow;

            switch (e.ColumnIndex)

            {
                case 0: { this.livrosTableAdapter.DeleteQuery(LivroSelect.Id); } break;

                case 1:
                    {
                        FrmEditarLivro editLivro = new FrmEditarLivro();
                        editLivro.LivrosRow = LivroSelect;
                        editLivro.ShowDialog();

                        this.livrosTableAdapter.Update(editLivro.LivrosRow);
                    }
                    break;
                case 2:
                    {
                        frmLivroAutor formLivroautor = new frmLivroAutor();
                        formLivroautor.ShowDialog();
                    }
                    break;
            }
            this.livrosTableAdapter.Fill(this.sistemaBibiotecaDBDataSet.Livros);
        }
    }
}
