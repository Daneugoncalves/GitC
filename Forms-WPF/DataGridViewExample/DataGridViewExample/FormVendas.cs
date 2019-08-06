
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
    public partial class FormVendas : Form
    {
        public FormVendas()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet.Vendas' table. You can move, or remove it, as needed.
            this.vendasTableAdapter.Fill(this.querysInnerJoinDataSet.Vendas);

        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var VendasSelect = ((System.Data.DataRowView)
               this.dataGridView2.Rows[e.RowIndex].DataBoundItem).Row as
               DataGridViewExample.QuerysInnerJoinDataSet.VendasRow;


            switch (e.ColumnIndex)
            {
                case 0: { this.vendasTableAdapter.DeleteQuery(VendasSelect.Id); } break;
                case 1:
                    {
                        FmrVendas editVendas = new FmrVendas();
                        editVendas.VendasRow = VendasSelect;
                        editVendas.ShowDialog();

                        this.vendasTableAdapter.Update(editVendas.VendasRow);
                    }
                    break;
            }

            this.vendasTableAdapter.Fill(this.querysInnerJoinDataSet.Vendas);
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            FmrAdicionarVenda formAddV = new FmrAdicionarVenda();
            formAddV.ShowDialog();

            if (formAddV.VendaRow == null)
            {
                return;
            }
            else
            { 
                this.vendasTableAdapter.Insert(
                formAddV.VendaRow.Carro,
                formAddV.VendaRow.Quantidade,
                formAddV.VendaRow.Valor,
                true,
                1,
                1,
                DateTime.Now,
                DateTime.Now
                );
            }
                this.vendasTableAdapter.Fill(this.querysInnerJoinDataSet.Vendas);
            
        }
    }
    
}
