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
    public partial class FrmAutores : Form
    {
        public FrmAutores()
        {
            InitializeComponent();
        }

        private void FrmAutores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibiotecaDBDataSet.Autores' table. You can move, or remove it, as needed.
            this.autoresTableAdapter.Fill(this.sistemaBibiotecaDBDataSet.Autores);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var AutoirSelect = ((System.Data.DataRowView)
              this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row as
              MvcProject.SistemaBibiotecaDBDataSet.AutoresRow;

            switch (e.ColumnIndex)

            {
               
                case 0:
                    {
                        FrmEditarAutor editAutor = new FrmEditarAutor();
                        editAutor.AutoresRow = AutoirSelect;
                        editAutor.ShowDialog();

                        this.autoresTableAdapter.Update(editAutor.AutoresRow);
                    }
                    break;

            }
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            FrmAdicionarAutor formAddAutor = new FrmAdicionarAutor();
            formAddAutor.ShowDialog();

            if (!string.IsNullOrEmpty(formAddAutor.AutorRows?.Nome))
            {
                this.autoresTableAdapter.Insert(
                  formAddAutor.AutorRows.Nome,
                  formAddAutor.AutorRows.Descricao
                  );
            }

            this.autoresTableAdapter.Fill(this.sistemaBibiotecaDBDataSet.Autores);
        }
    }
}
