using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JogoDaForca.Model;

namespace JogoDaForca.Controller
{
  public class PalavraController
    {
        public static Palavra GetPalavra(int _id)
        {
            PalavaDao palavaDao = new PalavaDao();
            return  palavaDao.GetPalavra(_id);
        }
    }
}
