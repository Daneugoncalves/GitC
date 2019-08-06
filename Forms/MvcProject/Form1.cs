using MvcProject.Model;
using MvcProject.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MvcProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        public Usuario UsuarioRows;

        private void Button1_Click(object sender, EventArgs e)
        {


             var result = this.usuariosTableAdapter1.LoginQuery(textBox1.Text, textBox2.Text);

            if (result != null)
            {
                Session.user = new Usuario();
                Session.user.Id = (int)result;

                frmPrincipal formAddM = new frmPrincipal();
                formAddM.ShowDialog();
            }
            else
            {
                MessageBox.Show("Login inválido!");
            }


        }

            private void Form1_Load(object sender, EventArgs e)
            {

            }

        private void Button1_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
