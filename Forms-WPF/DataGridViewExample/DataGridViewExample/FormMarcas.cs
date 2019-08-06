using DataGridViewExample.Adicionar;
using DataGridViewExample.Edicao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewExample
{
    public partial class FormMarcas : Form
    {
        public FormMarcas()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet.Marcas' table. You can move, or remove it, as needed.
            this.marcasTableAdapter.Fill(this.querysInnerJoinDataSet.Marcas);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var MarcasSelect = ((System.Data.DataRowView)
               this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row as
               DataGridViewExample.QuerysInnerJoinDataSet.MarcasRow;

            switch (e.ColumnIndex)
            {
                case 0: { this.marcasTableAdapter.DeleteQuery(MarcasSelect.Id); } break;
                case 1:
                    {
                        fmrEditarMarcas editMarcas = new fmrEditarMarcas();
                        editMarcas.MarcasRow = MarcasSelect;
                        editMarcas.ShowDialog();

                        this.marcasTableAdapter.Update(editMarcas.MarcasRow);
                    }
                    break;
            }
            this.marcasTableAdapter.Fill(this.querysInnerJoinDataSet.Marcas);
        }

        private void FillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.marcasTableAdapter.Fill(this.querysInnerJoinDataSet.Marcas);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            fmrAdicionarMarca formAddM = new fmrAdicionarMarca();
            formAddM.ShowDialog();

         if(!string.IsNullOrEmpty(formAddM.marcasRow?.Nome))

            {
               this.marcasTableAdapter.Insert(
               formAddM.marcasRow.Nome,
               true,
               1,
               1,
               DateTime.Now,
               DateTime.Now
               );

                this.marcasTableAdapter.Fill(this.querysInnerJoinDataSet.Marcas);
            }   
        }

        private void FillByToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
