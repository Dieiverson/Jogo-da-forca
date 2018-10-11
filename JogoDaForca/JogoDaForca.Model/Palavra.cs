using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace JogoDaForca.Model
{
  public class Palavra
    {
        int id;
        string palavraAtual, dica, dificuldade;
        public Palavra()
        {
                
        }
        public Palavra(int id, string palavraAtual, string dica, string dificuldade)
        {
            this.id = id;
            this.palavraAtual = palavraAtual;
            this.dica = dica;
            this.dificuldade = dificuldade;
        }

        public int Id { get => id; set => id = value; }
        public string PalavraAtual { get => palavraAtual; set => palavraAtual = value; }
        public string Dica { get => dica; set => dica = value; }
        public string Dificuldade { get => dificuldade; set => dificuldade = value; }
    }
}
