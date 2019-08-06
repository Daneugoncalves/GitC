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
    public partial class FrmLocacao : Form
    {
        public FrmLocacao()
        {
            InitializeComponent();
        }

        private void FrmLocacao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibiotecaDBDataSet.Locacao' table. You can move, or remove it, as needed.
            this.locacaoTableAdapter.Fill(this.sistemaBibiotecaDBDataSet.Locacao);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var Locacaoselect = ((System.Data.DataRowView)
            this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row as
            MvcProject.SistemaBibiotecaDBDataSet.LocacaoRow;

            switch (e.ColumnIndex)
            {
                case 0: { this.locacaoTableAdapter.DeleteQuery(Locacaoselect.Id); } break;
                case 1:
                    {
                        FrmEditarLocacao editLocacao = new FrmEditarLocacao();
                        editLocacao.LocacaoRow = Locacaoselect;
                        editLocacao.ShowDialog();

                        this.locacaoTableAdapter.Update(editLocacao.LocacaoRow);
                    }

                    break;

            }
            this.locacaoTableAdapter.Fill(this.sistemaBibiotecaDBDataSet.Locacao);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FrmAdicionarLocacao formAddLoca = new FrmAdicionarLocacao();
            formAddLoca.ShowDialog();

            if (formAddLoca.LocacaoRows?.Tipo > 0)

            {
                this.locacaoTableAdapter.Insert(
                formAddLoca.LocacaoRows.Livro,
                formAddLoca.LocacaoRows.Usuario,
                formAddLoca.LocacaoRows.Tipo,
                formAddLoca.LocacaoRows.Devolucao,
                true,
                Session.user.Id,
                Session.user.Id,
                DateTime.Now,
                DateTime.Now
                );
                this.locacaoTableAdapter.Fill(this.sistemaBibiotecaDBDataSet.Locacao);
            }
        }
    }
}
