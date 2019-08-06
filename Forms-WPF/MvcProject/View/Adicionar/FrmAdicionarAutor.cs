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
    public partial class FrmAdicionarAutor : Form
    {
        public FrmAdicionarAutor()
        {
            InitializeComponent();
        }

        public Autor AutorRows;

        private void FrmAdicionarAutor_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            AutorRows = new Autor

            {
                Nome = textBox1.Text,
                Descricao = textBox2.Text
            };

            this.Close();

        }
    }
}
