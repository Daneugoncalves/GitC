using MvcProject.Model;
using MvcProject.View.Adicionar;
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
            
          

        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            FrmAdicionargenero formAddGenero = new FrmAdicionargenero();
            formAddGenero.ShowDialog();

            //    this.generoTableAdapter.Insert
          // (
          //     formAddGenero.GeneroRows.Tipo,
          //     formAddGenero.GeneroRows.Descricao
          //     );
          // this.generoTableAdapter.Fill(this.sistemaBibiotecaDBDataSet.Genero);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
