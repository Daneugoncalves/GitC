using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormGridView.Edição;

namespace WindowsFormGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet1.Carros' table. You can move, or remove it, as needed.
            this.carrosTableAdapter1.CustomQuerry(this.querysInnerJoinDataSet1.Carros);
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet.Carros' table. You can move, or remove it, as needed.
        }

     

        private void Button1_Click(object sender, EventArgs e)
        {
           fmrMarcas marcas = new fmrMarcas();
            marcas.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            FmrUsuarios usuario = new FmrUsuarios();
            usuario.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            FmrVendas venda = new FmrVendas();
            venda.ShowDialog();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var carSelect = ((System.Data.DataRowView)
                this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row

            as WindowsFormGridView.QuerysInnerJoinDataSet1.CarrosRow;

            // MessageBox.Show(carSelect.Ano.ToString());

            switch (e.ColumnIndex)
            {
                  case 0:
                    {
                        this.carrosTableAdapter1.DeleteQuery(carSelect.Id);
                    }
                    break;
                case 1: { frmEdicaoDeCArros editCArro = new frmEdicaoDeCArros();
                        editCArro.CarrosRow = carSelect;
                        editCArro.ShowDialog();
                        } break;
            }
            this.carrosTableAdapter1.CustomQuerry(querysInnerJoinDataSet1.Carros);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
          //  Lixeira lixo = new Lixeira();
          //  lixo.ShowDialog();
        }
    }
}
