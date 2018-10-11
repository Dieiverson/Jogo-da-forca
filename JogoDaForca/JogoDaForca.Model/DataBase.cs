using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace JogoDaForca.Model
{
    class DataBase
    {
        public SQLiteConnection conn { get; set; }
        public string stringConnection { get; set; }
        private List<SQLiteParameter> listaParameter = new List<SQLiteParameter>();


        public DataBase()
        {
            this.stringConnection = @"Data Source=C:\Users\Dieiverson\Documents\GitHub\Jogo-da-forca\JogoDaForca\JogoForca.db;Version=3;"; 
            conn = new SQLiteConnection(stringConnection);

        }
        public void AddParameter(string nome, object valor, DbType tipo, int size)
        {
            SQLiteParameter parametro = new SQLiteParameter(nome, valor);
            parametro.DbType = tipo;
            parametro.Size = size;
            listaParameter.Add(parametro);
        }
        public void AddParameter(string nome, object valor, DbType tipo)
        {
            SQLiteParameter parametro = new SQLiteParameter(nome, valor);
            parametro.DbType = tipo;
            listaParameter.Add(parametro);
        }

        public void OpenConnection()
        {
            if (this.conn.State == ConnectionState.Closed)
            {
                this.conn.Open();
            }
        }

        public void CloseConection()
        {
            this.conn.Close();
        }

        //select selet all
        public SQLiteDataReader ExecuteReader(string _sql)
        {
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.CommandText = _sql;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            if (listaParameter != null)
            {
                foreach (SQLiteParameter parameter in listaParameter)
                {
                    cmd.Parameters.Add(parameter);
                }
            }
            SQLiteDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;
        }

        //delete, insert , cont
        public int ExecuteNoQuery(string _sql)
        {
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.CommandText = _sql;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            if (listaParameter != null)
            {
                foreach (SQLiteParameter parameter in listaParameter)
                {
                    cmd.Parameters.Add(parameter);
                }
            }
            int resultado = cmd.ExecuteNonQuery();
            return resultado;

        }

        public object ExecuteEscalar(string _sql)
        {
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.CommandText = _sql;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            if (listaParameter != null)
            {
                foreach (SQLiteParameter parameter in listaParameter)
                {
                    cmd.Parameters.Add(parameter);
                }
            }
            object resultado = cmd.ExecuteScalar();
            return resultado;

        }





    }
}

