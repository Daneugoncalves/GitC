namespace MvcProject.View
{
    partial class FrmLivro
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
            this.livrosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaBibiotecaDBDataSet = new MvcProject.SistemaBibiotecaDBDataSet();
            this.livrosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.livrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.livrosTableAdapter = new MvcProject.SistemaBibiotecaDBDataSetTableAdapters.LivrosTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinopseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observaçõesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.usuIncDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuAltDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataIncDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataAltDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.livrosBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBibiotecaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // livrosBindingSource2
            // 
            this.livrosBindingSource2.DataMember = "Livros";
            this.livrosBindingSource2.DataSource = this.sistemaBibiotecaDBDataSet;
            // 
            // sistemaBibiotecaDBDataSet
            // 
            this.sistemaBibiotecaDBDataSet.DataSetName = "SistemaBibiotecaDBDataSet";
            this.sistemaBibiotecaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // livrosBindingSource1
            // 
            this.livrosBindingSource1.DataMember = "Livros";
            this.livrosBindingSource1.DataSource = this.sistemaBibiotecaDBDataSet;
            // 
            // livrosBindingSource
            // 
            this.livrosBindingSource.DataMember = "Livros";
            this.livrosBindingSource.DataSource = this.sistemaBibiotecaDBDataSet;
            // 
            // livrosTableAdapter
            // 
            this.livrosTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(960, 127);
            this.button1.TabIndex = 1;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.registroDataGridViewTextBoxColumn,
            this.tituloDataGridViewTextBoxColumn,
            this.isbnDataGridViewTextBoxColumn,
            this.generoDataGridViewTextBoxColumn,
            this.editoraDataGridViewTextBoxColumn,
            this.sinopseDataGridViewTextBoxColumn,
            this.observaçõesDataGridViewTextBoxColumn,
            this.ativoDataGridViewCheckBoxColumn,
            this.usuIncDataGridViewTextBoxColumn,
            this.usuAltDataGridViewTextBoxColumn,
            this.dataIncDataGridViewTextBoxColumn,
            this.dataAltDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.livrosBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(4, 149);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(960, 374);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // registroDataGridViewTextBoxColumn
            // 
            this.registroDataGridViewTextBoxColumn.DataPropertyName = "Registro";
            this.registroDataGridViewTextBoxColumn.HeaderText = "Registro";
            this.registroDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.registroDataGridViewTextBoxColumn.Name = "registroDataGridViewTextBoxColumn";
            this.registroDataGridViewTextBoxColumn.Width = 125;
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "Titulo";
            this.tituloDataGridViewTextBoxColumn.HeaderText = "Titulo";
            this.tituloDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            this.tituloDataGridViewTextBoxColumn.Width = 125;
            // 
            // isbnDataGridViewTextBoxColumn
            // 
            this.isbnDataGridViewTextBoxColumn.DataPropertyName = "Isbn";
            this.isbnDataGridViewTextBoxColumn.HeaderText = "Isbn";
            this.isbnDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.isbnDataGridViewTextBoxColumn.Name = "isbnDataGridViewTextBoxColumn";
            this.isbnDataGridViewTextBoxColumn.Width = 125;
            // 
            // generoDataGridViewTextBoxColumn
            // 
            this.generoDataGridViewTextBoxColumn.DataPropertyName = "Genero";
            this.generoDataGridViewTextBoxColumn.HeaderText = "Genero";
            this.generoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.generoDataGridViewTextBoxColumn.Name = "generoDataGridViewTextBoxColumn";
            this.generoDataGridViewTextBoxColumn.Width = 125;
            // 
            // editoraDataGridViewTextBoxColumn
            // 
            this.editoraDataGridViewTextBoxColumn.DataPropertyName = "Editora";
            this.editoraDataGridViewTextBoxColumn.HeaderText = "Editora";
            this.editoraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.editoraDataGridViewTextBoxColumn.Name = "editoraDataGridViewTextBoxColumn";
            this.editoraDataGridViewTextBoxColumn.Width = 125;
            // 
            // sinopseDataGridViewTextBoxColumn
            // 
            this.sinopseDataGridViewTextBoxColumn.DataPropertyName = "Sinopse";
            this.sinopseDataGridViewTextBoxColumn.HeaderText = "Sinopse";
            this.sinopseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sinopseDataGridViewTextBoxColumn.Name = "sinopseDataGridViewTextBoxColumn";
            this.sinopseDataGridViewTextBoxColumn.Width = 125;
            // 
            // observaçõesDataGridViewTextBoxColumn
            // 
            this.observaçõesDataGridViewTextBoxColumn.DataPropertyName = "Observações";
            this.observaçõesDataGridViewTextBoxColumn.HeaderText = "Observações";
            this.observaçõesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.observaçõesDataGridViewTextBoxColumn.Name = "observaçõesDataGridViewTextBoxColumn";
            this.observaçõesDataGridViewTextBoxColumn.Width = 125;
            // 
            // ativoDataGridViewCheckBoxColumn
            // 
            this.ativoDataGridViewCheckBoxColumn.DataPropertyName = "Ativo";
            this.ativoDataGridViewCheckBoxColumn.HeaderText = "Ativo";
            this.ativoDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.ativoDataGridViewCheckBoxColumn.Name = "ativoDataGridViewCheckBoxColumn";
            this.ativoDataGridViewCheckBoxColumn.Width = 125;
            // 
            // usuIncDataGridViewTextBoxColumn
            // 
            this.usuIncDataGridViewTextBoxColumn.DataPropertyName = "UsuInc";
            this.usuIncDataGridViewTextBoxColumn.HeaderText = "UsuInc";
            this.usuIncDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usuIncDataGridViewTextBoxColumn.Name = "usuIncDataGridViewTextBoxColumn";
            this.usuIncDataGridViewTextBoxColumn.Width = 125;
            // 
            // usuAltDataGridViewTextBoxColumn
            // 
            this.usuAltDataGridViewTextBoxColumn.DataPropertyName = "UsuAlt";
            this.usuAltDataGridViewTextBoxColumn.HeaderText = "UsuAlt";
            this.usuAltDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usuAltDataGridViewTextBoxColumn.Name = "usuAltDataGridViewTextBoxColumn";
            this.usuAltDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataIncDataGridViewTextBoxColumn
            // 
            this.dataIncDataGridViewTextBoxColumn.DataPropertyName = "DataInc";
            this.dataIncDataGridViewTextBoxColumn.HeaderText = "DataInc";
            this.dataIncDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataIncDataGridViewTextBoxColumn.Name = "dataIncDataGridViewTextBoxColumn";
            this.dataIncDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataAltDataGridViewTextBoxColumn
            // 
            this.dataAltDataGridViewTextBoxColumn.DataPropertyName = "DataAlt";
            this.dataAltDataGridViewTextBoxColumn.HeaderText = "DataAlt";
            this.dataAltDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataAltDataGridViewTextBoxColumn.Name = "dataAltDataGridViewTextBoxColumn";
            this.dataAltDataGridViewTextBoxColumn.Width = 125;
            // 
            // livrosBindingSource3
            // 
            this.livrosBindingSource3.DataMember = "Livros";
            this.livrosBindingSource3.DataSource = this.sistemaBibiotecaDBDataSet;
            // 
            // FrmLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 554);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmLivro";
            this.Text = "FrmLivro";
            this.Load += new System.EventHandler(this.FrmLivro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBibiotecaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private SistemaBibiotecaDBDataSet sistemaBibiotecaDBDataSet;
        private System.Windows.Forms.BindingSource livrosBindingSource;
        private SistemaBibiotecaDBDataSetTableAdapters.LivrosTableAdapter livrosTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource livrosBindingSource1;
        private System.Windows.Forms.BindingSource livrosBindingSource2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn generoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn editoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinopseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observaçõesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ativoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuIncDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuAltDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataIncDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataAltDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource livrosBindingSource3;
    }
}