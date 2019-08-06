﻿using DataGridViewExample.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewExample.Adicionar
{
    public partial class fmrAdicionarMarca : Form
    {
        public fmrAdicionarMarca()
        {
            InitializeComponent();
        }

        public Marca marcasRow;

        private void FmrAdicionarMarca_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Trim().Length < 1)
            {
                MessageBox.Show("Informe a marca");
                return;
            }
            marcasRow = new Marca

            {
                Nome = textBox1.Text
            };

            this.Close();
        }
    }
}
