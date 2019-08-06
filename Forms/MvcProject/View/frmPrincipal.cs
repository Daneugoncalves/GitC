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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            if (Session.user == null)
                throw new Exception("Erro critico do sistema!"); //Lança um erro e finaliza a sessao
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
            FrmLivros FormLivros = new FrmLivros();
            FormLivros.ShowDialog();
        }

        private void EditorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEditoras FormEditora = new FrmEditoras();
            FormEditora.ShowDialog();
        }

        private void LocaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLocacao FormLocacao = new FrmLocacao();
            FormLocacao.ShowDialog();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
