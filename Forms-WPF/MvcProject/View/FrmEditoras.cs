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
    public partial class FrmEditoras : Form
    {
        public FrmEditoras()
        {
            InitializeComponent();
        }

        private void FrmEditoras_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibiotecaDBDataSet.Editora' table. You can move, or remove it, as needed.
            this.editoraTableAdapter.Fill(this.sistemaBibiotecaDBDataSet.Editora);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var EditoraSelect = ((System.Data.DataRowView)
              this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row as
              MvcProject.SistemaBibiotecaDBDataSet.EditoraRow;

            switch (e.ColumnIndex)

            {
                case 0:
                    {
                        FmrEditarEditora editEditora = new FmrEditarEditora();
                        editEditora.EditoraRow = EditoraSelect;
                        editEditora.ShowDialog();

                        this.editoraTableAdapter.Update(editEditora.EditoraRow);
                    }
                    break;
            }
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            FrmAdicionarEditora formAddEditora = new FrmAdicionarEditora();
            formAddEditora.ShowDialog();

            if (!string.IsNullOrEmpty(formAddEditora.EditoraRows?.Nome))
            {
                this.editoraTableAdapter.Insert(
                  formAddEditora.EditoraRows.Nome,
                  formAddEditora.EditoraRows.Descricao
                  );
            }
               
            this.editoraTableAdapter.Fill(this.sistemaBibiotecaDBDataSet.Editora);
        
    }
    }
}
