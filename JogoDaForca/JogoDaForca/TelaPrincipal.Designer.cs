namespace JogoDaForca
{
    partial class TelaPrincipal
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
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_Palavra = new System.Windows.Forms.Label();
            this.txt_DigitaLetra = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_LetrasDigitadas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_Palavra
            // 
            this.lbl_Palavra.AutoSize = true;
            this.lbl_Palavra.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Palavra.Location = new System.Drawing.Point(112, 63);
            this.lbl_Palavra.Name = "lbl_Palavra";
            this.lbl_Palavra.Size = new System.Drawing.Size(69, 24);
            this.lbl_Palavra.TabIndex = 1;
            this.lbl_Palavra.Text = "label1";
            // 
            // txt_DigitaLetra
            // 
            this.txt_DigitaLetra.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DigitaLetra.Location = new System.Drawing.Point(106, 236);
            this.txt_DigitaLetra.MaxLength = 1;
            this.txt_DigitaLetra.Name = "txt_DigitaLetra";
            this.txt_DigitaLetra.Size = new System.Drawing.Size(28, 29);
            this.txt_DigitaLetra.TabIndex = 2;
            this.txt_DigitaLetra.TextChanged += new System.EventHandler(this.txt_DigitaLetra_TextChanged);
            this.txt_DigitaLetra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_DigitaLetra_KeyPress);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(89, 274);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_LetrasDigitadas
            // 
            this.lbl_LetrasDigitadas.AutoSize = true;
            this.lbl_LetrasDigitadas.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LetrasDigitadas.Location = new System.Drawing.Point(95, 323);
            this.lbl_LetrasDigitadas.Name = "lbl_LetrasDigitadas";
            this.lbl_LetrasDigitadas.Size = new System.Drawing.Size(69, 24);
            this.lbl_LetrasDigitadas.TabIndex = 4;
            this.lbl_LetrasDigitadas.Text = "label1";
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_LetrasDigitadas);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_DigitaLetra);
            this.Controls.Add(this.lbl_Palavra);
            this.Controls.Add(this.button1);
            this.Name = "TelaPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_Palavra;
        private System.Windows.Forms.TextBox txt_DigitaLetra;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl_LetrasDigitadas;
    }
}

