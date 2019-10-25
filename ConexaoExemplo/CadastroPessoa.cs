using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexaoExemplo
{
    public class CadastroPessoa
    {
        SqlCommand cmd = new SqlCommand();
        Conexao conexao = new Conexao();
        public String mensagem = "";

        public CadastroPessoa(String nome, String telefone)
        {
            // Comando Sql -- SqllCommand
            cmd.CommandText = "INSERT INTO pessoa (nome, telefone) VALUES (@nome, @telefone)";

            // Parametros 
            cmd.Parameters.AddWithValue("@nome",nome);
            cmd.Parameters.AddWithValue("@telefone", telefone);

            //Conectar com o banco -- Conexao
            try
            {
                cmd.Connection = conexao.conectar();

                //Executar comando
                cmd.ExecuteNonQuery();

                //Desconectar
                conexao.desconectar();

                //Mostrar mensagem de sucesso
                this.mensagem = "Cadastrado com sucesso!";
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro ao tentar se conectar com o banco de Dados";                
            }
        }        
    }
}
