namespace Escola
{
    partial class FmrCadastroAluno
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
            this.btnSalvarCad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.tbxMatricula = new System.Windows.Forms.TextBox();
            this.TbxTurma = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSalvarCad
            // 
            this.btnSalvarCad.Location = new System.Drawing.Point(23, 145);
            this.btnSalvarCad.Name = "btnSalvarCad";
            this.btnSalvarCad.Size = new System.Drawing.Size(177, 50);
            this.btnSalvarCad.TabIndex = 0;
            this.btnSalvarCad.Text = "Salvar";
            this.btnSalvarCad.UseVisualStyleBackColor = true;
            this.btnSalvarCad.Click += new System.EventHandler(this.BtnSalvarCad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Matricula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Turma";
            // 
            // tbxNome
            // 
            this.tbxNome.Location = new System.Drawing.Point(100, 21);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(100, 22);
            this.tbxNome.TabIndex = 2;
            // 
            // tbxMatricula
            // 
            this.tbxMatricula.Location = new System.Drawing.Point(100, 63);
            this.tbxMatricula.Name = "tbxMatricula";
            this.tbxMatricula.Size = new System.Drawing.Size(100, 22);
            this.tbxMatricula.TabIndex = 2;
            // 
            // TbxTurma
            // 
            this.TbxTurma.Location = new System.Drawing.Point(100, 106);
            this.TbxTurma.Name = "TbxTurma";
            this.TbxTurma.Size = new System.Drawing.Size(100, 22);
            this.TbxTurma.TabIndex = 2;
            // 
            // FmrCadastroAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 215);
            this.Controls.Add(this.TbxTurma);
            this.Controls.Add(this.tbxMatricula);
            this.Controls.Add(this.tbxNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalvarCad);
            this.Name = "FmrCadastroAluno";
            this.Text = "Tela de Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvarCad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.TextBox tbxMatricula;
        private System.Windows.Forms.TextBox TbxTurma;
    }
}