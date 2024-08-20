using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Modelo;
using DAL;

namespace GUI
{
    public partial class telaListaAvaliacoes : Form
    {
        public int matricula = 0;
        public int pedeMatricula = 0;
        public int nAvaliacao = 0;
        int indice = 0;     
        List<int> lstAvaliacoes = new List<int>();
        List<int> lstNAvaliacoes = new List<int>();

        public telaListaAvaliacoes()
        {
            InitializeComponent();
        }

        private void btnNovaAvaliacao_Click(object sender, EventArgs e)
        {
            
        }

        // Este método (btnAbrirSelecao_Click) é responsável por abrir as avaliações ou cadastro selecionado através do click com o mouse.
        // Ao clicar sob o cadastro que deseja abrir, o método 'dgvCadastro_CellClick' (procurar no código) irá atribuir à variável 'matricula' o valor da 
        // primeira célula do DataGridView (tabela) de cadastro que é a matrícula do aluno que será a chave para carregar os dados correspondentes ao 
        // aluno desta matrícula através do método 'ModeloCadastro modelo = bll.CarregaModeloCadastro(matricula);' que será utilizado para carregar
        // os dados já armazenados no banco de dados e projetá-los nas textBoxes da tela de visualização de cadastro (telaVisualizacaoCadastro).
        // O mesmo procedimento ocorreria com as avaliações, ou seja, o usuário seleciona a avaliação, o método 'dgvLstAvaliacoes_CellClick_1' (procurar no
        // código) atribui à variável nAvaliacao o valor da primeira célula do DataGridView (tabela) de avaliações que é o código da avaliação que será
        // utilizado para carregar os dados da avaliação correspondente a este código através do método 'ModeloAvaliacaoFisica modelo = bll2.CarregaModeloAvaliacaoFisica(nAvaliacao);'
        // que projetará os dados armazenados nos textBoxes da tela de visualização de avaliação (telaVisualizaAvaliacao).
        
        

        private void btnAbrirSelecao_Click(object sender, EventArgs e) 
        {   
            telaVisualizacaoCadastro visualiza = new telaVisualizacaoCadastro();
            telaVisualizaAvaliacao visualizaAva = new telaVisualizaAvaliacao();

            visualiza.matriculaDGV = Convert.ToInt32(dgvCadastro.Rows[0].Cells[0].Value.ToString());
            
            
            // A condição abaixo determina que o processo de carregar o cadastro selecionado será feito se houver número de matrícula
            // para ser utilizado como parâmetro no 'bll.CarregaModeloCadastro(matricula);', possibilitando a busca dos dados. A condição
            // também implica que a variável 'nAvaliacao' deve estar zerada, pois se não fosse assim, ao clicar em no botão abrir, o sistema
            // exibiria as telas de cadastro e avaliação juntas. Para resolver isto, no método 'dgvCadastro_CellClick' determinamos que ao selecionar
            // o item da tabela de cadastro a variável 'matricula' receberia o valor da célula zero (a matrícula), enquanto que a variável
            // 'nAvaliacao' receberia zero, evitando o conflito de múltiplos formulários sendo abertos ao mesmo tempo. O mesmo processo ocorre
            // no método 'dgvLstAvaliacoes_CellClick_1', porém com os parâmetros invertidos, por assim dizer, por exemplo, se 'nAvaliacao' receber
            // algum valor, a variável 'matricula' receberá zero.


            if (matricula != 0 && nAvaliacao == 0)
            {
                
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCadastro bll = new BLLCadastro(cx);
                ModeloCadastro modelo = bll.CarregaModeloCadastro(matricula); // << Passando a variável 'matricula' como parâmetro para carregar os dados.


                // Carregando os valores armazenados no banco de dados e projetando-os nas textBox da tela de visualização de cadastro:


                visualiza.txtMatricula.Text = modelo.id_Aluno.ToString();
                visualiza.txtIdade.Text = modelo.Idade.ToString();
                visualiza.txtSexo.Text = modelo.Sexo.ToString();
                visualiza.txtNome.Text = modelo.Nome;
                visualiza.txtDataNascimento.Text = modelo.data_Nascimento;
                visualiza.txtTipoSanguineo.Text = modelo.tipo_Sangue;
                visualiza.txtTelefone.Text = modelo.Telefone;
                visualiza.txtCelular.Text = modelo.Celular;                
                visualiza.txtEmail.Text = modelo.Email;
                visualiza.txtEndereco.Text = modelo.Endereco;
                visualiza.txtBairro.Text = modelo.Bairro;
                visualiza.txtComplemento.Text = modelo.Complemento;
                visualiza.txtCidade.Text = modelo.Cidade;
                visualiza.txtUF.Text = modelo.Uf;
                visualiza.txtCEP.Text = modelo.CEP;


                                        // Controlando a exibição das checkBoxes dos Dados Clínicos:


                visualiza.chkTeste.Text = modelo.dados_Clinicos1.ToString();


                // Obs.: para todos os casos de checkBoxes abaixo: o banco de dados não armazena as strings "Sim" ou "Não" como quando incluímos
                // os dados inicialmente, ao invés disso ele armazena 'true' ou 'false'. Por isso é necessário indicar que conforme o status da variável
                // o sistema carregará as textBoxes devidamente, por exemplo, se a variável for 'true', a string que acompanha o textBox será "Sim" e a 
                // checkBox receberá 'true', ou seja, estará selecionada:


                if (visualiza.chkTeste.Text == "True")
                {
                    visualiza.chkTeste.Text = "Sim";
                    visualiza.chkTeste.Checked = true;
                }
                else
                {
                    visualiza.chkTeste.Text = "Não";
                    visualiza.chkTeste.Checked = false;
                }

                ////
                visualiza.chkDadosClinicos2.Text = modelo.dados_Clinicos2.ToString();

                if (visualiza.chkDadosClinicos2.Text == "True")
                {
                    visualiza.chkDadosClinicos2.Text = "Sim";
                    visualiza.chkDadosClinicos2.Checked = true;
                }
                else
                {
                    visualiza.chkDadosClinicos2.Text = "Não";
                    visualiza.chkDadosClinicos2.Checked = false;
                }

                ////
                visualiza.chkDadosClinicos3.Text = modelo.dados_Clinicos3.ToString();

                if (visualiza.chkDadosClinicos3.Text == "True")
                {
                    visualiza.chkDadosClinicos3.Text = "Sim";
                    visualiza.chkDadosClinicos3.Checked = true;
                }
                else
                {
                    visualiza.chkDadosClinicos3.Text = "Não";
                    visualiza.chkDadosClinicos3.Checked = false;
                }

                ////
                visualiza.chkDadosClinicos4.Text = modelo.dados_Clinicos4.ToString();

                if (visualiza.chkDadosClinicos4.Text == "True")
                {
                    visualiza.chkDadosClinicos4.Text = "Sim";
                    visualiza.chkDadosClinicos4.Checked = true;
                }
                else
                {
                    visualiza.chkDadosClinicos4.Text = "Não";
                    visualiza.chkDadosClinicos4.Checked = false;
                }

                ////
                visualiza.chkDadosClinicos5.Text = modelo.dados_Clinicos5.ToString();

                if (visualiza.chkDadosClinicos5.Text == "True")
                {
                    visualiza.chkDadosClinicos5.Text = "Sim";
                    visualiza.chkDadosClinicos5.Checked = true;
                }
                else
                {
                    visualiza.chkDadosClinicos5.Text = "Não";
                    visualiza.chkDadosClinicos5.Checked = false;
                }

                ////
                visualiza.chkDadosClinicos6.Text = modelo.dados_Clinicos6.ToString();

                if (visualiza.chkDadosClinicos6.Text == "True")
                {
                    visualiza.chkDadosClinicos6.Text = "Sim";
                    visualiza.chkDadosClinicos6.Checked = true;
                }
                else
                {
                    visualiza.chkDadosClinicos6.Text = "Não";
                    visualiza.chkDadosClinicos6.Checked = false;
                }

                ////
                visualiza.chkDadosClinicos7.Text = modelo.dados_Clinicos7.ToString();

                if (visualiza.chkDadosClinicos7.Text == "True")
                {
                    visualiza.chkDadosClinicos7.Text = "Sim";
                    visualiza.chkDadosClinicos7.Checked = true;
                }
                else
                {
                    visualiza.chkDadosClinicos7.Text = "Não";
                    visualiza.chkDadosClinicos7.Checked = false;
                }

                ////
                visualiza.chkDadosClinicos8.Text = modelo.dados_Clinicos8.ToString();

                if (visualiza.chkDadosClinicos8.Text == "True")
                {
                    visualiza.chkDadosClinicos8.Text = "Sim";
                    visualiza.chkDadosClinicos8.Checked = true;
                }
                else
                {
                    visualiza.chkDadosClinicos8.Text = "Não";
                    visualiza.chkDadosClinicos8.Checked = false;
                }

                ////
                visualiza.chkDadosClinicos9.Text = modelo.dados_Clinicos9.ToString();

                if (visualiza.chkDadosClinicos9.Text == "True")
                {
                    visualiza.chkDadosClinicos9.Text = "Sim";
                    visualiza.chkDadosClinicos9.Checked = true;
                }
                else
                {
                    visualiza.chkDadosClinicos9.Text = "Não";
                    visualiza.chkDadosClinicos9.Checked = false;
                }

                ////
                visualiza.chkDadosClinicos10.Text = modelo.dados_Clinicos10.ToString();

                if (visualiza.chkDadosClinicos10.Text == "True")
                {
                    visualiza.chkDadosClinicos10.Text = "Sim";
                    visualiza.chkDadosClinicos10.Checked = true;
                }
                else
                {
                    visualiza.chkDadosClinicos10.Text = "Não";
                    visualiza.chkDadosClinicos10.Checked = false;
                }

                ////
                visualiza.chkDadosClinicos11.Text = modelo.dados_Clinicos11.ToString();

                if (visualiza.chkDadosClinicos11.Text == "True")
                {
                    visualiza.chkDadosClinicos11.Text = "Sim";
                    visualiza.chkDadosClinicos11.Checked = true;
                }
                else
                {
                    visualiza.chkDadosClinicos11.Text = "Não";
                    visualiza.chkDadosClinicos11.Checked = false;
                }

                ////
                visualiza.chkDadosClinicos12.Text = modelo.dados_Clinicos12.ToString();

                if (visualiza.chkDadosClinicos12.Text == "True")
                {
                    visualiza.chkDadosClinicos12.Text = "Sim";
                    visualiza.chkDadosClinicos12.Checked = true;
                }
                else
                {
                    visualiza.chkDadosClinicos12.Text = "Não";
                    visualiza.chkDadosClinicos12.Checked = false;
                }


                                        // Controlando a exibição das checkBoxes dos Objetivos:


                visualiza.chkObjetivo1.Text = modelo.Obj1.ToString();

                if (visualiza.chkObjetivo1.Text == "True")
                {
                    visualiza.chkObjetivo1.Text = "Sim";
                    visualiza.chkObjetivo1.Checked = true;
                }
                else
                {
                    visualiza.chkObjetivo1.Text = "Não";
                    visualiza.chkObjetivo1.Checked = false;
                }


                ////
                visualiza.chkObjetivo2.Text = modelo.Obj2.ToString();

                if (visualiza.chkObjetivo2.Text == "True")
                {
                    visualiza.chkObjetivo2.Text = "Sim";
                    visualiza.chkObjetivo2.Checked = true;
                }
                else
                {
                    visualiza.chkObjetivo2.Text = "Não";
                    visualiza.chkObjetivo2.Checked = false;
                }

                ////
                visualiza.chkObjetivo3.Text = modelo.Obj3.ToString();

                if (visualiza.chkObjetivo3.Text == "True")
                {
                    visualiza.chkObjetivo3.Text = "Sim";
                    visualiza.chkObjetivo3.Checked = true;
                }
                else
                {
                    visualiza.chkObjetivo3.Text = "Não";
                    visualiza.chkObjetivo3.Checked = false;
                }

                ////
                visualiza.chkObjetivo4.Text = modelo.Obj4.ToString();

                if (visualiza.chkObjetivo4.Text == "True")
                {
                    visualiza.chkObjetivo4.Text = "Sim";
                    visualiza.chkObjetivo4.Checked = true;
                }
                else
                {
                    visualiza.chkObjetivo4.Text = "Não";
                    visualiza.chkObjetivo4.Checked = false;
                }

                ////
                visualiza.chkObjetivo5.Text = modelo.Obj5.ToString();

                if (visualiza.chkObjetivo5.Text == "True")
                {
                    visualiza.chkObjetivo5.Text = "Sim";
                    visualiza.chkObjetivo5.Checked = true;
                }
                else
                {
                    visualiza.chkObjetivo5.Text = "Não";
                    visualiza.chkObjetivo5.Checked = false;
                }

                ////
                visualiza.chkObjetivo6.Text = modelo.Obj6.ToString();

                if (visualiza.chkObjetivo6.Text == "True")
                {
                    visualiza.chkObjetivo6.Text = "Sim";
                    visualiza.chkObjetivo6.Checked = true;
                }
                else
                {
                    visualiza.chkObjetivo6.Text = "Não";
                    visualiza.chkObjetivo6.Checked = false;
                }

                ////
                visualiza.chkObjetivo7.Text = modelo.Obj7.ToString();

                if (visualiza.chkObjetivo7.Text == "True")
                {
                    visualiza.chkObjetivo7.Text = "Sim";
                    visualiza.chkObjetivo7.Checked = true;
                }
                else
                {
                    visualiza.chkObjetivo7.Text = "Não";
                    visualiza.chkObjetivo7.Checked = false;
                }

                ////
                visualiza.chkObjetivo8.Text = modelo.Obj8.ToString();

                if (visualiza.chkObjetivo8.Text == "True")
                {
                    visualiza.chkObjetivo8.Text = "Sim";
                    visualiza.chkObjetivo8.Checked = true;
                }
                else
                {
                    visualiza.chkObjetivo8.Text = "Não";
                    visualiza.chkObjetivo8.Checked = false;
                }

                visualiza.txtRespDadoClinico12.Text = modelo.dados_Clinicos12Resp.ToString();


                visualiza.textObservacoes.Text = modelo.Observacoes.ToString();

                this.Hide();                
                visualiza.ShowDialog();
                this.Dispose();

            }
            else if (matricula == 0 && nAvaliacao == 0)
            {
                MessageBox.Show("Selecione seu cadastro depois clique em 'Abrir'", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                visualiza.Dispose(); // após o uso do form, esta função destroi o formulário para que não ocupe memória.
            }
            

            if (nAvaliacao != 0 && matricula == 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLAvaliacaoFisica bll2 = new BLLAvaliacaoFisica(cx);
                ModeloAvaliacaoFisica modelo = bll2.CarregaModeloAvaliacaoFisica(nAvaliacao);
                BLLSerie bll3 = new BLLSerie(cx);
                ModeloSerie modeloSerie = bll3.CarregaModeloSerie(nAvaliacao);

                visualizaAva.dataGVSerie.DataSource = bll3.Localizar(nAvaliacao); // Carrega série no dataGridView da tela de avaliação.

                visualizaAva.txtIdAvaliacao.Text = modelo.id_Avaliacao.ToString();
                visualizaAva.txtDataAvaliacao.Text = modelo.data_Avaliacao.ToString();
                visualizaAva.txtMatriculaAva.Text = modelo.id_Aluno.ToString();

                visualizaAva.txtTriceps.Text = modelo.Triceps.ToString();
                visualizaAva.txtAxilarMedia.Text = modelo.axilar_Media.ToString();
                visualizaAva.txtSubEscapular.Text = modelo.sub_Escapular.ToString();
                visualizaAva.txtSupraIliaca.Text = modelo.supra_Iliaca.ToString();
                visualizaAva.txtCoxa.Text = modelo.Coxa.ToString();
                visualizaAva.txtAbdominalDC.Text = modelo.abdominal_DC.ToString();
                visualizaAva.txtToraxDC.Text = modelo.torax_DC.ToString();
                visualizaAva.txtPercGordura.Text = modelo.perc_Gordura.ToString();

                visualizaAva.txtBracoRelaxadoDir.Text = modelo.bracoRelaxado_Dir.ToString();
                visualizaAva.txtBracoRelaxadoEsq.Text = modelo.bracoContraido_Esq.ToString();
                visualizaAva.txtBracoContraidoDir.Text = modelo.bracoContraido_Dir.ToString();
                visualizaAva.txtBracoContraidoEsq.Text = modelo.bracoContraido_Esq.ToString();
                visualizaAva.txtAntebracoDir.Text = modelo.anteBraco_Dir.ToString();
                visualizaAva.txtAntebracoEsq.Text = modelo.anteBraco_Esq.ToString();
                visualizaAva.txtCoxaDir.Text = modelo.coxa_Dir.ToString();
                visualizaAva.txtCoxaEsq.Text = modelo.coxa_Esq.ToString();
                visualizaAva.txtPernaDir.Text = modelo.perna_Dir.ToString();
                visualizaAva.txtPernaEsq.Text = modelo.perna_Esq.ToString();
                visualizaAva.txtToraxPerimetro.Text = modelo.torax_DC.ToString();
                visualizaAva.txtAbdominalPer.Text = modelo.abdominal_P.ToString();
                visualizaAva.txtPescoco.Text = modelo.Pescoco.ToString();
                visualizaAva.txtCintura.Text = modelo.Cintura.ToString();
                visualizaAva.txtQuadril.Text = modelo.Quadril.ToString();
                visualizaAva.txtRCQ.Text = modelo.RCQ.ToString();

                visualizaAva.txtFCR.Text = modelo.freqCardiaca_Rep.ToString();
                visualizaAva.txtFCM.Text = modelo.freqCardiaca_Max.ToString();
                visualizaAva.txtVO2.Text = modelo.Vo2.ToString();
                visualizaAva.txtPressaoArterial.Text = modelo.pressao_Arterial.ToString();
                visualizaAva.txtMassaMagra.Text = modelo.massa_Magra.ToString();
                visualizaAva.txtFlexaoBraco.Text = modelo.flexao_Braco.ToString();
                visualizaAva.txtPeso.Text = modelo.Peso.ToString();
                visualizaAva.txtAltura.Text = modelo.Altura.ToString();
                visualizaAva.txtIMC.Text = modelo.IMC.ToString();
                visualizaAva.txtFlexTest.Text = modelo.flex_Test.ToString();
                visualizaAva.txtForcaAbdominal.Text = modelo.forca_Abdominal.ToString();

                this.Hide();
                visualizaAva.ShowDialog();
                this.Dispose();
            }
            else if (nAvaliacao == 0 && matricula == 0)
            {
                MessageBox.Show("Selecione seu cadastro depois clique em 'Abrir'", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            visualiza.Dispose(); // após o uso do form, esta função destroi o formulário para que não ocupe memória.
        }
        

        public void telaListaAvaliacoes_Load(object sender, EventArgs e)
        {
            
            // Renomendo as colunas do DataGridView Cadastro:

            dgvCadastro.Columns[0].HeaderText = "Matrícula";
            dgvCadastro.Columns[1].HeaderText = "Nome";



            // Este trecho numera as linhas do DataGridView Cadastro:

            foreach (DataGridViewRow row in dgvCadastro.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
                row.Height = 20;

            }


            // Renomendo as colunas do DataGridView Avaliações:

            dgvLstAvaliacoes.Columns[0].HeaderText = "Cod. da Avaliação";
            dgvLstAvaliacoes.Columns[1].HeaderText = "Data da Avaliação";

            // Este trecho numera as linhas do DataGridView Avaliações:

            foreach (DataGridViewRow row in dgvLstAvaliacoes.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }

            
        }

        private void dgvLstAvaliacoes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }



        private void dgvCadastro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) //Caso a linha selecionada for maior ou igual a zero ele entra na condição.
            {
                // matricula recebe o valor da célula zero (matrícula do aluno) que será utilizada
                //para carregar o formulário de cadastro.

                this.matricula = Convert.ToInt32(dgvCadastro.Rows[e.RowIndex].Cells[0].Value);
                nAvaliacao = 0;
            }
        }

        // Botão responsável por excluir os registros selecionados.

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            telaInicial inicio = new telaInicial();
            telaVisualizacaoCadastro visualiza = new telaVisualizacaoCadastro();
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCadastro bll = new BLLCadastro(cx);
            BLLAvaliacaoFisica bll2 = new BLLAvaliacaoFisica(cx);


            // No estado atual, o sistema só pode excluir um aluno caso ele já não tenha avaliações cadastradas, isto por que se tentarmos
            // excluir o aluno diretamente haverá um erro indicando que existem relações dependentes da chave (matricula) deste aluno em
            // outras tabelas, neste caso nas tabelas série e avaliação física. É possível fazer essa operação, mas não atualmente (03/12/2016).


            if (matricula != 0 && dgvLstAvaliacoes.RowCount == 0)
            {
                if (MessageBox.Show("Deseja excluir este aluno?", "Aviso!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    bll.Excluir(matricula);

                    MessageBox.Show("O aluno selecionado foi excluído com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    inicio.ShowDialog();
                    this.Dispose();
 
                }                
                               
            }
            else if (matricula != 0 && dgvLstAvaliacoes.RowCount > 0)
            {
                MessageBox.Show("É preciso excluir as avaliações e depois o aluno.");
            }
            

            if (nAvaliacao != 0 && matricula == 0)
            {

                if (MessageBox.Show("Deseja excluir esta avaliação?", "Aviso!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){
                    
                    bll2.Excluir(nAvaliacao);
                                       
                    MessageBox.Show("A avaliação selecionada foi excluída com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    // Após excluir a avaliação selecionada, o sistema atualizará a tabela de avaliações para o status atual. Para recarregar as
                    // tabelas utilizamos o método Localizar da classe BLL e como parâmetro utilizamos a matrícula do aluno contida na primeira 
                    // coluna da primeira célula da tabela cadastro ('dgvCadastro.Rows[0].Cells[0]'):


                    dgvCadastro.DataSource = bll.Localizar(Convert.ToInt32(dgvCadastro.Rows[0].Cells[0].Value.ToString()));
                    dgvLstAvaliacoes.DataSource = bll2.Localizar(Convert.ToInt32(dgvCadastro.Rows[0].Cells[0].Value.ToString()));

                }
                                
            }

            else if (matricula == 0 && nAvaliacao == 0)
            {
                MessageBox.Show("Selecione o que deseja excluir depois clique em 'Excluir'.");
            }


        }

        private void telaListaAvaliacoes_FormClosed(object sender, FormClosedEventArgs e)
        {
            telaInicial tInicio = new telaInicial();
            this.Hide();
            tInicio.ShowDialog();
            this.Dispose();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }

        private void dgvLstAvaliacoes_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) //Caso a linha selecionada for maior ou igual a zero ele entra na condição.
            {
                // A variável nAvaliacao recebe o valor da célula zero (nº da avaliação) quando esta é selecionada através do click.

                this.nAvaliacao = Convert.ToInt32(dgvLstAvaliacoes.Rows[e.RowIndex].Cells[0].Value);

                lstAvaliacoes.Add(nAvaliacao); // >>> Adicionando valores à lista que conterá os resultados das avaliações. 

                lstNAvaliacoes.Add(Convert.ToInt32(e.RowIndex + 1)); // >>> Adicionando valores à lista que conterá os índices das avaliações selecionadas.

                matricula = 0;
            }

                lstAvaliacoes.Sort(); // >>>  Ordenando a lista em modo crescente para abrir a sequência correta no gráfico.
            
                lstNAvaliacoes.Sort(); // >>> Ordenando a lista cujos valores representarão os índices de cada avaliação.
                

        }


        private void dgvLstAvaliacoes_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
             
        }


        private void txtNovaAvaliacao_Click(object sender, EventArgs e)
        {
            telaNovaAvaliacao novaAvaliacao = new telaNovaAvaliacao();

            novaAvaliacao.matriculaDGV = Convert.ToInt32(dgvCadastro.Rows[0].Cells[0].Value.ToString());

            // Tratando-se de uma nova avaliação, pressupõe-se que já exista um aluno, logo, ao carregar o formulário de nova avaliação, os
            // textBoxes referentes a matrícula do aluno são carregados automaticamente e sem possibilidade de alteração:

            novaAvaliacao.txtMatriculaAva.Text = dgvCadastro.Rows[0].Cells[0].Value.ToString();
            novaAvaliacao.txtMatriculaSerie.Text = dgvCadastro.Rows[0].Cells[0].Value.ToString();

            this.Hide();
            novaAvaliacao.ShowDialog();
            this.Dispose();

        }


                                // Manipulando a exibição nos gráficos:


        private void btnGraficos_Click(object sender, EventArgs e)
        {
            telaGraficos graficos = new telaGraficos();
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLAvaliacaoFisica bll2 = new BLLAvaliacaoFisica(cx);

            graficos.matriculaDGV = Convert.ToInt32(dgvCadastro.Rows[0].Cells[0].Value.ToString());


            // Com a lista dos códigos das avaliações já ordenadas em modo crescente, as avaliações correspondentes a seus
            // respectivos códigos serão carregados em cada gráfico:
            
            
            foreach (int codAva in lstAvaliacoes)
            {                              

                // Carrega os dados das avaliações de acordo com o código da avaliação.

                ModeloAvaliacaoFisica modelo = bll2.CarregaModeloAvaliacaoFisica(codAva);

                // Carrega o gráfico do RCQ com as medidas e as datas das avaliações selecionadas por ordem cronológica:

                graficos.graficoRCQ.Series["Índice de RCQ"].Points.AddXY(lstNAvaliacoes[indice] + "ª Av.", modelo.RCQ);

                // Carrega o gráfico de percentual de gordura com as medidas e as datas das avaliações selecionadas por ordem cronológica:

                graficos.graficoPercGordura.Series["Índice de %G"].Points.AddXY(lstNAvaliacoes[indice] + "ª Av.", modelo.perc_Gordura);

                // Carrega o gráfico de massa magra com as medidas e as datas das avaliações selecionadas por ordem cronológicas:

                graficos.graficoMassaMagra.Series["Índice de Massa Magra"].Points.AddXY(lstNAvaliacoes[indice] + "ª Av.", modelo.massa_Magra);

                // Carrega o gráfico de VO2 com as medidas e as datas das avaliações selecionadas por ordem cronológica:

                graficos.graficoVO2.Series["Índice de VO2"].Points.AddXY(lstNAvaliacoes[indice] + "ª Av.", modelo.Vo2);

                // Carrega o gráfico de força abdominal com as medidas e as datas das avaliações selecionadas por ordem cronológica:

                graficos.graficoForcaAbdominal.Series["Índice de Força Abdominal"].Points.AddXY(lstNAvaliacoes[indice] + "ª Av.", modelo.forca_Abdominal);

                // Carrega o gráfico de força abdominal com as medidas e as datas das avaliações selecionadas por ordem cronológica:

                graficos.graficoFlexaoBraco.Series["Flexão de Braço"].Points.AddXY(lstNAvaliacoes[indice] + "ª Av.", modelo.flexao_Braco);

                // Carrega o gráfico de peso corporal com as medidas e as datas das avaliações selecionadas por ordem cronológica:

                graficos.graficoPesoCorporal.Series["Peso Corporal"].Points.AddXY(lstNAvaliacoes[indice] + "ª Av.", modelo.Peso);


                indice++; // O macete para que o gráfico indique a qual avaliação pertence cada resultado carregado, utilizamos uma variável
                // que será utilizada como índice de cada avaliação selecionada, lembrando que as avaliações serão carregadas em ordem
                // crescente pelo código da avaliação.
                
            }

            this.Hide();
            graficos.ShowDialog();            

        }


    }
}
