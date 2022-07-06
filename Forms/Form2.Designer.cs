namespace DevForm {
    partial class Form2 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.SALVAR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.TextBox();
            this.Valor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Desconto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.VIEW = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // SALVAR
            // 
            this.SALVAR.Location = new System.Drawing.Point(165, 163);
            this.SALVAR.Name = "SALVAR";
            this.SALVAR.Size = new System.Drawing.Size(211, 41);
            this.SALVAR.TabIndex = 0;
            this.SALVAR.Text = "Cadastrar  Curso";
            this.SALVAR.UseVisualStyleBackColor = true;
            this.SALVAR.Click += new System.EventHandler(this.SALVAR_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome do Curso";
            // 
            // Nome
            // 
            this.Nome.Location = new System.Drawing.Point(148, 25);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(255, 27);
            this.Nome.TabIndex = 2;
            // 
            // Valor
            // 
            this.Valor.Location = new System.Drawing.Point(148, 68);
            this.Valor.Name = "Valor";
            this.Valor.Size = new System.Drawing.Size(255, 27);
            this.Valor.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Preço";
            // 
            // Desconto
            // 
            this.Desconto.Location = new System.Drawing.Point(148, 112);
            this.Desconto.Name = "Desconto";
            this.Desconto.Size = new System.Drawing.Size(255, 27);
            this.Desconto.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descontos";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(165, 221);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(211, 44);
            this.button2.TabIndex = 7;
            this.button2.Text = "Lista de cursos disponiveis";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(148, 773);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(255, 40);
            this.button3.TabIndex = 8;
            this.button3.Text = "Tela Cadastro";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // VIEW
            // 
            this.VIEW.Location = new System.Drawing.Point(25, 281);
            this.VIEW.Name = "VIEW";
            this.VIEW.Size = new System.Drawing.Size(487, 463);
            this.VIEW.TabIndex = 9;
            this.VIEW.UseCompatibleStateImageBehavior = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(542, 837);
            this.Controls.Add(this.VIEW);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Desconto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Valor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SALVAR);
            this.Name = "Form2";
            this.Text = "DEV IN HOUSE  CURSOS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button SALVAR;
        private Label label1;
        private TextBox Nome;
        private TextBox Valor;
        private Label label2;
        private TextBox Desconto;
        private Label label3;
        private Button button2;
        private Button button3;
        private ListView VIEW;
    }
}