using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using DAL;
using BLL;
using Microsoft.VisualBasic;


namespace GUI
{
    public partial class telaCadastroEAvaliacao1 : Form
    {


        public telaCadastroEAvaliacao1()
        {
            InitializeComponent();
        }

        // Este método pode tem como função limpar todos os campos não salvos do formulário de cadastro.

        public void LimpaCampos()   
        {
            txtMatricula.Clear();
            txtIdade.Clear();
            txtSexo.Clear();
            txtNome.Clear();
            txtDataNascimento.Clear();
            txtTelefone.Clear();
            txtCelular.Clear();
            txtTipoSanguineo.Clear();
            txtEmail.Clear();
            txtEndereco.Clear();
            txtBairro.Clear();
            txtComplemento.Clear();
            txtCidade.Clear();
            txtUF.Clear();
            txtCEP.Clear();
            chkTeste.Checked = false;
            chkDadosClinicos2.Checked = false;
            chkDadosClinicos3.Checked = false;
            chkDadosClinicos4.Checked = false;
            chkDadosClinicos5.Checked = false;
            chkDadosClinicos6.Checked = false;
            chkDadosClinicos7.Checked = false;
            chkDadosClinicos8.Checked = false;
            chkDadosClinicos9.Checked = false;
            chkDadosClinicos10.Checked = false;
            chkDadosClinicos11.Checked = false;
            chkDadosClinicos12.Checked = false;
            txtRespDadoClinico12.Clear();
            chkObjetivo1.Checked = false;
            chkObjetivo2.Checked = false;
            chkObjetivo3.Checked = false;
            chkObjetivo4.Checked = false;
            chkObjetivo5.Checked = false;
            chkObjetivo6.Checked = false;
            chkObjetivo7.Checked = false;
            chkObjetivo8.Checked = false;
            textObservacoes.Clear();
            
        
        }

        private void Cadastro_Click(object sender, EventArgs e)
        {

        }

        private void telaCadastroEAvaliacao1_FormClosed(object sender, FormClosedEventArgs e)
        {
            telaInicial tInicio = new telaInicial();
            this.Hide();
            tInicio.ShowDialog();
            this.Dispose();
        }

        private void txtMatriculaAva_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void chkDadosClinicos1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textObservacoes_TextChanged(object sender, EventArgs e)
        {

        }

        private void textObservacoes_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void txtIdAvaliacao_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtDataAvaliacao_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Série_Click(object sender, EventArgs e)
        {

        }

        private void txtIdSerie_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdAvaliacaoSerie_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        

        // Este método é responsável por salvar os dados inseridos neste formulário de Cadastro/Avaliação Inicial/Série.

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {

            try
            {
                ModeloCadastro variavel = new ModeloCadastro();
                ModeloAvaliacaoFisica variavelAvaliacao = new ModeloAvaliacaoFisica();
                ModeloSerie variavelSerie = new ModeloSerie();
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCadastro bll = new BLLCadastro(cx);
                BLLAvaliacaoFisica bll2 = new BLLAvaliacaoFisica(cx);
                BLLSerie bll3 = new BLLSerie(cx);

                telaListaAvaliacoes lstAvaliacoes = new telaListaAvaliacoes();
                ModeloAvaliacaoFisica modelo = bll2.CarregaModeloAvaliacaoFisica(lstAvaliacoes.matricula);


                // Passando os dados da aba Cadastro e nas variáveis que o usuário deve obrigatoriamente inserir algum dado útilizamos o 
                // try / catch para criar as exceções que irão tratar as condições propostas, que neste caso são unicamente de não permitirem
                // valores nulos para estas variáveis:

                try
                {
                    if (txtNome.Text == "")
                    {
                        throw new Exception("Informe o nome.");
                    }
                    else
                    {
                        variavel.Nome = txtNome.Text;
                    }
                    if (txtMatricula.Text == "")
                    {
                        throw new Exception("Informe a matrícula.");
                    }
                    else
                    {
                        variavel.id_Aluno = Convert.ToInt32(txtMatricula.Text);
                    }
                    if (txtIdade.Text == "")
                    {
                        throw new Exception("Informe a idade.");
                    }
                    else
                    {
                        variavel.Idade = Convert.ToInt32(txtIdade.Text);
                    }
                    if (txtSexo.Text == "")
                    {
                        throw new Exception("Informe o sexo.");
                    }
                    else
                    {
                        variavel.Sexo = Convert.ToChar(txtSexo.Text);
                    }
                    if (txtDataNascimento.Text == "")
                    {
                        throw new Exception("Informe a data de nascimento.");
                    }
                    else
                    {
                        variavel.data_Nascimento = Convert.ToString(txtDataNascimento.Text);
                    }
                    if (txtCelular.Text == "")
                    {
                        throw new Exception("Informe o celular.");
                    }
                    else
                    {
                        variavel.Celular = Convert.ToString(txtCelular.Text);
                    }
                    if (txtTelefone.Text == "")
                    {
                        throw new Exception("Informe algum telefone.");
                    }
                    else
                    {
                        variavel.Telefone = Convert.ToString(txtTelefone.Text);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }              
                

                // ... Prosseguindo o procedimento de salvar, atribuindo às variáveis da classe ModeloCadastro os valores das textBox, por exemplo,
                // a variável "variavel.tipo_Sangue" está recebendo o que está no textBox "txtTipoSanguineo.Text".

               
                variavel.tipo_Sangue = Convert.ToString(txtTipoSanguineo.Text);
                variavel.Email = Convert.ToString(txtEmail.Text);
                variavel.Endereco = Convert.ToString(txtEndereco.Text);
                variavel.Bairro = Convert.ToString(txtBairro.Text);
                variavel.Complemento = Convert.ToString(txtComplemento.Text);
                variavel.Cidade = Convert.ToString(txtCidade.Text);
                variavel.Uf = Convert.ToString(txtUF.Text);
                variavel.CEP = Convert.ToString(txtCEP.Text);

                // Os dados armazenados pelas checkboxes são 'true' ou 'false', logo a função 'Checked ? true : false' verifica qual é o dado
                // que a checkbox contém, ou seja, verdadeiro ou falso:

                variavel.dados_Clinicos1 = Convert.ToBoolean(chkTeste.Checked ? true : false);
                variavel.dados_Clinicos2 = Convert.ToBoolean(chkDadosClinicos2.Checked ? true : false);
                variavel.dados_Clinicos3 = Convert.ToBoolean(chkDadosClinicos2.Checked ? true : false);
                variavel.dados_Clinicos4 = Convert.ToBoolean(chkDadosClinicos2.Checked ? true : false);
                variavel.dados_Clinicos5 = Convert.ToBoolean(chkDadosClinicos2.Checked ? true : false);
                variavel.dados_Clinicos6 = Convert.ToBoolean(chkDadosClinicos2.Checked ? true : false);
                variavel.dados_Clinicos7 = Convert.ToBoolean(chkDadosClinicos2.Checked ? true : false);
                variavel.dados_Clinicos8 = Convert.ToBoolean(chkDadosClinicos2.Checked ? true : false);
                variavel.dados_Clinicos9 = Convert.ToBoolean(chkDadosClinicos2.Checked ? true : false);
                variavel.dados_Clinicos10 = Convert.ToBoolean(chkDadosClinicos2.Checked ? true : false);
                variavel.dados_Clinicos11 = Convert.ToBoolean(chkDadosClinicos2.Checked ? true : false);
                variavel.dados_Clinicos12 = Convert.ToBoolean(chkDadosClinicos2.Checked ? true : false);
                variavel.dados_Clinicos12Resp = Convert.ToString(txtRespDadoClinico12.Text);
                variavel.Obj1 = Convert.ToBoolean(chkObjetivo1.Checked ? true : false);
                variavel.Obj2 = Convert.ToBoolean(chkObjetivo2.Checked ? true : false);
                variavel.Obj3 = Convert.ToBoolean(chkObjetivo3.Checked ? true : false);
                variavel.Obj4 = Convert.ToBoolean(chkObjetivo4.Checked ? true : false);
                variavel.Obj5 = Convert.ToBoolean(chkObjetivo5.Checked ? true : false);
                variavel.Obj6 = Convert.ToBoolean(chkObjetivo6.Checked ? true : false);
                variavel.Obj7 = Convert.ToBoolean(chkObjetivo7.Checked ? true : false);
                variavel.Obj8 = Convert.ToBoolean(chkObjetivo8.Checked ? true : false);
                variavel.Observacoes = Convert.ToString(textObservacoes.Text);


                // Através do método Incluir contido na classe BLL os dados estão sendo armazenados: 

                bll.Incluir(variavel);


                            // Passando os dados da aba Avaliação Física:

                            // Obs.: o idAvaliação não é passado pelo usuário, pois é auto-increment.


                                        // Dobras Cutâneas:               



                // Caso o usuário viesse a clicar no botão salvar deixando algum campo do tipo numérico (int, double, float...) vazio, o sistema 
                // acusaria um erro, pois no caso atual, estes tipos primitivos não aceitam valores nulos. Para resolver, utilizamos algumas variáveis 
                // auxiliares que serão iniciadas com zero, onde a ideia seria, por exemplo, caso a textBox 'txtTriceps.Text' esteja com algum valor na hora
                // em que o botão salvar for acionado, a variável 'auxTriceps' receberá o valor de 'txtTriceps.Text' convertido para int (neste caso) através 
                // desta forma: "int.TryParse(txtTriceps.Text, out auxTriceps)" e em seguida a variável 'variavelAvaliacao.Triceps' (que se conecta com o 
                // banco de dados) receberá o valor contido em 'auxTriceps'. Caso a textBox 'txtTriceps.Text' estiver vazia, de qualquer forma o valor passado
                // a variável 'variavelAvaliacao.Triceps' seria a de 'auxTriceps' cujo valor original é zero, impedindo a variável numérica de receber um valor
                // nulo:


                int auxTriceps = 0;
                int auxAxilarMedia = 0;
                int auxSubEspcapular = 0;
                int auxSupraIliaca = 0;
                int auxCoxa = 0;
                int auxAbdominalDC = 0;
                int auxToraxDC = 0;
                double auxPercGordura = 0;

                int.TryParse(txtTriceps.Text, out auxTriceps);
                int.TryParse(txtAxilarMedia.Text, out auxAxilarMedia);
                int.TryParse(txtSubEscapular.Text, out auxSubEspcapular);
                int.TryParse(txtSupraIliaca.Text, out auxSupraIliaca);
                int.TryParse(txtCoxa.Text, out auxCoxa);
                int.TryParse(txtAbdominalDC.Text, out auxAbdominalDC);
                int.TryParse(txtToraxDC.Text, out auxToraxDC);
                Double.TryParse(txtPercGordura.Text, out auxPercGordura);


                variavelAvaliacao.data_Avaliacao = Convert.ToString(txtDataAvaliacao.Text);
                variavelAvaliacao.id_Aluno = Convert.ToInt32(txtMatricula.Text);


                variavelAvaliacao.Triceps = auxTriceps;
                variavelAvaliacao.axilar_Media = auxAxilarMedia;
                variavelAvaliacao.sub_Escapular = auxSubEspcapular;
                variavelAvaliacao.supra_Iliaca = auxSupraIliaca;
                variavelAvaliacao.Coxa = auxCoxa;
                variavelAvaliacao.abdominal_DC = auxAbdominalDC;
                variavelAvaliacao.torax_DC = auxToraxDC;
                variavelAvaliacao.perc_Gordura = auxPercGordura;

                

                                        // Perímetros:


                double auxBracoRelaxadoDir = 0;
                double auxBracoRelaxadoEsq = 0;
                double auxBracoContraidoDir = 0;
                double auxBracoContraidoEsq = 0;
                double auxAntebracoDir = 0;
                double auxAntebracoEsq = 0;
                double auxCoxaDir = 0;
                double auxCoxaEsq = 0;
                double auxPernaDir = 0;
                double auxPernaEsq = 0;
                double auxToraxP = 0;
                double auxAbdominalP = 0;
                double auxCintura = 0;
                double auxQuadril = 0;
                double auxPescoco = 0;
                double auxRCQ = 0;


                Double.TryParse(txtBracoRelaxadoDir.Text, out auxBracoRelaxadoDir);
                Double.TryParse(txtBracoRelaxadoEsq.Text, out auxBracoRelaxadoEsq);
                Double.TryParse(txtBracoContraidoDir.Text, out auxBracoContraidoDir);
                Double.TryParse(txtBracoContraidoEsq.Text, out auxBracoContraidoEsq);
                Double.TryParse(txtAntebracoDir.Text, out auxAntebracoDir);
                Double.TryParse(txtAntebracoEsq.Text, out auxAntebracoEsq);
                Double.TryParse(txtCoxaDir.Text, out auxCoxaDir);
                Double.TryParse(txtCoxaEsq.Text, out auxCoxaEsq);
                Double.TryParse(txtPernaDir.Text, out auxPernaDir);
                Double.TryParse(txtPernaEsq.Text, out auxPernaEsq);
                Double.TryParse(txtToraxPerimetro.Text, out auxToraxP);
                Double.TryParse(txtAbdominalDC.Text, out auxAbdominalP);
                Double.TryParse(txtCintura.Text, out auxCintura);
                Double.TryParse(txtQuadril.Text, out auxQuadril);
                Double.TryParse(txtPescoco.Text, out auxPescoco);
                Double.TryParse(txtRCQ.Text, out auxRCQ);

                variavelAvaliacao.bracoRelaxado_Dir = auxBracoRelaxadoDir;
                variavelAvaliacao.bracoRelaxado_Esq = auxBracoRelaxadoEsq;
                variavelAvaliacao.bracoContraido_Dir = auxBracoContraidoDir;
                variavelAvaliacao.bracoContraido_Esq = auxBracoContraidoEsq;
                variavelAvaliacao.anteBraco_Dir = auxAntebracoDir;
                variavelAvaliacao.anteBraco_Esq = auxAntebracoEsq;
                variavelAvaliacao.coxa_Dir = auxCoxaDir;
                variavelAvaliacao.coxa_Esq = auxCoxaEsq;
                variavelAvaliacao.perna_Dir = auxPernaDir;
                variavelAvaliacao.perna_Esq = auxPernaEsq;
                variavelAvaliacao.torax_P = auxToraxP;
                variavelAvaliacao.abdominal_P = auxAbdominalP;
                variavelAvaliacao.Cintura = auxCintura;
                variavelAvaliacao.Quadril = auxQuadril;
                variavelAvaliacao.Pescoco = auxPescoco;
                variavelAvaliacao.RCQ = auxRCQ;


                                        // Dados Fisiológicos:


                double auxFreqCardiacaRep = 0;
                double auxFreqCardiacaMax = 0;
                double auxPeso = 0;
                double auxFlexaoBraco = 0;
                double auxAltura = 0;
                double auxVO2 = 0;
                double auxPressaoArterial = 0;
                double auxFlexTest = 0;
                double auxForcaAbdominal = 0;
                double auxMassaMagra = 0;
                double auxIMC = 0;


                Double.TryParse(txtFCR.Text, out auxFreqCardiacaRep);
                Double.TryParse(txtFCM.Text, out auxFreqCardiacaMax);
                Double.TryParse(txtPeso.Text, out auxPeso);
                Double.TryParse(txtFlexaoBraco.Text, out auxFlexaoBraco);
                Double.TryParse(txtAltura.Text, out auxAltura);
                Double.TryParse(txtVO2.Text, out auxVO2);
                Double.TryParse(txtPressaoArterial.Text, out auxPressaoArterial);
                Double.TryParse(txtFlexTest.Text, out auxFlexTest);
                Double.TryParse(txtForcaAbdominal.Text, out auxForcaAbdominal);
                Double.TryParse(txtMassaMagra.Text, out auxMassaMagra);
                Double.TryParse(txtIMC.Text, out auxIMC);

                variavelAvaliacao.freqCardiaca_Rep = auxFreqCardiacaRep;
                variavelAvaliacao.freqCardiaca_Max = auxFreqCardiacaMax;
                variavelAvaliacao.Peso = auxPeso;
                variavelAvaliacao.flexao_Braco = auxFlexaoBraco;
                variavelAvaliacao.Altura = auxAltura;
                variavelAvaliacao.Vo2 = auxVO2;
                variavelAvaliacao.pressao_Arterial = auxPressaoArterial;
                variavelAvaliacao.flex_Test = auxFlexTest;
                variavelAvaliacao.forca_Abdominal = auxForcaAbdominal;
                variavelAvaliacao.massa_Magra = auxMassaMagra;
                variavelAvaliacao.IMC = auxIMC;

                

                bll2.Incluir(variavelAvaliacao); // Incluindo os dados inseridos pelo usuário ao banco de dados.



                // Passando os dados da aba Série:

                // Obs.: o idSerie não é passado pelo usuário, pois é auto-increment.

                variavelSerie.id_Avaliacao = variavelAvaliacao.id_Avaliacao; // Passando o valor da PK idAvaliacao auto-increment para a FK da tblSerie.
                variavelSerie.id_Aluno = Convert.ToInt32(txtMatricula.Text);
                variavelSerie.Texto = Convert.ToString(textoSerie.Text);
                bll3.Incluir(variavelSerie); // Incluindo os dados inseridos pelo usuário ao banco de dados.


                MessageBox.Show("Salvo com sucesso!");
                if (MessageBox.Show("Deseja realizar outro cadastro?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    this.Close();
                }
                else
                {
                    LimpaCampos();
                }
            }
            catch (Exception)
            {
                
            }
            
            
        }


        // Chamando o comando para limpar os campos não salvos.

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            this.LimpaCampos();
        }


        // Este método cancela o form de cadastro e retorna ao form inicial.

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja cancelar este cadastro?", "Atenção!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtMatricula_TextChanged_1(object sender, EventArgs e)
        {
            // Fazendo com que a textBox txtMatriculaAva da aba Avaliação Inicial receba automaticamente
            // o valor da textBox txtMatricula da aba Cadastro Aluno.

            txtMatriculaAva.Text = txtMatricula.Text;
            txtMatriculaSerie.Text = txtMatricula.Text;
        }

        private void txtCelular_TextChanged(object sender, EventArgs e)
        {

        }


                                // Checkboxes dos dados clínicos:


        // Obs.: todos os métodos abaixo, referentes às checkboxes são para manipular o texto referente ao status delas, por exemplo,
        // se 'chkTeste.Checked == false' (se o status da checkbox for falso) chkTeste.Text = "Não" ou então chkTeste.Text = "Sim" 
        // (o texto que representa o status recebe "Não", caso contrário, "Sim"):


        private void chkTeste_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkTeste.Checked == false)
            {
                chkTeste.Text = "Não";
            }
            else
            {
                chkTeste.Text = "Sim";
            }

        }

        private void chkDadosClinicos2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDadosClinicos2.Checked == false)
            {
                chkDadosClinicos2.Text = "Não";
            }
            else
            {
                chkDadosClinicos2.Text = "Sim";
            }
        }

        private void chkDadosClinicos3_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDadosClinicos3.Checked == false)
            {
                chkDadosClinicos3.Text = "Não";
            }
            else
            {
                chkDadosClinicos3.Text = "Sim";
            }
        }

        private void chkDadosClinicos4_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDadosClinicos4.Checked == false)
            {
                chkDadosClinicos4.Text = "Não";
            }
            else
            {
                chkDadosClinicos4.Text = "Sim";
            }
        }

        private void chkDadosClinicos5_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDadosClinicos5.Checked == false)
            {
                chkDadosClinicos5.Text = "Não";
            }
            else
            {
                chkDadosClinicos5.Text = "Sim";
            }
        }

        private void chkDadosClinicos6_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDadosClinicos6.Checked == false)
            {
                chkDadosClinicos6.Text = "Não";
            }
            else
            {
                chkDadosClinicos6.Text = "Sim";
            }
        }

        private void chkDadosClinicos7_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDadosClinicos7.Checked == false)
            {
                chkDadosClinicos7.Text = "Não";
            }
            else
            {
                chkDadosClinicos7.Text = "Sim";
            }
        }

        private void chkDadosClinicos8_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDadosClinicos8.Checked == false)
            {
                chkDadosClinicos8.Text = "Não";
            }
            else
            {
                chkDadosClinicos8.Text = "Sim";
            }
        }

        private void chkDadosClinicos9_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDadosClinicos9.Checked == false)
            {
                chkDadosClinicos9.Text = "Não";
            }
            else
            {
                chkDadosClinicos9.Text = "Sim";
            }
        }

        private void chkDadosClinicos10_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDadosClinicos10.Checked == false)
            {
                chkDadosClinicos10.Text = "Não";
            }
            else
            {
                chkDadosClinicos10.Text = "Sim";
            }
        }

        private void chkDadosClinicos11_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDadosClinicos11.Checked == false)
            {
                chkDadosClinicos11.Text = "Não";
            }
            else
            {
                chkDadosClinicos11.Text = "Sim";
            }
        }

        private void chkDadosClinicos12_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDadosClinicos12.Checked == false)
            {
                chkDadosClinicos12.Text = "Não";
            }
            else
            {
                chkDadosClinicos12.Text = "Sim";
            }
        }



                                // CheckBoxes dos objetivos:


        private void chkObjetivo1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkObjetivo1.Checked == false)
            {
                chkObjetivo1.Text = "Não";
            }
            else
            {
                chkObjetivo1.Text = "Sim";
            }
        }

        private void chkObjetivo2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkObjetivo2.Checked == false)
            {
                chkObjetivo2.Text = "Não";
            }
            else
            {
                chkObjetivo2.Text = "Sim";
            }
        }

        private void chkObjetivo3_CheckedChanged(object sender, EventArgs e)
        {
            if (chkObjetivo3.Checked == false)
            {
                chkObjetivo3.Text = "Não";
            }
            else
            {
                chkObjetivo3.Text = "Sim";
            }        
        }

        private void chkObjetivo4_CheckedChanged(object sender, EventArgs e)
        {
            if (chkObjetivo4.Checked == false)
            {
                chkObjetivo4.Text = "Não";
            }
            else
            {
                chkObjetivo4.Text = "Sim";
            }
        }

        private void chkObjetivo5_CheckedChanged(object sender, EventArgs e)
        {
            if (chkObjetivo5.Checked == false)
            {
                chkObjetivo5.Text = "Não";
            }
            else
            {
                chkObjetivo5.Text = "Sim";
            }
        }

        private void chkObjetivo6_CheckedChanged(object sender, EventArgs e)
        {
            if (chkObjetivo6.Checked == false)
            {
                chkObjetivo6.Text = "Não";
            }
            else
            {
                chkObjetivo6.Text = "Sim";
            }
        }

        private void chkObjetivo7_CheckedChanged(object sender, EventArgs e)
        {
            if (chkObjetivo7.Checked == false)
            {
                chkObjetivo7.Text = "Não";
            }
            else
            {
                chkObjetivo7.Text = "Sim";
            }
        }

        private void chkObjetivo8_CheckedChanged(object sender, EventArgs e)
        {
            if (chkObjetivo8.Checked == false)
            {
                chkObjetivo8.Text = "Não";
            }
            else
            {
                chkObjetivo8.Text = "Sim";
            }
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }


                                // Calculando RCQ



        private void txtCintura_TextChanged(object sender, EventArgs e)
        {
            String strResultado = "";
            
            // A condição abaixo indica que a operação para efetuar o cálculo só poderá ser feita caso os campos necessários (cintura e quadril) não estejam
            // vazios, pois a conversão de um campo vazio para um tipo numérico resultaria em erro:

            if (txtCintura.Text.Length > 0 && txtQuadril.Text.Length > 0)
            {
                
               // Macete para mostrar apenas duas casas decimais:

               strResultado = Convert.ToString(string.Format("{0:N}",(Convert.ToDouble(txtCintura.Text) / Convert.ToDouble(txtQuadril.Text))));
               txtRCQ.Text = string.Format("{0:N}", strResultado);
            }
            else
            {
                txtRCQ.Text = Convert.ToString(0);
            }

        }

        private void txtQuadril_TextChanged(object sender, EventArgs e)
        {
            String strResultado = "";

            // A condição abaixo indica que a operação para efetuar o cálculo só poderá ser feita caso os campos necessários (cintura e quadril) não estejam
            // vazios, pois a conversão de um campo vazio para um tipo numérico resultaria em erro:

            if (txtCintura.Text.Length > 0 && txtQuadril.Text.Length > 0)
            {

                // Macete para mostrar apenas duas casas decimais:

                strResultado = Convert.ToString(string.Format("{0:N}",(Convert.ToDouble(txtCintura.Text) / Convert.ToDouble(txtQuadril.Text))));
                txtRCQ.Text = string.Format("{0:N}", strResultado);
            }
            else
            {
                txtRCQ.Text = Convert.ToString(0);
            }
        }

        private void txtRCQ_TextChanged(object sender, EventArgs e)
        {

        }


                                // Calculando IMC


        private void txtPeso_TextChanged(object sender, EventArgs e)
        {
            // Como o cálculo de massa magra depende do IMC e este do peso e altura, chamamos aqui o método responsável por calcular a massa magra para 
            // que as variações dos resultados causem efeito no resultado da operação desta:

            calculaMassaMagra();

            String strResultado = "";

            // A condição abaixo indica que a operação para efetuar o cálculo só poderá ser feita caso os campos necessários (peso e altura) não estejam
            // vazios, pois a conversão de um campo vazio para um tipo numérico resultaria em erro:

            if (txtPeso.Text.Length > 0 && txtAltura.Text.Length > 0)
            {
                double auxAltura = Convert.ToDouble(txtAltura.Text);

                // Macete para mostrar apenas duas casas decimais:

                // Obs.: utilizamos o 'Math.Pow' para obtermos a raiz quadrada da altura.

                strResultado = Convert.ToString(string.Format("{0:N}", (Convert.ToDouble(txtPeso.Text) / Convert.ToDouble(Math.Pow(auxAltura,2)))));
                txtIMC.Text = string.Format("{0:N}", strResultado);
            }
            else
            {
                txtIMC.Text = Convert.ToString(0);
            }
             
        }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {
            String strResultado = "";            

            if (txtPeso.Text.Length > 0 && txtAltura.Text.Length > 0)
            {
                double auxAltura = Convert.ToDouble(txtAltura.Text);

                // Macete para mostrar apenas duas casas decimais:

                strResultado = Convert.ToString(string.Format("{0:N}", (Convert.ToDouble(txtPeso.Text) / Convert.ToDouble(Math.Pow(auxAltura, 2)))));
                txtIMC.Text = string.Format("{0:N}", strResultado);
            }
            else
            {
                txtIMC.Text = Convert.ToString(0);
            }
        }


                                // Cálculo do Percentual de Gordura Corporal



        private void calculaPercGordura2()
        {

            double densidadeCorporal = 0;
            double auxPercGordura = 0;

            String strResultado = "";

            
            if (txtIdade.Text.Length > 0 && txtSexo.Text.Length > 0 && txtTriceps.Text.Length > 0 && txtAxilarMedia.Text.Length > 0
                && txtSubEscapular.Text.Length > 0 && txtSupraIliaca.Text.Length > 0 && txtCoxa.Text.Length > 0 && txtAbdominalDC.Text.Length > 0
                && txtToraxDC.Text.Length > 0)
            {

                int auxIdade = Convert.ToInt32(txtIdade.Text);
                String auxSexo = txtSexo.Text;
                int auxTriceps = Convert.ToInt32(txtTriceps.Text);
                int auxAxilarMedia = Convert.ToInt32(txtAxilarMedia.Text);
                int auxSubEscapular = Convert.ToInt32(txtSubEscapular.Text);
                int auxSupraIliaca = Convert.ToInt32(txtSupraIliaca.Text);
                int auxCoxa = Convert.ToInt32(txtCoxa.Text);
                int auxAbdominal = Convert.ToInt32(txtAbdominalDC.Text);
                int auxTorax = Convert.ToInt32(txtToraxDC.Text);

                int soma7Dobras = auxTriceps + auxAxilarMedia + auxSubEscapular + auxSupraIliaca + auxCoxa + auxAbdominal + auxTorax;


                if (txtSexo.Text.Equals("M"))
                {
                    densidadeCorporal = Convert.ToDouble(1.112 - (0.00043499 * soma7Dobras) + (0.00000055 * (Math.Pow(soma7Dobras, 2)) - (0.00028826 * auxIdade)));

                    auxPercGordura = Convert.ToDouble(((4.95 / densidadeCorporal) - 4.5) * 100);

                }
                else if (txtSexo.Text.Equals("F"))
                {
                    densidadeCorporal = Convert.ToDouble(1.0970 - (0.00046971 * soma7Dobras) + (0.00000056 * (Math.Pow(soma7Dobras, 2)) - (0.00012828 * auxIdade)));
                    auxPercGordura = Convert.ToDouble(((4.95 / densidadeCorporal) - 4.5) * 100);
                }

                // Macete para mostrar apenas duas casas decimais:

                strResultado = Convert.ToString(string.Format("{0:N}", auxPercGordura));
                txtPercGordura.Text = string.Format("{0:N}", strResultado);


            }
            else
            {
                txtPercGordura.Text = Convert.ToString(0);
            }

        }
        
        private void txtIdade_TextChanged(object sender, EventArgs e)
        {
            // Esta variável interfere no cálculo do percuntual de gordura, logo o método para calculá-lo é 
            // chamado aqui também:

            calculaPercGordura2();
        }

        private void txtSexo_TextChanged(object sender, EventArgs e)
        {
            // Esta variável interfere no cálculo do percuntual de gordura, logo o método para calculá-lo é 
            // chamado aqui também:

            calculaPercGordura2();
        }

        private void txtIMC_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtAbdominalPer_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPercGordura_TextChanged(object sender, EventArgs e)
        {
            // Esta variável interfere no cálculo de massa magra, logo o método para calculá-lo é 
            // chamado aqui também:

            calculaMassaMagra();
        }


        // Método utilizado para limpar todos os campos não salvos:


        private void btnLimpa_Click(object sender, EventArgs e)
        {
            txtTriceps.Clear();
            txtAxilarMedia.Clear();
            txtSubEscapular.Clear();
            txtSupraIliaca.Clear();
            txtCoxa.Clear();
            txtAbdominalDC.Clear();
            txtToraxDC.Clear();
            txtDataAvaliacao.Clear();
            txtBracoRelaxadoDir.Clear();
            txtBracoRelaxadoEsq.Clear();
            txtBracoContraidoDir.Clear();
            txtBracoContraidoEsq.Clear();
            txtAntebracoDir.Clear();
            txtAntebracoEsq.Clear();
            txtCoxaDir.Clear();
            txtCoxaEsq.Clear();
            txtPernaDir.Clear();
            txtPernaEsq.Clear();
            txtToraxPerimetro.Clear();
            txtCintura.Clear();
            txtAbdominalPer.Clear();
            txtQuadril.Clear();
            txtPescoco.Clear();
            txtFCR.Clear();
            txtFCM.Clear();
            txtVO2.Clear();
            txtPressaoArterial.Clear();
            txtMassaMagra.Clear();
            txtFlexaoBraco.Clear();
            txtPeso.Clear();
            txtAltura.Clear();
            txtFlexTest.Clear();
            txtForcaAbdominal.Clear();
            

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {
             
        }

        private void txtTriceps_TextChanged(object sender, EventArgs e)
        {
            // Esta variável interfere no cálculo do percuntual de gordura, logo o método para calculá-lo é 
            // chamado aqui também:

            calculaPercGordura2();
        }

        private void txtAxilarMedia_TextChanged(object sender, EventArgs e)
        {
            // Esta variável interfere no cálculo do percuntual de gordura, logo o método para calculá-lo é 
            // chamado aqui também:

            calculaPercGordura2();
        }

        private void txtSubEscapular_TextChanged(object sender, EventArgs e)
        {
            // Esta variável interfere no cálculo do percuntual de gordura, logo o método para calculá-lo é 
            // chamado aqui também:

            calculaPercGordura2();
        }

        private void txtSupraIliaca_TextChanged(object sender, EventArgs e)
        {
            calculaPercGordura2();
        }

        private void txtCoxa_TextChanged(object sender, EventArgs e)
        {
            calculaPercGordura2();
        }

        private void txtAbdominalDC_TextChanged(object sender, EventArgs e)
        {
            calculaPercGordura2();
        }

        private void txtToraxDC_TextChanged(object sender, EventArgs e)
        {
            calculaPercGordura2();
        }


                                // Calculando a Massa Magra:


        private void calculaMassaMagra()
        {

            double auxMassaGorda = 0;
            double auxMassaMagra = 0;


            if (txtPercGordura.Text.Length > 0 && txtPeso.Text.Length > 0)
            {
                double auxPeso = Convert.ToDouble(txtPeso.Text);
                double auxPercGordura = Convert.ToDouble(txtPercGordura.Text) / 100;

                auxMassaGorda = auxPeso * auxPercGordura;
                auxMassaMagra = auxPeso - auxMassaGorda;

                txtMassaMagra.Text = Convert.ToString(string.Format("{0:N}", auxMassaMagra));

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            telaParametros parametros = new telaParametros();

            parametros.ShowDialog();


        }

    }
}