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
    public partial class fmrAdicionarUsuario : Form
    {
        public fmrAdicionarUsuario()
        {
            InitializeComponent();
        }

        public Usuario UsuariosRow;

        private void Button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Trim().Length < 1)
            {
                MessageBox.Show("Informe a marca");
                return;
            }
            UsuariosRow = new Usuario

            {
                usuario = textBox1.Text
            };

            this.Close();
        }

        private void FmrAdicionarUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
