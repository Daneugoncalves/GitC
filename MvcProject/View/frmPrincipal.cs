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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void UsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
             FrmUsuarios FormUsu = new FrmUsuarios();
             FormUsu.ShowDialog();
        }

        private void AutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAutores FormAutores = new FrmAutores();
            FormAutores.ShowDialog();
        }

        private void GênerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGenero FormGeneros = new FrmGenero();
            FormGeneros.ShowDialog();
        }

        private void LivrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLivro FormLivros = new FrmLivro();
            FormLivros.ShowDialog();
        }
    }
}
