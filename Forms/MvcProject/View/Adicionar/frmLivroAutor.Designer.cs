namespace MvcProject.View.Adicionar
{
    partial class frmLivroAutor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.autoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaBibiotecaDBDataSet = new MvcProject.SistemaBibiotecaDBDataSet();
            this.autoresTableAdapter = new MvcProject.SistemaBibiotecaDBDataSetTableAdapters.AutoresTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.livroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.livroAutorBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaBibiotecaDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.livroAutorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.livroAutorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.livroAutorTableAdapter = new MvcProject.SistemaBibiotecaDBDataSetTableAdapters.LivroAutorTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.livroAutorBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.autoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBibiotecaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroAutorBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBibiotecaDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroAutorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroAutorBindingSource)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.livroAutorBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Título";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(125, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "....";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.autoresBindingSource;
            this.comboBox1.DisplayMember = "Nome";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(30, 86);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(349, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "Id";
            // 
            // autoresBindingSource
            // 
            this.autoresBindingSource.DataMember = "Autores";
            this.autoresBindingSource.DataSource = this.sistemaBibiotecaDBDataSet;
            // 
            // sistemaBibiotecaDBDataSet
            // 
            this.sistemaBibiotecaDBDataSet.DataSetName = "SistemaBibiotecaDBDataSet";
            this.sistemaBibiotecaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // autoresTableAdapter
            // 
            this.autoresTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.livroDataGridViewTextBoxColumn,
            this.autorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.livroAutorBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(30, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(349, 273);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // livroDataGridViewTextBoxColumn
            // 
            this.livroDataGridViewTextBoxColumn.DataPropertyName = "Livro";
            this.livroDataGridViewTextBoxColumn.HeaderText = "Livro";
            this.livroDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.livroDataGridViewTextBoxColumn.Name = "livroDataGridViewTextBoxColumn";
            this.livroDataGridViewTextBoxColumn.Width = 125;
            // 
            // autorDataGridViewTextBoxColumn
            // 
            this.autorDataGridViewTextBoxColumn.DataPropertyName = "Autor";
            this.autorDataGridViewTextBoxColumn.HeaderText = "Autor";
            this.autorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.autorDataGridViewTextBoxColumn.Name = "autorDataGridViewTextBoxColumn";
            this.autorDataGridViewTextBoxColumn.Width = 125;
            // 
            // livroAutorBindingSource3
            // 
            this.livroAutorBindingSource3.DataMember = "LivroAutor";
            this.livroAutorBindingSource3.DataSource = this.sistemaBibiotecaDBDataSetBindingSource;
            // 
            // sistemaBibiotecaDBDataSetBindingSource
            // 
            this.sistemaBibiotecaDBDataSetBindingSource.DataSource = this.sistemaBibiotecaDBDataSet;
            this.sistemaBibiotecaDBDataSetBindingSource.Position = 0;
            // 
            // livroAutorBindingSource1
            // 
            this.livroAutorBindingSource1.DataMember = "LivroAutor";
            this.livroAutorBindingSource1.DataSource = this.sistemaBibiotecaDBDataSetBindingSource;
            // 
            // livroAutorBindingSource
            // 
            this.livroAutorBindingSource.DataMember = "LivroAutor";
            this.livroAutorBindingSource.DataSource = this.sistemaBibiotecaDBDataSet;
            // 
            // livroAutorTableAdapter
            // 
            this.livroAutorTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(403, 27);
            this.fillByToolStrip.TabIndex = 4;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(48, 24);
            this.fillByToolStripButton.Text = "FillBy";
            // 
            // livroAutorBindingSource2
            // 
            this.livroAutorBindingSource2.DataMember = "LivroAutor";
            this.livroAutorBindingSource2.DataSource = this.sistemaBibiotecaDBDataSetBindingSource;
            // 
            // frmLivroAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 450);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmLivroAutor";
            this.Text = "LivroAutor";
            this.Load += new System.EventHandler(this.LivroAutor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.autoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBibiotecaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroAutorBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBibiotecaDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroAutorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroAutorBindingSource)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.livroAutorBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private SistemaBibiotecaDBDataSet sistemaBibiotecaDBDataSet;
        private System.Windows.Forms.BindingSource autoresBindingSource;
        private SistemaBibiotecaDBDataSetTableAdapters.AutoresTableAdapter autoresTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource livroAutorBindingSource;
        private SistemaBibiotecaDBDataSetTableAdapters.LivroAutorTableAdapter livroAutorTableAdapter;
        private System.Windows.Forms.BindingSource livroAutorBindingSource1;
        private System.Windows.Forms.BindingSource sistemaBibiotecaDBDataSetBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn livroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource livroAutorBindingSource3;
        private System.Windows.Forms.BindingSource livroAutorBindingSource2;
    }
}