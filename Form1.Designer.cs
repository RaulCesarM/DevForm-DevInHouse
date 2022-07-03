namespace DevForm {
    partial class FormularioInscricao {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.Nome = new System.Windows.Forms.TextBox();
            this.Sobrenome = new System.Windows.Forms.TextBox();
            this.LblSobrenome = new System.Windows.Forms.Label();
            this.Idadetxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.VIEW = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.BuscarTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.IdadeRetorno = new System.Windows.Forms.TextBox();
            this.SobrenomeRetorno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NomeRetorno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(254, 350);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(136, 37);
            this.BtnSalvar.TabIndex = 0;
            this.BtnSalvar.Text = "SALVAR";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // Nome
            // 
            this.Nome.Location = new System.Drawing.Point(162, 36);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(334, 27);
            this.Nome.TabIndex = 2;
            // 
            // Sobrenome
            // 
            this.Sobrenome.Location = new System.Drawing.Point(162, 69);
            this.Sobrenome.Name = "Sobrenome";
            this.Sobrenome.Size = new System.Drawing.Size(334, 27);
            this.Sobrenome.TabIndex = 4;
            // 
            // LblSobrenome
            // 
            this.LblSobrenome.AutoSize = true;
            this.LblSobrenome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LblSobrenome.Cursor = System.Windows.Forms.Cursors.No;
            this.LblSobrenome.Location = new System.Drawing.Point(6, 76);
            this.LblSobrenome.Name = "LblSobrenome";
            this.LblSobrenome.Size = new System.Drawing.Size(86, 20);
            this.LblSobrenome.TabIndex = 3;
            this.LblSobrenome.Text = "Sobrenome";
            // 
            // Idadetxt
            // 
            this.Idadetxt.Location = new System.Drawing.Point(162, 104);
            this.Idadetxt.Name = "Idadetxt";
            this.Idadetxt.Size = new System.Drawing.Size(334, 27);
            this.Idadetxt.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(6, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Idade";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(573, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(265, 39);
            this.button1.TabIndex = 7;
            this.button1.Text = "Lista de Cadastrados";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1058, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(275, 39);
            this.button2.TabIndex = 8;
            this.button2.Text = "Limpar Lista Usuario";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // VIEW
            // 
            this.VIEW.Location = new System.Drawing.Point(573, 80);
            this.VIEW.Name = "VIEW";
            this.VIEW.Size = new System.Drawing.Size(760, 607);
            this.VIEW.TabIndex = 12;
            this.VIEW.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.Idadetxt);
            this.groupBox1.Controls.Add(this.Sobrenome);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.LblSobrenome);
            this.groupBox1.Controls.Add(this.Nome);
            this.groupBox1.Controls.Add(this.BtnSalvar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(541, 425);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inserir Aluno";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(427, 178);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(69, 29);
            this.btnBuscar.TabIndex = 19;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 181);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "Cursos Disponiveis";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(162, 178);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(259, 28);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.Text = "SELECIONE O CURSO";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(162, 317);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(334, 27);
            this.textBox3.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 320);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Total a Pagar R$";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(162, 268);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(334, 27);
            this.textBox2.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 271);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Desconto R$";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Nome";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(162, 228);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(334, 27);
            this.textBox1.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Valor do Curso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Data Nascimento";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(162, 137);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(334, 27);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.BuscarTxt);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.IdadeRetorno);
            this.groupBox2.Controls.Add(this.SobrenomeRetorno);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.NomeRetorno);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Location = new System.Drawing.Point(12, 443);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(541, 238);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Editar Aluno";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(411, 16);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(85, 30);
            this.button5.TabIndex = 10;
            this.button5.Text = "BUSCAR";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(360, 174);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 37);
            this.button3.TabIndex = 9;
            this.button3.Text = "DELETAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // BuscarTxt
            // 
            this.BuscarTxt.Location = new System.Drawing.Point(162, 19);
            this.BuscarTxt.Name = "BuscarTxt";
            this.BuscarTxt.Size = new System.Drawing.Size(228, 27);
            this.BuscarTxt.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(10, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Aluno";
            // 
            // IdadeRetorno
            // 
            this.IdadeRetorno.Location = new System.Drawing.Point(162, 130);
            this.IdadeRetorno.Name = "IdadeRetorno";
            this.IdadeRetorno.Size = new System.Drawing.Size(334, 27);
            this.IdadeRetorno.TabIndex = 6;
            // 
            // SobrenomeRetorno
            // 
            this.SobrenomeRetorno.Location = new System.Drawing.Point(162, 94);
            this.SobrenomeRetorno.Name = "SobrenomeRetorno";
            this.SobrenomeRetorno.Size = new System.Drawing.Size(334, 27);
            this.SobrenomeRetorno.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(6, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Idade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Cursor = System.Windows.Forms.Cursors.No;
            this.label3.Location = new System.Drawing.Point(10, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sobrenome";
            // 
            // NomeRetorno
            // 
            this.NomeRetorno.Location = new System.Drawing.Point(162, 52);
            this.NomeRetorno.Name = "NomeRetorno";
            this.NomeRetorno.Size = new System.Drawing.Size(334, 27);
            this.NomeRetorno.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(10, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nome";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(162, 174);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(185, 37);
            this.button4.TabIndex = 0;
            this.button4.Text = "EDITAR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Editar_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(214, 699);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(270, 29);
            this.button6.TabIndex = 18;
            this.button6.Text = "Cursos";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // FormularioInscricao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1345, 793);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.VIEW);
            this.Controls.Add(this.button2);
            this.Name = "FormularioInscricao";
            this.Text = "DEV IN HOUSE  AGENDA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        private void VIEW_SelectedIndexChanged(object sender, EventArgs e) {
            throw new NotImplementedException();
        }

        #endregion

        private Button BtnSalvar;
        private TextBox Nome;
        private TextBox Sobrenome;
        private Label LblSobrenome;
        private TextBox Idadetxt;
        private Label label2;
        private Button button1;
        private Button button2;
        private ListView VIEW;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button3;
        private TextBox BuscarTxt;
        private Label label5;
        private TextBox IdadeRetorno;
        private TextBox SobrenomeRetorno;
        private Label label1;
        private Label label3;
        private TextBox NomeRetorno;
        private Label label4;
        private Button button4;
        private Button button5;
        private Button button6;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private Label label7;
        private Label label6;
        private ComboBox comboBox1;
        private TextBox textBox3;
        private Label label10;
        private TextBox textBox2;
        private Label label9;
        private Label label8;
        private Label label11;
        private Button btnBuscar;
    }
}