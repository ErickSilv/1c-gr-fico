namespace Calcular_Media
{
    partial class Calcula2Notas
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
            this.Titulo = new System.Windows.Forms.Label();
            this.nota1 = new System.Windows.Forms.Label();
            this.nota2 = new System.Windows.Forms.Label();
            this.ctxNota1 = new System.Windows.Forms.TextBox();
            this.ctxNota2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Sair = new System.Windows.Forms.Button();
            this.resultado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.situacao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Edwardian Script ITC", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(63, 9);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(519, 41);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "Calcular a média do aluno e informar a situação";
            this.Titulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nota1
            // 
            this.nota1.AutoSize = true;
            this.nota1.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nota1.Location = new System.Drawing.Point(72, 69);
            this.nota1.Name = "nota1";
            this.nota1.Size = new System.Drawing.Size(112, 16);
            this.nota1.TabIndex = 1;
            this.nota1.Text = "Insira a Nota 1 :";
            // 
            // nota2
            // 
            this.nota2.AutoSize = true;
            this.nota2.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nota2.Location = new System.Drawing.Point(386, 69);
            this.nota2.Name = "nota2";
            this.nota2.Size = new System.Drawing.Size(112, 16);
            this.nota2.TabIndex = 2;
            this.nota2.Text = "Insira a Nota 2 :";
            this.nota2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ctxNota1
            // 
            this.ctxNota1.BackColor = System.Drawing.Color.Lime;
            this.ctxNota1.Enabled = false;
            this.ctxNota1.Location = new System.Drawing.Point(189, 66);
            this.ctxNota1.Name = "ctxNota1";
            this.ctxNota1.Size = new System.Drawing.Size(100, 22);
            this.ctxNota1.TabIndex = 3;
            this.ctxNota1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ctxNota1.TextChanged += new System.EventHandler(this.ctxNota1_TextChanged);
            // 
            // ctxNota2
            // 
            this.ctxNota2.BackColor = System.Drawing.Color.Lime;
            this.ctxNota2.Enabled = false;
            this.ctxNota2.Location = new System.Drawing.Point(502, 66);
            this.ctxNota2.Name = "ctxNota2";
            this.ctxNota2.Size = new System.Drawing.Size(100, 22);
            this.ctxNota2.TabIndex = 4;
            this.ctxNota2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(101, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Calcular Média";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button2.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(292, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Sair
            // 
            this.Sair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Sair.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sair.Location = new System.Drawing.Point(444, 145);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(75, 23);
            this.Sair.TabIndex = 7;
            this.Sair.Text = "Sair";
            this.Sair.UseVisualStyleBackColor = false;
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // resultado
            // 
            this.resultado.BackColor = System.Drawing.Color.Lime;
            this.resultado.Location = new System.Drawing.Point(247, 206);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(100, 22);
            this.resultado.TabIndex = 9;
            this.resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.resultado.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(98, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Resultado Média:";
            // 
            // situacao
            // 
            this.situacao.BackColor = System.Drawing.Color.Lime;
            this.situacao.Location = new System.Drawing.Point(247, 251);
            this.situacao.Name = "situacao";
            this.situacao.Size = new System.Drawing.Size(100, 22);
            this.situacao.TabIndex = 11;
            this.situacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.situacao.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(98, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Situação do Aluno:";
            // 
            // Calcula2Notas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.situacao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Sair);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ctxNota2);
            this.Controls.Add(this.ctxNota1);
            this.Controls.Add(this.nota2);
            this.Controls.Add(this.nota1);
            this.Controls.Add(this.Titulo);
            this.Name = "Calcula2Notas";
            this.Text = "Calcula 2 notas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label nota1;
        private System.Windows.Forms.Label nota2;
        private System.Windows.Forms.TextBox ctxNota1;
        private System.Windows.Forms.TextBox ctxNota2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Sair;
        private System.Windows.Forms.TextBox resultado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox situacao;
        private System.Windows.Forms.Label label4;
    }
}

