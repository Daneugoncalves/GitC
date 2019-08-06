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

        private void Button1_Click(object sender, EventArgs e)
        {
            frmPrincipal formAddM = new frmPrincipal();
            formAddM.ShowDialog();
        }
    }
}
