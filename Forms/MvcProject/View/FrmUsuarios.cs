using MvcProject.Adicionar;
using MvcProject.Edição;
using MvcProject.Model;
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
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibiotecaDBDataSet1.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.Fill(this.sistemaBibiotecaDBDataSet1.Usuarios);
      
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var UsuarioSelect = ((System.Data.DataRowView)
            this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row as
            MvcProject.SistemaBibiotecaDBDataSet.UsuariosRow;

            switch (e.ColumnIndex)
            {
                case 0: { this.usuariosTableAdapter.DeleteQuery(UsuarioSelect.Id); } break;
                case 1:
                   {
                      FmrEditarUsuario editUsuario = new FmrEditarUsuario();
                        editUsuario.usuariosRow = UsuarioSelect;
                        editUsuario.ShowDialog();
              
                      this.usuariosTableAdapter.Update(editUsuario.usuariosRow);
                  }

                    break;

            }
            this.usuariosTableAdapter.Fill(this.sistemaBibiotecaDBDataSet1.Usuarios);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FrmAdicionarUsuario formAddU = new FrmAdicionarUsuario();
            formAddU.ShowDialog();

            if (!string.IsNullOrEmpty(formAddU.usuariosRow?.Nome))

            {
                this.usuariosTableAdapter.Insert(
                formAddU.usuariosRow.Nome,
                formAddU.usuariosRow.Login,
                formAddU.usuariosRow.Senha,
                formAddU.usuariosRow.Email,
                true,
                Session.user.Id,
                Session.user.Id,
                DateTime.Now,
                DateTime.Now
                );

              
                this.usuariosTableAdapter.Fill(this.sistemaBibiotecaDBDataSet1.Usuarios);
            }
        }
    }
    
}
