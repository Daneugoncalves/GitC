using Escola.Classe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<Aluno> Alunos = new List<Aluno>();
private void Button1_Click(object sender, EventArgs e)
        {
            FmrCadastroAluno formCad = new FmrCadastroAluno();
            formCad.ShowDialog();
            Alunos.Add(formCad.novoAluno);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Alunos;
            
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
