﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewExample.Edicao
{
    public partial class fmrEditarUsuario : Form
    {
        public fmrEditarUsuario()
        {
            InitializeComponent();
        }

        public DataGridViewExample.QuerysInnerJoinDataSet.UsuariosRow UsuariosRow;

        private void FmrEditarUsuario_Load(object sender, EventArgs e)
        {
          
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            

            UsuariosRow.Usuario = textBox1.Text;

            this.Close();
        }
    }
}
