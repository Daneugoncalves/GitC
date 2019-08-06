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
    public partial class FrmGenero : Form
    {
        public FrmGenero()
        {
            InitializeComponent();
        }

        private void FrmGenero_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibiotecaDBDataSet.Genero' table. You can move, or remove it, as needed.
            this.generoTableAdapter.Fill(this.sistemaBibiotecaDBDataSet.Genero);

        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            FrmAdicionarGenero formAddGenero = new FrmAdicionarGenero();
            formAddGenero.ShowDialog();
            if (!string.IsNullOrEmpty(formAddGenero.GeneroRows?.Tipo))
            {
                this.generoTableAdapter.Insert(
                formAddGenero.GeneroRows.Tipo,
                formAddGenero.GeneroRows.Descricao); 
             };
           
            this.generoTableAdapter.Fill(this.sistemaBibiotecaDBDataSet.Genero);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var GeneroSelect = ((System.Data.DataRowView)
             this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row as
             MvcProject.SistemaBibiotecaDBDataSet.GeneroRow;

            switch (e.ColumnIndex)

            { 
                case 0:
                    {
                        FrmEditarGenero editGenero = new FrmEditarGenero();
                        editGenero.GeneroRow = GeneroSelect;
                        editGenero.ShowDialog();

                        this.generoTableAdapter.Update(editGenero.GeneroRow);
                    }
                    break;

            }
            this.generoTableAdapter.Fill(this.sistemaBibiotecaDBDataSet.Genero);
        }

    }
}

