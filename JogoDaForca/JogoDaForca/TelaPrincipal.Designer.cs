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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_Palavra = new System.Windows.Forms.Label();
            this.txt_DigitaLetra = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_LetrasDigitadas = new System.Windows.Forms.Label();
            this.pictureForca = new System.Windows.Forms.PictureBox();
            this.btn_dica = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_dicas = new System.Windows.Forms.Label();
            this.lbl_pontos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureForca)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(0, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Gerar Nova Palavra";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_Palavra
            // 
            this.lbl_Palavra.AutoSize = true;
            this.lbl_Palavra.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Palavra.Location = new System.Drawing.Point(306, 78);
            this.lbl_Palavra.Name = "lbl_Palavra";
            this.lbl_Palavra.Size = new System.Drawing.Size(166, 24);
            this.lbl_Palavra.TabIndex = 3;
            this.lbl_Palavra.Text = "_ _ _ _ _ _ _ _ _";
            // 
            // txt_DigitaLetra
            // 
            this.txt_DigitaLetra.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DigitaLetra.Location = new System.Drawing.Point(699, 291);
            this.txt_DigitaLetra.MaxLength = 1;
            this.txt_DigitaLetra.Name = "txt_DigitaLetra";
            this.txt_DigitaLetra.Size = new System.Drawing.Size(28, 29);
            this.txt_DigitaLetra.TabIndex = 2;
            this.txt_DigitaLetra.TextChanged += new System.EventHandler(this.txt_DigitaLetra_TextChanged);
            this.txt_DigitaLetra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_DigitaLetra_KeyPress);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(678, 326);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 24);
            this.button2.TabIndex = 3;
            this.button2.Text = "Tentar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_LetrasDigitadas
            // 
            this.lbl_LetrasDigitadas.AutoSize = true;
            this.lbl_LetrasDigitadas.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LetrasDigitadas.Location = new System.Drawing.Point(12, 366);
            this.lbl_LetrasDigitadas.Name = "lbl_LetrasDigitadas";
            this.lbl_LetrasDigitadas.Size = new System.Drawing.Size(0, 24);
            this.lbl_LetrasDigitadas.TabIndex = 4;
            this.lbl_LetrasDigitadas.Click += new System.EventHandler(this.lbl_LetrasDigitadas_Click);
            // 
            // pictureForca
            // 
            this.pictureForca.Image = ((System.Drawing.Image)(resources.GetObject("pictureForca.Image")));
            this.pictureForca.Location = new System.Drawing.Point(0, 0);
            this.pictureForca.Name = "pictureForca";
            this.pictureForca.Size = new System.Drawing.Size(300, 300);
            this.pictureForca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureForca.TabIndex = 5;
            this.pictureForca.TabStop = false;
            this.pictureForca.Tag = "";
            // 
            // btn_dica
            // 
            this.btn_dica.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dica.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_dica.Location = new System.Drawing.Point(648, 118);
            this.btn_dica.Name = "btn_dica";
            this.btn_dica.Size = new System.Drawing.Size(140, 44);
            this.btn_dica.TabIndex = 7;
            this.btn_dica.Text = "Pedir Dica";
            this.btn_dica.UseVisualStyleBackColor = true;
            this.btn_dica.Click += new System.EventHandler(this.btn_dica_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(306, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Dicas:";
            // 
            // lbl_dicas
            // 
            this.lbl_dicas.AutoSize = true;
            this.lbl_dicas.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dicas.Location = new System.Drawing.Point(321, 142);
            this.lbl_dicas.Name = "lbl_dicas";
            this.lbl_dicas.Size = new System.Drawing.Size(0, 24);
            this.lbl_dicas.TabIndex = 9;
            // 
            // lbl_pontos
            // 
            this.lbl_pontos.AutoSize = true;
            this.lbl_pontos.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pontos.Location = new System.Drawing.Point(306, 9);
            this.lbl_pontos.Name = "lbl_pontos";
            this.lbl_pontos.Size = new System.Drawing.Size(107, 24);
            this.lbl_pontos.TabIndex = 10;
            this.lbl_pontos.Text = "Pontos: 0";
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_pontos);
            this.Controls.Add(this.lbl_dicas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_dica);
            this.Controls.Add(this.pictureForca);
            this.Controls.Add(this.lbl_LetrasDigitadas);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_DigitaLetra);
            this.Controls.Add(this.lbl_Palavra);
            this.Controls.Add(this.button1);
            this.Name = "TelaPrincipal";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureForca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_Palavra;
        private System.Windows.Forms.TextBox txt_DigitaLetra;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl_LetrasDigitadas;
        private System.Windows.Forms.PictureBox pictureForca;
        private System.Windows.Forms.Button btn_dica;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_dicas;
        private System.Windows.Forms.Label lbl_pontos;
    }
}

