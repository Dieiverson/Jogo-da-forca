using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace JogoDaForca.Model
{
   public class PalavaDao
    {
        private DataBase db;
        public PalavaDao()
        {
            db = new DataBase();
        }
        public Palavra GetPalavra(int _Id)
        {
         
            Palavra _palavra = new Palavra();
            SQLiteDataReader dr = null;
            try
            {
                string sql = "Select * From Palavras Where IdPalavra = @id";
                db.OpenConnection();
                db.AddParameter("id",_Id,DbType.Int32);
                dr = db.ExecuteReader(sql);
                if (dr.Read())
                {
                    _palavra.Id = Convert.ToInt32(dr["IdPalavra"]);
                    _palavra.PalavraAtual = Convert.ToString(dr["Palavra"]).ToUpper();
                    _palavra.Dificuldade = Convert.ToString(dr["Dificuldade"]);
                    _palavra.Dica = Convert.ToString(dr["Dica"]);

                }
                return _palavra;
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
                throw new Exception("Erro ao localizar registro");
            }
            finally
            {
                if (dr != null)
                {
                    dr.Close();

                }

                this.db.CloseConection();
            }

        }


    }
}
