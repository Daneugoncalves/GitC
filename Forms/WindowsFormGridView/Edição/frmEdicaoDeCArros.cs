﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormGridView.Edição
{
    public partial class frmEdicaoDeCArros : Form
    {
        public frmEdicaoDeCArros()
        {
            InitializeComponent();
        }

        public WindowsFormGridView.QuerysInnerJoinDataSet1.CarrosRow CarrosRow;

        private void FrmEdiçãoDeCArros_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet1.Marcas' table. You can move, or remove it, as needed.
            this.marcasTableAdapter.FillBy(this.querysInnerJoinDataSet1.Marcas);

            textBox1.Text = CarrosRow.Modelo;
            dateTimePicker1.Value = CarrosRow.Ano;
            comboBox1.SelectedValue = CarrosRow.Marca;
        }
    }
}
