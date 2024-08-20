using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALConexao
    {
        private String stringConexao;  // Armazena a string de conexão do banco de dados contida em DadosDaConexao.
        private SqlConnection conexao; // Será utilizada para fazer a conexão efetiva com o banco de dados.

        public DALConexao(String dadosConexao)      // Construtor para instanciar as variáveis de conexao e a string de conexao.
        {
            this.conexao = new SqlConnection();
            this.StringConexao = dadosConexao;      // Define a string de conexao, neste caso, dadosConexao passa para String Conexao.
            this.conexao.ConnectionString = dadosConexao;
        }

        public String StringConexao      // Fazendo o get e set da variável stringConexao que está em private.
        {
            get { return this.stringConexao; }
            set { this.stringConexao = value; }
        }

        public SqlConnection ObjetoConexao      // Fazendo o get e set da variável conexao que está em private.
        {
            get { return this.conexao; }
            set { this.conexao = value;  }
        }

        public void Conectar()      // Método utilizado para abrir a conexao entre o sistema e o banco de dados.
        {
            this.conexao.Open();
        }

        public void Desconectar()   // Método utilizado para fechar a conexao entre o sistema e o banco de dados.
        {
            this.conexao.Close();
        }
    }
}
