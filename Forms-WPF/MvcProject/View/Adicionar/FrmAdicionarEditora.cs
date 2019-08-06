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

namespace MvcProject.View.Adicionar
{
    public partial class FrmAdicionarEditora : Form
    {
        public FrmAdicionarEditora()
        {
            InitializeComponent();
        }

        public Editora EditoraRows;
        private void FrmAdicionarEditora_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            EditoraRows = new Editora

            {
                Nome = textBox1.Text,
                Descricao = textBox2.Text
            };

            this.Close();
        }
    }
}
