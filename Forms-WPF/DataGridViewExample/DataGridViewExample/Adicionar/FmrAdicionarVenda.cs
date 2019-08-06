using DataGridViewExample.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewExample.Adicionar
{
    public partial class FmrAdicionarVenda : Form
    {
        public FmrAdicionarVenda()
        {
            InitializeComponent();
        }

        public Venda VendaRow;

        private void FmrAdicionarVenda_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet.Carros' table. You can move, or remove it, as needed.
            this.carrosTableAdapter.Fill(this.querysInnerJoinDataSet.Carros);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            VendaRow = new Venda

            {
                Carro = (int)comboBox1.SelectedValue,
                Quantidade = int.Parse(textBox1.Text),
                Valor = decimal.Parse(textBox2.Text)
            };
            this.Close();
        }
    }

}


