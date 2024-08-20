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

    /*
     * Esta classe é responsável por criar os métodos de inclusão, alteração, exclusão e pesquisa de dados
     * diretamente do banco de dados.
    */

    public class DALCadastro
    {
        private DALConexao conexao;

        public DALCadastro(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloCadastro modelo){
            SqlCommand cmd = new SqlCommand();     // A função SqlCommand habilita os comandos SQL no sistema. 
            cmd.Connection = conexao.ObjetoConexao; // Passando qual a conexão que o sistema irá utilizar, neste caso, o da variável conexao.
            cmd.CommandText = "insert into tblCadastro (idAluno, idade," +      // Atribuindo valores à tabela cadastro com comandos SQL.
            " sexo, nome, dataNascimento, tipoSangue, celular, telefone, email, endereco, bairro," +
            " complemento, cidade, uf, cep, dadosClinicos1, dadosClinicos2," +
            " dadosClinicos3, dadosClinicos4, dadosClinicos5, dadosClinicos6," +
            " dadosClinicos7, dadosClinicos8, dadosClinicos9, dadosClinicos10," +
            " dadosClinicos11, dadosClinicos12, dadosClinicos12Resp, obj1, obj2," +
            " obj3, obj4, obj5, obj6, obj7, obj8, observacoes)" +
            " values (@idAluno, @idade, @sexo, @nome, @dataNascimento, @tipoSangue, @celular, @telefone, @email, " +
            " @endereco, @bairro, @complemento, @cidade, @uf, @cep, @dadosClinicos1, @dadosClinicos2," +
            " @dadosClinicos3, @dadosClinicos4, @dadosClinicos5, @dadosClinicos6," +
            " @dadosClinicos7, @dadosClinicos8, @dadosClinicos9, @dadosClinicos10," +
            " @dadosClinicos11, @dadosClinicos12, @dadosClinicos12Resp, @obj1, @obj2," +
            " @obj3, @obj4, @obj5, @obj6, @obj7, @obj8, @observacoes);";
            
            
            //SELECT IDENTITY QUANDO SE UTILIZA A CHAVE AUTO_INCREMENT, DAÍ O SISTEMA RETORNA O CÓDIGO GERADO.

            // Passando os valores inseridos pelo usuário ao banco de dados.

            cmd.Parameters.AddWithValue("@idAluno", modelo.id_Aluno);
            cmd.Parameters.AddWithValue("@idade", modelo.Idade);
            cmd.Parameters.AddWithValue("@sexo", modelo.Sexo);
            cmd.Parameters.AddWithValue("@nome", modelo.Nome);
            cmd.Parameters.AddWithValue("@dataNascimento", modelo.data_Nascimento);
            cmd.Parameters.AddWithValue("@tipoSangue", modelo.tipo_Sangue);
            cmd.Parameters.AddWithValue("@celular", modelo.Celular);
            cmd.Parameters.AddWithValue("@telefone", modelo.Telefone);
            cmd.Parameters.AddWithValue("@email", modelo.Email);
            cmd.Parameters.AddWithValue("@endereco", modelo.Endereco);
            cmd.Parameters.AddWithValue("@bairro", modelo.Bairro);
            cmd.Parameters.AddWithValue("@complemento", modelo.Complemento);
            cmd.Parameters.AddWithValue("@cidade", modelo.Cidade);
            cmd.Parameters.AddWithValue("@uf", modelo.Uf);
            cmd.Parameters.AddWithValue("@cep", modelo.CEP);
            cmd.Parameters.AddWithValue("@dadosClinicos1", modelo.dados_Clinicos1);
            cmd.Parameters.AddWithValue("@dadosClinicos2", modelo.dados_Clinicos2);
            cmd.Parameters.AddWithValue("@dadosClinicos3", modelo.dados_Clinicos3);
            cmd.Parameters.AddWithValue("@dadosClinicos4", modelo.dados_Clinicos4);
            cmd.Parameters.AddWithValue("@dadosClinicos5", modelo.dados_Clinicos5);
            cmd.Parameters.AddWithValue("@dadosClinicos6", modelo.dados_Clinicos6);
            cmd.Parameters.AddWithValue("@dadosClinicos7", modelo.dados_Clinicos7);
            cmd.Parameters.AddWithValue("@dadosClinicos8", modelo.dados_Clinicos8);
            cmd.Parameters.AddWithValue("@dadosClinicos9", modelo.dados_Clinicos9);
            cmd.Parameters.AddWithValue("@dadosClinicos10", modelo.dados_Clinicos10);
            cmd.Parameters.AddWithValue("@dadosClinicos11", modelo.dados_Clinicos11);
            cmd.Parameters.AddWithValue("@dadosClinicos12", modelo.dados_Clinicos12);
            cmd.Parameters.AddWithValue("@dadosClinicos12Resp", modelo.dados_Clinicos12Resp);
            cmd.Parameters.AddWithValue("@obj1", modelo.Obj1);
            cmd.Parameters.AddWithValue("@obj2", modelo.Obj2);
            cmd.Parameters.AddWithValue("@obj3", modelo.Obj3);
            cmd.Parameters.AddWithValue("@obj4", modelo.Obj4);
            cmd.Parameters.AddWithValue("@obj5", modelo.Obj5);
            cmd.Parameters.AddWithValue("@obj6", modelo.Obj6);
            cmd.Parameters.AddWithValue("@obj7", modelo.Obj7);
            cmd.Parameters.AddWithValue("@obj8", modelo.Obj8);
            cmd.Parameters.AddWithValue("@observacoes", modelo.Observacoes);
                        

            conexao.Conectar();
            modelo.id_Aluno = Convert.ToInt32(cmd.ExecuteScalar());
            //modelo.id_Aluno = Convert.ToInt32(cmd.ExecuteScalar()); //ERRO. SÓ SERIA ASSIM CASO FOSSE AUTO_INCREMENT.
            conexao.Desconectar();
        }

        public void Alterar (ModeloCadastro modelo){

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = " update tblCadastro set idade = (@idade)," +      // Atribuindo valores à tabela cadastro com comandos SQL.
            " sexo = (@sexo), nome = (@nome), dataNascimento = (@dataNascimento), tipoSangue = (@tipoSangue), celular = (@celular),"
            + " telefone = (@telefone), email = (@email), endereco = (@endereco), bairro = (@bairro),"
            + " complemento = (@complemento), cidade = (@cidade), uf = (@uf), cep = (@cep), dadosClinicos1 = (@dadosClinicos1), dadosClinicos2 = (@dadosClinicos2),"
            + " dadosClinicos3 = (@dadosClinicos3), dadosClinicos4 = (@dadosClinicos4), dadosClinicos5 = (@dadosClinicos5), dadosClinicos6 = (@dadosClinicos6),"
            + " dadosClinicos7 = (@dadosClinicos7), dadosClinicos8 = (@dadosClinicos8), dadosClinicos9 = (@dadosClinicos9), dadosClinicos10 = (@dadosClinicos10),"
            + " dadosClinicos11 = (@dadosClinicos11), dadosClinicos12 = (@dadosClinicos12), dadosClinicos12Resp = (@dadosClinicos12Resp), obj1 = (@obj1), obj2 = (@obj2),"
            + " obj3 = (@obj3), obj4 = (@obj4), obj5 = (@obj5), obj6 = (@obj6), obj7 = (@obj7), obj8 = (@obj8), observacoes = (@observacoes) where idAluno = (@idAluno);";


            cmd.Parameters.AddWithValue("@idAluno", modelo.id_Aluno);
            cmd.Parameters.AddWithValue("@idade", modelo.Idade);
            cmd.Parameters.AddWithValue("@sexo", modelo.Sexo);
            cmd.Parameters.AddWithValue("@nome", modelo.Nome);
            cmd.Parameters.AddWithValue("@dataNascimento", modelo.data_Nascimento);
            cmd.Parameters.AddWithValue("@tipoSangue", modelo.tipo_Sangue);
            cmd.Parameters.AddWithValue("@telefone", modelo.Telefone);
            cmd.Parameters.AddWithValue("@email", modelo.Email);
            cmd.Parameters.AddWithValue("@endereco", modelo.Endereco);
            cmd.Parameters.AddWithValue("@bairro", modelo.Bairro);
            cmd.Parameters.AddWithValue("@complemento", modelo.Complemento);
            cmd.Parameters.AddWithValue("@cidade", modelo.Cidade);
            cmd.Parameters.AddWithValue("@uf", modelo.Uf);
            cmd.Parameters.AddWithValue("@cep", modelo.CEP);
            cmd.Parameters.AddWithValue("@dadosClinicos1", modelo.dados_Clinicos1);
            cmd.Parameters.AddWithValue("@dadosClinicos2", modelo.dados_Clinicos2);
            cmd.Parameters.AddWithValue("@dadosClinicos3", modelo.dados_Clinicos3);
            cmd.Parameters.AddWithValue("@dadosClinicos4", modelo.dados_Clinicos4);
            cmd.Parameters.AddWithValue("@dadosClinicos5", modelo.dados_Clinicos5);
            cmd.Parameters.AddWithValue("@dadosClinicos6", modelo.dados_Clinicos6);
            cmd.Parameters.AddWithValue("@dadosClinicos7", modelo.dados_Clinicos7);
            cmd.Parameters.AddWithValue("@dadosClinicos8", modelo.dados_Clinicos8);
            cmd.Parameters.AddWithValue("@dadosClinicos9", modelo.dados_Clinicos9);
            cmd.Parameters.AddWithValue("@dadosClinicos10", modelo.dados_Clinicos10);
            cmd.Parameters.AddWithValue("@dadosClinicos11", modelo.dados_Clinicos11);
            cmd.Parameters.AddWithValue("@dadosClinicos12", modelo.dados_Clinicos12);
            cmd.Parameters.AddWithValue("@dadosClinicos12Resp", modelo.dados_Clinicos12Resp);
            cmd.Parameters.AddWithValue("@obj1", modelo.Obj1);
            cmd.Parameters.AddWithValue("@obj2", modelo.Obj2);
            cmd.Parameters.AddWithValue("@obj3", modelo.Obj3);
            cmd.Parameters.AddWithValue("@obj4", modelo.Obj4);
            cmd.Parameters.AddWithValue("@obj5", modelo.Obj5);
            cmd.Parameters.AddWithValue("@obj6", modelo.Obj6);
            cmd.Parameters.AddWithValue("@obj7", modelo.Obj7);
            cmd.Parameters.AddWithValue("@obj8", modelo.Obj8);
            cmd.Parameters.AddWithValue("@observacoes", modelo.Observacoes);
            cmd.Parameters.AddWithValue("@celular", modelo.Celular);
                         
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();

        }

        public void Excluir(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from tblCadastro where idAluno = @idAluno;";
            
            cmd.Parameters.AddWithValue("@idAluno", id);
            
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();

        }

        public DataTable Localizar(int valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select idAluno, nome from tblCadastro where idAluno = " + valor + "", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;

        }


        // Este método é utilizado para carregar as matrículas armazenadas no banco de dados. No formulário 'telaPedeMatricula', este método é utilizado
        // para verificar se a matrícula inserida pelo usuário está no banco de dados:

        public bool verificaMatricula(int matricula)
        {
            // Estabelecemos a conexão com o banco de dados através da string gerada pelo prórpio banco de dados.

            using (SqlConnection conexao = new SqlConnection("Data Source=VH-NT-TI-01\\SQLEXPRESS;Initial Catalog=FitOnline;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "select idAluno from tblCadastro where idAluno = @idAluno"; 
                    cmd.Connection = conexao; // Estabelece a conexão com o banco de dados para iniciar a busca pela matricula.
                    cmd.Parameters.AddWithValue("@idAluno", matricula); // Aqui o sistema checa se a variável 'matricula' possui valor equivalente no banco.

                    conexao.Open();
                    
                    return Convert.ToBoolean(cmd.ExecuteScalar()); // Retorna o true ou false para a busca realizada.
                }
            }
        }



        public ModeloCadastro CarregaModeloCadastro(int id)
        {
            ModeloCadastro modelo = new ModeloCadastro();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from tblCadastro where idAluno = "+id+"";
            cmd.Parameters.AddWithValue("@idAluno", id);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows){
                registro.Read();
                modelo.id_Aluno = Convert.ToInt32(registro["idAluno"]);
                modelo.Idade = Convert.ToInt32(registro["idade"]);
                modelo.Sexo = Convert.ToChar(registro["sexo"]);
                modelo.Nome = Convert.ToString(registro["nome"]);
                modelo.data_Nascimento = Convert.ToString(registro["dataNascimento"]);
                modelo.Telefone = Convert.ToString(registro["telefone"]);
                modelo.Celular = Convert.ToString(registro["celular"]);
                modelo.tipo_Sangue = Convert.ToString(registro["tipoSangue"]);
                modelo.Email = Convert.ToString(registro["email"]);
                modelo.Endereco = Convert.ToString(registro["endereco"]);
                modelo.Bairro = Convert.ToString(registro["bairro"]);
                modelo.Complemento = Convert.ToString(registro["complemento"]);
                modelo.Cidade = Convert.ToString(registro["cidade"]);
                modelo.Uf = Convert.ToString(registro["uf"]);
                modelo.CEP = Convert.ToString(registro["cep"]);
                modelo.dados_Clinicos1 = Convert.ToBoolean(registro["dadosClinicos1"]);
                modelo.dados_Clinicos2 = Convert.ToBoolean(registro["dadosClinicos2"]);
                modelo.dados_Clinicos3 = Convert.ToBoolean(registro["dadosClinicos3"]);
                modelo.dados_Clinicos4 = Convert.ToBoolean(registro["dadosClinicos4"]);
                modelo.dados_Clinicos5 = Convert.ToBoolean(registro["dadosClinicos5"]);
                modelo.dados_Clinicos6 = Convert.ToBoolean(registro["dadosClinicos6"]);
                modelo.dados_Clinicos7 = Convert.ToBoolean(registro["dadosClinicos7"]);
                modelo.dados_Clinicos8 = Convert.ToBoolean(registro["dadosClinicos8"]);
                modelo.dados_Clinicos9 = Convert.ToBoolean(registro["dadosClinicos9"]);
                modelo.dados_Clinicos10 = Convert.ToBoolean(registro["dadosClinicos10"]);
                modelo.dados_Clinicos11 = Convert.ToBoolean(registro["dadosClinicos11"]);
                modelo.dados_Clinicos12 = Convert.ToBoolean(registro["dadosClinicos12"]);
                modelo.dados_Clinicos12Resp = Convert.ToString(registro["dadosClinicos12Resp"]);
                modelo.Obj1 = Convert.ToBoolean(registro["obj1"]);
                modelo.Obj2 = Convert.ToBoolean(registro["obj2"]);
                modelo.Obj3 = Convert.ToBoolean(registro["obj3"]);
                modelo.Obj4 = Convert.ToBoolean(registro["obj4"]);
                modelo.Obj5 = Convert.ToBoolean(registro["obj5"]);
                modelo.Obj6 = Convert.ToBoolean(registro["obj6"]);
                modelo.Obj7 = Convert.ToBoolean(registro["obj7"]);
                modelo.Obj8 = Convert.ToBoolean(registro["obj8"]);
                modelo.Observacoes = Convert.ToString(registro["observacoes"]);
                 

            }
            conexao.Desconectar();
            return modelo;
        }        
    }
}
