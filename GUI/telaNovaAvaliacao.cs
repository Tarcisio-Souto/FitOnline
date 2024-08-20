using BLL;
using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class telaNovaAvaliacao : Form
    {

        public int auxMatricula = 0;
        public int auxIdade = 0;
        public char auxSexo;
        public int matriculaDGV = 0;


        public telaNovaAvaliacao()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

                                // Calcular RCQ:


        private void txtCintura_TextChanged_1(object sender, EventArgs e)
        {
            String strResultado = "";

            if (txtCintura.Text.Length > 0 && txtQuadril.Text.Length > 0)
            {

                // Macete para mostrar apenas duas casas decimais:

                strResultado = Convert.ToString(string.Format("{0:N}", (Convert.ToDouble(txtCintura.Text) / Convert.ToDouble(txtQuadril.Text))));
                txtRCQ.Text = string.Format("{0:N}", strResultado);
            }
            else
            {
                txtRCQ.Text = Convert.ToString(0);
            }
        }

        private void txtQuadril_TextChanged_1(object sender, EventArgs e)
        {
            String strResultado = "";

            if (txtCintura.Text.Length > 0 && txtQuadril.Text.Length > 0)
            {

                // Macete para mostrar apenas duas casas decimais:

                strResultado = Convert.ToString(string.Format("{0:N}", (Convert.ToDouble(txtCintura.Text) / Convert.ToDouble(txtQuadril.Text))));
                txtRCQ.Text = string.Format("{0:N}", strResultado);
            }
            else
            {
                txtRCQ.Text = Convert.ToString(0);
            }
        }


                                // Calculando o IMC:


        private void txtPeso_TextChanged_1(object sender, EventArgs e)
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

        private void txtAltura_TextChanged_1(object sender, EventArgs e)
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


                                // Calculando o Percentual de Gordura Corporal: 



        private void calculaPercGordura2()
        {

            auxMatricula = Convert.ToInt32(txtMatriculaAva.Text);

            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCadastro bll2 = new BLLCadastro(cx);
            ModeloCadastro modelo = bll2.CarregaModeloCadastro(auxMatricula);

            auxIdade = modelo.Idade;
            auxSexo = modelo.Sexo;

            double densidadeCorporal = 0;
            double auxPercGordura = 0;

            String strResultado = "";


            if (txtTriceps.Text.Length > 0 && txtAxilarMedia.Text.Length > 0
                && txtSubEscapular.Text.Length > 0 && txtSupraIliaca.Text.Length > 0 && txtCoxa.Text.Length > 0 && txtAbdominalDC.Text.Length > 0
                && txtToraxDC.Text.Length > 0)
            {

                int auxTriceps = Convert.ToInt32(txtTriceps.Text);
                int auxAxilarMedia = Convert.ToInt32(txtAxilarMedia.Text);
                int auxSubEscapular = Convert.ToInt32(txtSubEscapular.Text);
                int auxSupraIliaca = Convert.ToInt32(txtSupraIliaca.Text);
                int auxCoxa = Convert.ToInt32(txtCoxa.Text);
                int auxAbdominal = Convert.ToInt32(txtAbdominalDC.Text);
                int auxTorax = Convert.ToInt32(txtToraxDC.Text);

                int soma7Dobras = auxTriceps + auxAxilarMedia + auxSubEscapular + auxSupraIliaca + auxCoxa + auxAbdominal + auxTorax;


                if (auxSexo == Convert.ToChar("M"))
                {
                    densidadeCorporal = Convert.ToDouble(1.112 - (0.00043499 * soma7Dobras) + (0.00000055 * (Math.Pow(soma7Dobras, 2)) - (0.00028826 * auxIdade)));

                    auxPercGordura = Convert.ToDouble(((4.95 / densidadeCorporal) - 4.5) * 100);

                }
                else if (auxSexo == Convert.ToChar("F"))
                {
                    MessageBox.Show("Mulher");
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



        private void txtIMC_TextChanged(object sender, EventArgs e)
        {
            
        }


                                // Salvando os dados inseridos:


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            telaListaAvaliacoes telaLstAva = new telaListaAvaliacoes();
            ModeloAvaliacaoFisica variavelAvaliacao = new ModeloAvaliacaoFisica();
            ModeloSerie variavelSerie = new ModeloSerie();
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLAvaliacaoFisica bll2 = new BLLAvaliacaoFisica(cx);
            BLLSerie bll3 = new BLLSerie(cx);


            BLLCadastro bll = new BLLCadastro(cx);
            ModeloCadastro modelo = bll.CarregaModeloCadastro(Convert.ToInt32(txtMatriculaAva.Text));
            ModeloAvaliacaoFisica modeloAva = bll2.CarregaModeloAvaliacaoFisica(Convert.ToInt32(txtMatriculaAva.Text));

                        

            // Passando os dados da aba Avaliação Física:

            // Obs.: o idAvaliação não é passado pelo usuário, pois é auto-increment.


            // Dobras Cutâneas:


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

            variavelAvaliacao.Triceps = auxTriceps;
            variavelAvaliacao.axilar_Media = auxAxilarMedia;
            variavelAvaliacao.sub_Escapular = auxSubEspcapular;
            variavelAvaliacao.supra_Iliaca = auxSupraIliaca;
            variavelAvaliacao.Coxa = auxCoxa;
            variavelAvaliacao.abdominal_DC = auxAbdominalDC;
            variavelAvaliacao.torax_DC = auxToraxDC;
            variavelAvaliacao.perc_Gordura = auxPercGordura;

            variavelAvaliacao.data_Avaliacao = Convert.ToString(txtDataAvaliacao.Text);
            variavelAvaliacao.id_Aluno = Convert.ToInt32(txtMatriculaAva.Text);

           
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
            variavelSerie.id_Aluno = Convert.ToInt32(txtMatriculaAva.Text);
            variavelSerie.Texto = Convert.ToString(textoSerie.Text);

            bll3.Incluir(variavelSerie); // Incluindo os dados inseridos pelo usuário ao banco de dados.

            MessageBox.Show("Salvo com sucesso!");

            telaLstAva.dgvCadastro.DataSource = bll.Localizar(Convert.ToInt32(txtMatriculaAva.Text));
            telaLstAva.dgvLstAvaliacoes.DataSource = bll2.Localizar(Convert.ToInt32(txtMatriculaAva.Text));

            this.Hide();
            telaLstAva.ShowDialog();
            this.Dispose();
            
        }

        private void txtToraxDC_TextChanged(object sender, EventArgs e)
        {
            calculaPercGordura2();
        }

        private void txtAbdominalDC_TextChanged(object sender, EventArgs e)
        {
            calculaPercGordura2();
        }

        private void txtCoxa_TextChanged(object sender, EventArgs e)
        {
            calculaPercGordura2();
        }

        private void txtSupraIliaca_TextChanged(object sender, EventArgs e)
        {
            calculaPercGordura2();
        }

        private void txtSubEscapular_TextChanged(object sender, EventArgs e)
        {
            calculaPercGordura2();
        }

        private void txtAxilarMedia_TextChanged(object sender, EventArgs e)
        {
            calculaPercGordura2();
        }

        private void txtTriceps_TextChanged(object sender, EventArgs e)
        {
            calculaPercGordura2();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            telaListaAvaliacoes telaLstAva = new telaListaAvaliacoes();

            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCadastro bll = new BLLCadastro(cx);
            BLLAvaliacaoFisica bll2 = new BLLAvaliacaoFisica(cx);
            ModeloCadastro modelo = bll.CarregaModeloCadastro(matriculaDGV);
            ModeloAvaliacaoFisica modeloAva = bll2.CarregaModeloAvaliacaoFisica(matriculaDGV);

            telaLstAva.dgvCadastro.DataSource = bll.Localizar(matriculaDGV);
            telaLstAva.dgvLstAvaliacoes.DataSource = bll2.Localizar(matriculaDGV);

            this.Hide();
            telaLstAva.ShowDialog();
            this.Dispose();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
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

        
    }
}
