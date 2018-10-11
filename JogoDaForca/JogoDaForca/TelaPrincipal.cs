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

        private void button1_Click(object sender, EventArgs e)
        {
            lbl_Palavra.Text = "";
           _palavra = PalavraController.GetPalavra(1);
           for (int i = 0; i < _palavra.PalavraAtual.Length; i++)
            {
                lbl_Palavra.Text += " _";
            }

            lbl_LetrasDigitadas.Text = "Letras Digitadas:\n";
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            colocarTraco = true;
            letrasDigitadas[contador] = txt_DigitaLetra.Text.ToUpper();
            lbl_LetrasDigitadas.Text += " " +  txt_DigitaLetra.Text.ToUpper();
            lbl_Palavra.Text = "";
            for (int i = 0; i < _palavra.PalavraAtual.Length; i++)
            {
                if(txt_DigitaLetra.Text.ToUpper() == _palavra.PalavraAtual.Substring(i,1))
                {
                    colocarTraco = false;
                    pontos++;
                    lbl_Palavra.Text += " " + _palavra.PalavraAtual.Substring(i, 1);
                }               
                for (int h = 0; h < letrasDigitadas.Length; h++)
                {
                    if (letrasDigitadas[h] == _palavra.PalavraAtual.Substring(i, 1) & colocarTraco)
                    {
                        colocarTraco = false;
                        lbl_Palavra.Text += " " + _palavra.PalavraAtual.Substring(i, 1);
                    }
                }  
                 if (colocarTraco)
                {
                    lbl_Palavra.Text += " _";
                }

            }
            contador++;
        }

        private void txt_DigitaLetra_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_DigitaLetra_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
