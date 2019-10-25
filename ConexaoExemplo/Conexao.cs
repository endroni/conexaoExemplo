using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexaoExemplo
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection();

        //Construtor
        public Conexao()
        {
            con.ConnectionString = @"Data Source=DESKTOP-D4GI2KI\SQLEXPRESS;Initial Catalog=conecta;Integrated Security=True";
        }

        //Metodo Conector
        public SqlConnection conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }

            return con;
        }

        //Metodo Desconectar
        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }

        }
    }
}
