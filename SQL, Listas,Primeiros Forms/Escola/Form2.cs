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
    public partial class FmrCadastroAluno : Form
    {

        public FmrCadastroAluno()
        {
            InitializeComponent();
        }

        public Aluno novoAluno = new Aluno();

        private void BtnSalvarCad_Click(object sender, EventArgs e)
        {
            novoAluno.Nome = tbxNome.Text;
            novoAluno.Matricula = int.Parse(tbxMatricula.Text);
            novoAluno.Turma = TbxTurma.Text;

            this.Close();
        }
    }
}
