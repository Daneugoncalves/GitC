using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewExample.Edicao
{
    public partial class FmrVendas : Form
    {
        public FmrVendas()
        {
            InitializeComponent();
        }

        public DataGridViewExample.QuerysInnerJoinDataSet.VendasRow VendasRow;

        private void FmrVendas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet.Carros' table. You can move, or remove it, as needed.
            this.carrosTableAdapter.Fill(this.querysInnerJoinDataSet.Carros);
            comboBox1.Text = VendasRow.Carro.ToString();
            textBox1.Text = VendasRow.Quantidade.ToString();
            textBox2.Text = VendasRow.Valor.ToString();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            VendasRow.Carro = (int)comboBox1.SelectedValue;
            VendasRow.Quantidade = int.Parse(textBox1.Text);
            VendasRow.Valor = Convert.ToDecimal(textBox2.Text);

            this.Close();
        }
    }
}
