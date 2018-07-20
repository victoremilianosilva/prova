namespace Prova
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataNasc = new System.Windows.Forms.DateTimePicker();
            this.cursoFaculdade = new System.Windows.Forms.ComboBox();
            this.notaCS = new System.Windows.Forms.TextBox();
            this.notaJava = new System.Windows.Forms.TextBox();
            this.notaBD = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cursoBD = new System.Windows.Forms.ComboBox();
            this.cursoJava = new System.Windows.Forms.ComboBox();
            this.cursoCS = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data de Nascimento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(432, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nota obtida na disciplina java";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cursou a disciplina java";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(426, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nota obtida na disciplina CSharp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cursou disciplina CSharp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(432, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Cursando faculdade";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Cursou a Disciplina Banco de Dados";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(432, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(203, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Nota obtida na disciplina banco de dados";
            // 
            // dataNasc
            // 
            this.dataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataNasc.Location = new System.Drawing.Point(223, 35);
            this.dataNasc.Name = "dataNasc";
            this.dataNasc.Size = new System.Drawing.Size(184, 20);
            this.dataNasc.TabIndex = 11;
            // 
            // cursoFaculdade
            // 
            this.cursoFaculdade.FormattingEnabled = true;
            this.cursoFaculdade.Items.AddRange(new object[] {
            "sim",
            "nao"});
            this.cursoFaculdade.Location = new System.Drawing.Point(604, 35);
            this.cursoFaculdade.Name = "cursoFaculdade";
            this.cursoFaculdade.Size = new System.Drawing.Size(184, 21);
            this.cursoFaculdade.TabIndex = 12;
            // 
            // notaCS
            // 
            this.notaCS.Location = new System.Drawing.Point(604, 74);
            this.notaCS.Name = "notaCS";
            this.notaCS.Size = new System.Drawing.Size(184, 20);
            this.notaCS.TabIndex = 13;
            // 
            // notaJava
            // 
            this.notaJava.Location = new System.Drawing.Point(604, 114);
            this.notaJava.Name = "notaJava";
            this.notaJava.Size = new System.Drawing.Size(184, 20);
            this.notaJava.TabIndex = 14;
            // 
            // notaBD
            // 
            this.notaBD.Location = new System.Drawing.Point(641, 158);
            this.notaBD.Name = "notaBD";
            this.notaBD.Size = new System.Drawing.Size(147, 20);
            this.notaBD.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(321, 233);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(222, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Testar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cursoBD
            // 
            this.cursoBD.FormattingEnabled = true;
            this.cursoBD.Items.AddRange(new object[] {
            "sim\t",
            "nao"});
            this.cursoBD.Location = new System.Drawing.Point(223, 158);
            this.cursoBD.Name = "cursoBD";
            this.cursoBD.Size = new System.Drawing.Size(184, 21);
            this.cursoBD.TabIndex = 17;
            // 
            // cursoJava
            // 
            this.cursoJava.FormattingEnabled = true;
            this.cursoJava.Items.AddRange(new object[] {
            "sim ",
            "nao"});
            this.cursoJava.Location = new System.Drawing.Point(223, 114);
            this.cursoJava.Name = "cursoJava";
            this.cursoJava.Size = new System.Drawing.Size(184, 21);
            this.cursoJava.TabIndex = 18;
            // 
            // cursoCS
            // 
            this.cursoCS.FormattingEnabled = true;
            this.cursoCS.Items.AddRange(new object[] {
            "sim\t",
            "nao"});
            this.cursoCS.Location = new System.Drawing.Point(223, 74);
            this.cursoCS.Name = "cursoCS";
            this.cursoCS.Size = new System.Drawing.Size(184, 21);
            this.cursoCS.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cursoCS);
            this.Controls.Add(this.cursoJava);
            this.Controls.Add(this.cursoBD);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.notaBD);
            this.Controls.Add(this.notaJava);
            this.Controls.Add(this.notaCS);
            this.Controls.Add(this.cursoFaculdade);
            this.Controls.Add(this.dataNasc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dataNasc;
        private System.Windows.Forms.ComboBox cursoFaculdade;
        private System.Windows.Forms.TextBox notaCS;
        private System.Windows.Forms.TextBox notaJava;
        private System.Windows.Forms.TextBox notaBD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cursoBD;
        private System.Windows.Forms.ComboBox cursoJava;
        private System.Windows.Forms.ComboBox cursoCS;
    }
}

