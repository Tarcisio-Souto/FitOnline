using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALSerie
    {
        private DALConexao conexao;

        public DALSerie(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloSerie modelo)
        {
            SqlCommand cmd = new SqlCommand();     // A função SqlCommand habilita os comandos SQL no sistema. 
            cmd.Connection = conexao.ObjetoConexao; // Passando qual a conexão que o sistema irá utilizar, neste caso, o da variável conexao.
            cmd.CommandText = "insert into tblSerie (idAvaliacao, idAluno, texto)" +      // Atribuindo valores à tabela cadastro com comandos SQL.
            " values (@idAvaliacao, @idAluno, @texto); select @@IDENTITY;";

            cmd.Parameters.AddWithValue("@idAvaliacao", modelo.id_Avaliacao);
            cmd.Parameters.AddWithValue("@idAluno", modelo.id_Aluno);            
            cmd.Parameters.AddWithValue("@texto", modelo.Texto);

            conexao.Conectar();
            modelo.id_Serie = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();

        }

        public void Alterar(ModeloSerie modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update tblSerie set idAluno = (@idAluno), " +
            " idAvaliacao = (@idAvaliacao), texto = (@texto) "
            + "where idSerie = (@idSerie);";


            cmd.Parameters.AddWithValue("@idSerie", modelo.id_Serie);
            cmd.Parameters.AddWithValue("@idAluno", modelo.id_Aluno);
            cmd.Parameters.AddWithValue("@idAvaliacao", modelo.id_Avaliacao);
            cmd.Parameters.AddWithValue("@texto", modelo.Texto);


            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();

        }

        public void Excluir(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from tblSerie where idSerie = @idSerie;";
            cmd.Parameters.AddWithValue("@idSerie", id);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();

        }


        public DataTable Localizar(int valor)  // Cada série será exibida junto à sua acaliação correspondente.
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select idSerie from tblSerie where idAvaliacao = " + valor + "", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }


        public ModeloSerie CarregaModeloSerie(int id)
        {
            ModeloSerie modelo = new ModeloSerie();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from tblSerie where idSerie = " + id + "";
            cmd.Parameters.AddWithValue("@idSerie", id);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.id_Serie = Convert.ToInt32(registro["idSerie"]);
                modelo.id_Aluno = Convert.ToInt32(registro["idAluno"]);
                modelo.id_Avaliacao = Convert.ToInt32(registro["idAvaliacao"]);
                modelo.Texto = Convert.ToString(registro["texto"]);
            }

            conexao.Desconectar();
            return modelo;
        }


    }
}
