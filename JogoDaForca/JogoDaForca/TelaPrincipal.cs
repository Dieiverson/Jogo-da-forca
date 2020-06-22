using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JogoDaForca.Model;
using JogoDaForca.Controller;
using System.IO;

namespace JogoDaForca
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }
        Palavra _palavra;
        int pontos, contador;
        string[] letrasDigitadas = new string[24];
        bool colocarTraco;
        bool letraExiste = false;
        int imagemIndex = 1;

        private void button1_Click(object sender, EventArgs e)
        {
            lbl_Palavra.Text = "";
           _palavra = PalavraController.GetPalavra(1);
           for (int i = 0; i < _palavra.PalavraAtual.Length; i++)
            {
                lbl_Palavra.Text += " _";
            }

            lbl_LetrasDigitadas.Text = "Letras Digitadas:\n";
            button2.Enabled = true;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            letraExiste = false;
            lbl_LetrasDigitadas.Text += "-" +  txt_DigitaLetra.Text.ToUpper();
            lbl_Palavra.Text = "";
            for (int i = 0; i < _palavra.PalavraAtual.Length; i++)
            {
                colocarTraco = true;
                if (txt_DigitaLetra.Text.ToUpper() == _palavra.PalavraAtual.Substring(i,1))
                {
                    colocarTraco = false;
                    pontos++;
                    letraExiste = true;
                    lbl_Palavra.Text += " " + _palavra.PalavraAtual.Substring(i, 1);
                } 
                else
                {
                    for (int h = 0; h < letrasDigitadas.Length; h++)
                    {
                        if (letrasDigitadas[h] == _palavra.PalavraAtual.Substring(i, 1))                       {
                            letraExiste = true;
                            colocarTraco = false;
                            lbl_Palavra.Text += " " + _palavra.PalavraAtual.Substring(i, 1);
                        }
                    }
                    if (colocarTraco)
                    {
                        lbl_Palavra.Text += " _";
                        letraExiste = false;
                    }
                }
            }
            if(!letraExiste)
            {
                imagemIndex++;
                if(imagemIndex > 7)
                {
                    perdeu();
                }
                string caminhoImg = Directory.GetCurrentDirectory() + @"\Assets\forca" + Convert.ToString(imagemIndex)+".png";
                Bitmap bitmap = new Bitmap(caminhoImg);
                pontos--;
                pictureForca.Image = bitmap;
            }

            letrasDigitadas[contador] = txt_DigitaLetra.Text.ToUpper();
            contador++;
            lbl_pontos.Text = "Pontos: " + pontos;
        }

        private void txt_DigitaLetra_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void perdeu()
        {
            button2.Enabled = false;
            MessageBox.Show("Você perdeu;");
        }

        private void lbl_LetrasDigitadas_Click(object sender, EventArgs e)
        {

        }

        private void btn_dica_Click(object sender, EventArgs e)
        {

        }

        private void txt_DigitaLetra_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
