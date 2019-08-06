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
    public partial class FormUsuario : Form
    {
        public FormUsuario()
        {
            InitializeComponent();
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.Fill(this.querysInnerJoinDataSet.Usuarios);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var UsuSelect = ((System.Data.DataRowView)
              this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row as
              DataGridViewExample.QuerysInnerJoinDataSet.UsuariosRow;


            switch (e.ColumnIndex)
            {
                case 0: { this.usuariosTableAdapter.DeleteQuery(UsuSelect.Id); } break;
                case 1:
                    {
                        fmrEditarUsuario editUsuario = new fmrEditarUsuario();
                        editUsuario.UsuariosRow = UsuSelect;
                        editUsuario.ShowDialog();

                        this.usuariosTableAdapter.Update(editUsuario.UsuariosRow);
                    }
                    break;

                
            }
            this.usuariosTableAdapter.Fill(this.querysInnerJoinDataSet.Usuarios);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            fmrAdicionarUsuario formAddU = new fmrAdicionarUsuario();
            formAddU.ShowDialog();

            if (formAddU.UsuariosRow == null)
            {
                return;
            }
            else
            {
                this.usuariosTableAdapter.Insert(
                formAddU.UsuariosRow.usuario,
                true,
                1,
                1,
                DateTime.Now,
                DateTime.Now
                );
            }
            this.usuariosTableAdapter.Fill(this.querysInnerJoinDataSet.Usuarios);

        }
    }
    
}
