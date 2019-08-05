namespace MvcProject.View.Adicionar
{
    partial class FrmAdicionarLivro
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.generoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaBibiotecaDBDataSet = new MvcProject.SistemaBibiotecaDBDataSet();
            this.editoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.generoTableAdapter = new MvcProject.SistemaBibiotecaDBDataSetTableAdapters.GeneroTableAdapter();
            this.editoraTableAdapter = new MvcProject.SistemaBibiotecaDBDataSetTableAdapters.EditoraTableAdapter();
            this.generoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.editoraBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.editoraBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.generoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.generoBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBibiotecaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editoraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editoraBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editoraBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Título";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Isbn";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Genero";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Editora";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(277, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Sinopse";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(277, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Observaçoes";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(129, 43);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(128, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(128, 134);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 20);
            this.textBox2.TabIndex = 3;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(355, 159);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 96);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(355, 42);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(100, 96);
            this.richTextBox2.TabIndex = 6;
            this.richTextBox2.Text = "";
            // 
            // generoBindingSource
            // 
            this.generoBindingSource.DataMember = "Genero";
            this.generoBindingSource.DataSource = this.sistemaBibiotecaDBDataSet;
            // 
            // sistemaBibiotecaDBDataSet
            // 
            this.sistemaBibiotecaDBDataSet.DataSetName = "SistemaBibiotecaDBDataSet";
            this.sistemaBibiotecaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // editoraBindingSource
            // 
            this.editoraBindingSource.DataMember = "Editora";
            this.editoraBindingSource.DataSource = this.sistemaBibiotecaDBDataSet;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(410, 72);
            this.button1.TabIndex = 9;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // generoTableAdapter
            // 
            this.generoTableAdapter.ClearBeforeFill = true;
            // 
            // editoraTableAdapter
            // 
            this.editoraTableAdapter.ClearBeforeFill = true;
            // 
            // generoBindingSource1
            // 
            this.generoBindingSource1.DataMember = "Genero";
            this.generoBindingSource1.DataSource = this.sistemaBibiotecaDBDataSet;
            // 
            // editoraBindingSource1
            // 
            this.editoraBindingSource1.DataMember = "Editora";
            this.editoraBindingSource1.DataSource = this.sistemaBibiotecaDBDataSet;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.generoBindingSource3;
            this.comboBox1.DisplayMember = "Tipo";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(128, 179);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.ValueMember = "Id";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.editoraBindingSource2;
            this.comboBox2.DisplayMember = "Nome";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(128, 237);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 11;
            this.comboBox2.ValueMember = "Id";
            // 
            // editoraBindingSource2
            // 
            this.editoraBindingSource2.DataMember = "Editora";
            this.editoraBindingSource2.DataSource = this.sistemaBibiotecaDBDataSet;
            // 
            // generoBindingSource2
            // 
            this.generoBindingSource2.DataMember = "Genero";
            this.generoBindingSource2.DataSource = this.sistemaBibiotecaDBDataSet;
            // 
            // generoBindingSource3
            // 
            this.generoBindingSource3.DataMember = "Genero";
            this.generoBindingSource3.DataSource = this.sistemaBibiotecaDBDataSet;
            // 
            // FrmAdicionarLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 450);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmAdicionarLivro";
            this.Text = "Editar Livro";
            this.Load += new System.EventHandler(this.FrmAdicionarLivro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBibiotecaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editoraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editoraBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editoraBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button button1;
        private SistemaBibiotecaDBDataSet sistemaBibiotecaDBDataSet;
        private System.Windows.Forms.BindingSource generoBindingSource;
        private SistemaBibiotecaDBDataSetTableAdapters.GeneroTableAdapter generoTableAdapter;
        private System.Windows.Forms.BindingSource editoraBindingSource;
        private SistemaBibiotecaDBDataSetTableAdapters.EditoraTableAdapter editoraTableAdapter;
        private System.Windows.Forms.BindingSource generoBindingSource1;
        private System.Windows.Forms.BindingSource editoraBindingSource1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource generoBindingSource2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource editoraBindingSource2;
        private System.Windows.Forms.BindingSource generoBindingSource3;
    }
}