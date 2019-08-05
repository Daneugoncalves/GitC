using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MvcProject.Edição
{
    public partial class FmrEditarUsuario : Form
    {
        public FmrEditarUsuario()
        {
            InitializeComponent();
        }
        public MvcProject.SistemaBibiotecaDBDataSet.UsuariosRow usuariosRow;

        private void FmrEditarUsuario_Load(object sender, EventArgs e)
        {
           
            textBox1.Text = usuariosRow.Nome;
            textBox2.Text = usuariosRow.Login;
            textBox3.Text = usuariosRow.Senha;
            textBox4.Text = usuariosRow.Email;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            usuariosRow.Nome = textBox1.Text;
            usuariosRow.Login = textBox2.Text;
            usuariosRow.Senha = textBox3.Text;
            usuariosRow.Email = textBox4.Text;

        }
    }
}
