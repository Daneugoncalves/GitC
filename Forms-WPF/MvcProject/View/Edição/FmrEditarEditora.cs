using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MvcProject.View.Edição
{
    public partial class FmrEditarEditora : Form
    {
        public FmrEditarEditora()
        {
            InitializeComponent();
        }
        public MvcProject.SistemaBibiotecaDBDataSet.EditoraRow EditoraRow;


        private void FmrEditarEditora_Load(object sender, EventArgs e)
        {
            textBox1.Text = EditoraRow.Nome;
            textBox2.Text = EditoraRow.Descrição;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            EditoraRow.Nome = textBox1.Text;
            EditoraRow.Descrição = textBox2.Text;
        }
    
    }
}
