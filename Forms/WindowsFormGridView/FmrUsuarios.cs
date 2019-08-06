using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormGridView
{
    public partial class FmrUsuarios : Form
    {
        public FmrUsuarios()
        {
            InitializeComponent();
        }

        private void FmrUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet1.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.customQuerry(this.querysInnerJoinDataSet1.Usuarios);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var UsuSelect = ((System.Data.DataRowView)
              this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row

          as WindowsFormGridView.QuerysInnerJoinDataSet1.UsuariosRow;



            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        this.usuariosTableAdapter.DeleteQuery(UsuSelect.Id);
                    }
                    break;
            }
            this.usuariosTableAdapter.customQuerry(querysInnerJoinDataSet1.Usuarios);
        }
    }
}
