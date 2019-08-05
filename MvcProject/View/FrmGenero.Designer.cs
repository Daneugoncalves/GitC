namespace MvcProject.View
{
    partial class FrmGenero
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.generoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaBibiotecaDBDataSet = new MvcProject.SistemaBibiotecaDBDataSet();
            this.generoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.generoTableAdapter = new MvcProject.SistemaBibiotecaDBDataSetTableAdapters.GeneroTableAdapter();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.generoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBibiotecaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // generoBindingSource1
            // 
            this.generoBindingSource1.DataMember = "Genero";
            this.generoBindingSource1.DataSource = this.sistemaBibiotecaDBDataSet;
            // 
            // sistemaBibiotecaDBDataSet
            // 
            this.sistemaBibiotecaDBDataSet.DataSetName = "SistemaBibiotecaDBDataSet";
            this.sistemaBibiotecaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // generoBindingSource
            // 
            this.generoBindingSource.DataMember = "Genero";
            this.generoBindingSource.DataSource = this.sistemaBibiotecaDBDataSet;
            // 
            // generoTableAdapter
            // 
            this.generoTableAdapter.ClearBeforeFill = true;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(12, 32);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(450, 112);
            this.btnAdicionar.TabIndex = 1;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.generoBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(13, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(449, 269);
            this.dataGridView1.TabIndex = 2;
            // 
            // generoBindingSource2
            // 
            this.generoBindingSource2.DataMember = "Genero";
            this.generoBindingSource2.DataSource = this.sistemaBibiotecaDBDataSet;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            // 
            // FrmGenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAdicionar);
            this.Name = "FrmGenero";
            this.Text = "FrmGenero";
            this.Load += new System.EventHandler(this.FrmGenero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBibiotecaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private SistemaBibiotecaDBDataSet sistemaBibiotecaDBDataSet;
        private System.Windows.Forms.BindingSource generoBindingSource;
        private SistemaBibiotecaDBDataSetTableAdapters.GeneroTableAdapter generoTableAdapter;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.BindingSource generoBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource generoBindingSource2;
    }
}