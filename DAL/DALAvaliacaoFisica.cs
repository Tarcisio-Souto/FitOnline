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
    public class DALAvaliacaoFisica
    {
        private DALConexao conexao;

        public DALAvaliacaoFisica (DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloAvaliacaoFisica modelo)
        {
            ModeloSerie modeloSerie = new ModeloSerie();
            SqlCommand cmd = new SqlCommand();     // A função SqlCommand habilita os comandos SQL no sistema. 
            cmd.Connection = conexao.ObjetoConexao; // Passando qual a conexão que o sistema irá utilizar, neste caso, o da variável conexao.
                        
            cmd.CommandText = "insert into tblAvaliacaoFisica (dataAvaliacao, triceps, axilarMedia, subEscapular, supraIliaca,"
            + " coxa, abdominalDC, toraxDC, percGordura, toraxP, abdominalP, cintura, quadril, rcq, pescoco, bracoRelaxadoDir, bracoRelaxadoEsq,"
            + " bracoContraidoDir, bracoContraidoEsq, antebracoDir, antebracoEsq, coxaDir, coxaEsq, pernaDir, pernaEsq, freqCardiacaRep,"
            + " freqCardiacaMax, peso, massaMagra, flexTest, altura, flexaoBraco, vo2, pressaoArterial, imc, forcaAbdominal, idAluno)"
            + " values(@dataAvaliacao, @triceps, @axilarMedia, @subEscapular, @supraIliaca,"
            + " @coxa, @abdominalDC, @toraxDC, @percGordura, @toraxP, @abdominalP, @cintura, @quadril, @rcq, @pescoco, @bracoRelaxadoDir, @bracoRelaxadoEsq,"
            + " @bracoContraidoDir, @bracoContraidoEsq, @antebracoDir, @antebracoEsq, @coxaDir, @coxaEsq, @pernaDir, @pernaEsq, @freqCardiacaRep,"
            + " @freqCardiacaMax, @peso, @massaMagra, @flexTest, @altura, @flexaoBraco, @vo2, @pressaoArterial, @imc, @forcaAbdominal, @idAluno); select @@IDENTITY;";


            cmd.Parameters.AddWithValue("@idAvaliacao", modelo.id_Avaliacao);
            cmd.Parameters.AddWithValue("@dataAvaliacao", modelo.data_Avaliacao);
            cmd.Parameters.AddWithValue("@triceps", modelo.Triceps);            
            cmd.Parameters.AddWithValue("@axilarMedia", modelo.axilar_Media);
            cmd.Parameters.AddWithValue("@subEscapular", modelo.sub_Escapular);
            cmd.Parameters.AddWithValue("@supraIliaca", modelo.supra_Iliaca);
            cmd.Parameters.AddWithValue("@coxa", modelo.Coxa);
            cmd.Parameters.AddWithValue("@abdominalDC", modelo.abdominal_DC);
            cmd.Parameters.AddWithValue("@toraxDC", modelo.torax_DC);
            cmd.Parameters.AddWithValue("@percGordura", modelo.perc_Gordura);
            cmd.Parameters.AddWithValue("@toraxP", modelo.torax_P);
            cmd.Parameters.AddWithValue("@abdominalP", modelo.abdominal_P);
            cmd.Parameters.AddWithValue("@cintura", modelo.Cintura);
            cmd.Parameters.AddWithValue("@quadril", modelo.Quadril);
            cmd.Parameters.AddWithValue("@pescoco", modelo.Pescoco);
            cmd.Parameters.AddWithValue("@bracoRelaxadoDir", modelo.bracoRelaxado_Dir);
            cmd.Parameters.AddWithValue("@bracoRelaxadoEsq", modelo.bracoRelaxado_Esq);
            cmd.Parameters.AddWithValue("@bracoContraidoDir", modelo.bracoContraido_Dir);
            cmd.Parameters.AddWithValue("@bracoContraidoEsq", modelo.bracoContraido_Esq);
            cmd.Parameters.AddWithValue("@antebracoDir", modelo.anteBraco_Dir);
            cmd.Parameters.AddWithValue("@antebracoEsq", modelo.anteBraco_Esq);
            cmd.Parameters.AddWithValue("@coxaDir", modelo.coxa_Dir);
            cmd.Parameters.AddWithValue("@coxaEsq", modelo.coxa_Esq);
            cmd.Parameters.AddWithValue("@pernaDir", modelo.perna_Dir);
            cmd.Parameters.AddWithValue("@pernaEsq", modelo.perna_Esq);
            cmd.Parameters.AddWithValue("@rcq", modelo.RCQ);
            cmd.Parameters.AddWithValue("@freqCardiacaRep", modelo.freqCardiaca_Rep);
            cmd.Parameters.AddWithValue("@freqCardiacaMax", modelo.freqCardiaca_Max);
            cmd.Parameters.AddWithValue("@peso", modelo.Peso);
            cmd.Parameters.AddWithValue("@massaMagra", modelo.massa_Magra);
            cmd.Parameters.AddWithValue("@flexTest", modelo.flex_Test);
            cmd.Parameters.AddWithValue("@altura", modelo.Altura);
            cmd.Parameters.AddWithValue("@flexaoBraco", modelo.flexao_Braco);
            cmd.Parameters.AddWithValue("@vo2", modelo.Vo2);
            cmd.Parameters.AddWithValue("@pressaoArterial", modelo.pressao_Arterial);
            cmd.Parameters.AddWithValue("@imc", modelo.IMC);
            cmd.Parameters.AddWithValue("@forcaAbdominal", modelo.forca_Abdominal);
            cmd.Parameters.AddWithValue("@idAluno", modelo.id_Aluno);
            

            conexao.Conectar();
            modelo.id_Avaliacao = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();


        }

        public void Alterar(ModeloAvaliacaoFisica modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            
            cmd.CommandText = "update tblAvaliacaoFisica set idAluno = (@idAluno), dataAvaliacao = (@dataAvaliacao), triceps = (@triceps), axilarMedia = (@axilarMedia), subEscapular = (@subEscapular),"
            + " supraIliaca = (@supraIliaca), coxa = (@coxa), abdominalDC = (@abdominalDC), toraxDC = (@toraxDC), percGordura = (@percGordura), toraxP = (@toraxP), abdominalP = (@abdominalP),"
            + " cintura = (@cintura), quadril = (@quadril), pescoco = (@pescoco), bracoRelaxadoDir = (@bracoRelaxadoDir), bracoRelaxadoEsq = (@bracoRelaxadoEsq),"
            + " bracoContraidoDir = (@bracoContraidoDir), bracoContraidoEsq = (@bracoContraidoEsq), antebracoDir = (@antebracoDir), antebracoEsq = (@antebracoEsq), coxaDir = (@coxaDir),"
            + " coxaEsq = (@coxaEsq), pernaDir = (@pernaDir), pernaEsq = (@pernaEsq), rcq = (@rcq), freqCardiacaRep = (@freqCardiacaRep), freqCardiacaMax = (@freqCardiacaMax), peso = (@peso),"
            + " massaMagra = (@massaMagra), flexTest = (@flexTest), altura = (@altura), flexaoBraco = (@flexaoBraco), vo2 = (@vo2), pressaoArterial = (@pressaoArterial),"
            + " forcaAbdominal = (@forcaAbdominal), imc = (@imc) where idAvaliacao = (@idAvaliacao);";            


            cmd.Parameters.AddWithValue("@idAvaliacao", modelo.id_Avaliacao);
            cmd.Parameters.AddWithValue("@idAluno", modelo.id_Aluno);
            cmd.Parameters.AddWithValue("@dataAvaliacao", modelo.data_Avaliacao);
            cmd.Parameters.AddWithValue("@triceps", modelo.Triceps);
            cmd.Parameters.AddWithValue("@axilarMedia", modelo.axilar_Media);
            cmd.Parameters.AddWithValue("@subEscapular", modelo.sub_Escapular);
            cmd.Parameters.AddWithValue("@supraIliaca", modelo.supra_Iliaca);
            cmd.Parameters.AddWithValue("@coxa", modelo.Coxa);
            cmd.Parameters.AddWithValue("@abdominalDC", modelo.abdominal_DC);
            cmd.Parameters.AddWithValue("@toraxDC", modelo.torax_DC);
            cmd.Parameters.AddWithValue("@percGordura", modelo.perc_Gordura);
            cmd.Parameters.AddWithValue("@toraxP", modelo.torax_P);
            cmd.Parameters.AddWithValue("@abdominalP", modelo.abdominal_P);
            cmd.Parameters.AddWithValue("@cintura", modelo.Cintura);
            cmd.Parameters.AddWithValue("@quadril", modelo.Quadril);
            cmd.Parameters.AddWithValue("@pescoco", modelo.Pescoco);
            cmd.Parameters.AddWithValue("@bracoRelaxadoDir", modelo.bracoRelaxado_Dir);
            cmd.Parameters.AddWithValue("@bracoRelaxadoEsq", modelo.bracoRelaxado_Esq);
            cmd.Parameters.AddWithValue("@bracoContraidoDir", modelo.bracoContraido_Dir);
            cmd.Parameters.AddWithValue("@bracoContraidoEsq", modelo.bracoContraido_Esq);
            cmd.Parameters.AddWithValue("@antebracoDir", modelo.anteBraco_Dir);
            cmd.Parameters.AddWithValue("@antebracoEsq", modelo.anteBraco_Esq);
            cmd.Parameters.AddWithValue("@coxaDir", modelo.coxa_Dir);
            cmd.Parameters.AddWithValue("@coxaEsq", modelo.coxa_Esq);
            cmd.Parameters.AddWithValue("@pernaDir", modelo.perna_Dir);
            cmd.Parameters.AddWithValue("@pernaEsq", modelo.perna_Esq);
            cmd.Parameters.AddWithValue("@rcq", modelo.RCQ);
            cmd.Parameters.AddWithValue("@freqCardiacaRep", modelo.freqCardiaca_Rep);
            cmd.Parameters.AddWithValue("@freqCardiacaMax", modelo.freqCardiaca_Max);
            cmd.Parameters.AddWithValue("@peso", modelo.Peso);
            cmd.Parameters.AddWithValue("@massaMagra", modelo.massa_Magra);
            cmd.Parameters.AddWithValue("@flexTest", modelo.flex_Test);
            cmd.Parameters.AddWithValue("@altura", modelo.Altura);
            cmd.Parameters.AddWithValue("@flexaoBraco", modelo.flexao_Braco);
            cmd.Parameters.AddWithValue("@vo2", modelo.Vo2);
            cmd.Parameters.AddWithValue("@pressaoArterial", modelo.pressao_Arterial);
            cmd.Parameters.AddWithValue("@imc", modelo.IMC);
            cmd.Parameters.AddWithValue("@forcaAbdominal", modelo.forca_Abdominal);
 
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }


        public void Excluir(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from tblAvaliacaoFisica where idAvaliacao = @idAvaliacao;";
            cmd.Parameters.AddWithValue("@idAvaliacao", id);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(int valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select idAvaliacao, dataAvaliacao from tblAvaliacaoFisica where idAluno = " + valor + "", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        
        public ModeloAvaliacaoFisica CarregaModeloAvaliacaoFisica(int id)
        {
            ModeloAvaliacaoFisica modelo = new ModeloAvaliacaoFisica();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from tblAvaliacaoFisica where idAvaliacao = " + id + "";
            cmd.Parameters.AddWithValue("@idAvaliacao", id);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();

                modelo.id_Avaliacao = Convert.ToInt32(registro["idAvaliacao"]);
                modelo.data_Avaliacao = Convert.ToString(registro["dataAvaliacao"]);
                modelo.Triceps = Convert.ToInt32(registro["triceps"]);
                modelo.axilar_Media = Convert.ToInt32(registro["axilarMedia"]);
                modelo.sub_Escapular = Convert.ToInt32(registro["subEscapular"]);
                modelo.supra_Iliaca = Convert.ToInt32(registro["supraIliaca"]);
                modelo.Coxa = Convert.ToInt32(registro["coxa"]);
                modelo.abdominal_DC = Convert.ToInt32(registro["abdominalDC"]);
                modelo.torax_DC = Convert.ToInt32(registro["toraxDC"]);
                modelo.perc_Gordura = Convert.ToDouble(registro["percGordura"]);
                modelo.torax_P = Convert.ToDouble(registro["toraxP"]);
                modelo.abdominal_P = Convert.ToDouble(registro["abdominalP"]);
                modelo.Cintura = Convert.ToDouble(registro["cintura"]);
                modelo.Quadril = Convert.ToDouble(registro["quadril"]);
                modelo.Pescoco = Convert.ToDouble(registro["pescoco"]);
                modelo.bracoRelaxado_Dir = Convert.ToDouble(registro["bracoRelaxadoDir"]);
                modelo.bracoRelaxado_Esq = Convert.ToDouble(registro["bracoRelaxadoEsq"]);
                modelo.bracoContraido_Dir= Convert.ToDouble(registro["bracoContraidoDir"]);
                modelo.bracoContraido_Esq = Convert.ToDouble(registro["bracoContraidoEsq"]);
                modelo.anteBraco_Dir = Convert.ToDouble(registro["antebracoDir"]);
                modelo.anteBraco_Esq = Convert.ToDouble(registro["antebracoEsq"]);
                modelo.coxa_Dir = Convert.ToDouble(registro["coxaDir"]);
                modelo.coxa_Esq = Convert.ToDouble(registro["coxaEsq"]);
                modelo.perna_Dir = Convert.ToDouble(registro["pernaDir"]);
                modelo.perna_Esq = Convert.ToDouble(registro["pernaEsq"]);
                modelo.RCQ = Convert.ToDouble(registro["rcq"]);
                modelo.freqCardiaca_Rep = Convert.ToDouble(registro["freqCardiacaRep"]);
                modelo.freqCardiaca_Max = Convert.ToDouble(registro["freqCardiacaMax"]);
                modelo.Peso = Convert.ToDouble(registro["peso"]);
                modelo.massa_Magra = Convert.ToDouble(registro["massaMagra"]);
                modelo.flex_Test = Convert.ToInt32(registro["flexTest"]);
                modelo.Altura = Convert.ToDouble(registro["altura"]);
                modelo.flexao_Braco = Convert.ToInt32(registro["flexaoBraco"]);
                modelo.Vo2 = Convert.ToDouble(registro["vo2"]);
                modelo.pressao_Arterial = Convert.ToDouble(registro["pressaoArterial"]);
                modelo.IMC = Convert.ToDouble(registro["imc"]);
                modelo.forca_Abdominal = Convert.ToDouble(registro["forcaAbdominal"]);
                modelo.id_Aluno = Convert.ToInt32(registro["idAluno"]);
                
            }

            conexao.Desconectar();
            return modelo;
        }     



    }
}
