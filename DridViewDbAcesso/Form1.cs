using DridViewDbAcesso.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DridViewDbAcesso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Contrac> lisContract = new List<Contrac>();



        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            lisContract.Add(new Contrac()
            {
                id = lisContract.Count(),
                value = new Random().Next(100),
                DatInc = DateTime.Now

            }) ;

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lisContract;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
