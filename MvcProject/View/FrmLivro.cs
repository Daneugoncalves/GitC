using MvcProject.View.Adicionar;
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
    public partial class FrmLivro : Form
    {
        public FrmLivro()
        {
            InitializeComponent();
        }

        private void FrmLivro_Load(object sender, EventArgs e)
        {
          

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FrmAdicionarLivro formAddLivro = new FrmAdicionarLivro();
            formAddLivro.ShowDialog();

            if (!string.IsNullOrEmpty(formAddLivro.LivroRows?.Titulo))

            {
               this.livrosTableAdapter.Insert(
               formAddLivro.LivroRows.Registro,
               formAddLivro.LivroRows.Titulo,
               formAddLivro.LivroRows.Isbn,
               formAddLivro.LivroRows.Genero,
               formAddLivro.LivroRows.Editora,
               formAddLivro.LivroRows.Sinopse,
               formAddLivro.LivroRows.Observacoes,
               true,
               1,
               1,
               DateTime.Now,
               DateTime.Now
                );
            }

        }
    }
}
