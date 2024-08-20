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
    public partial class telaVisualizaAvaliacao : Form
    {

        public int auxMatricula = 0;
        public int auxIdade = 0;
        public int auxSerie = 0;
        public char auxSexo;


        public telaVisualizaAvaliacao()
        {
            InitializeComponent();
        }

        public void btnSalvar_Click(object sender, EventArgs e)
        {

            ModeloAvaliacaoFisica variavel = new ModeloAvaliacaoFisica();
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLAvaliacaoFisica bll = new BLLAvaliacaoFisica(cx);

            variavel.id_Avaliacao = Convert.ToInt32(txtIdAvaliacao.Text);
            variavel.data_Avaliacao = Convert.ToString(txtDataAvaliacao.Text);
            variavel.id_Aluno = Convert.ToInt32(txtMatriculaAva.Text);

            
            variavel.Triceps = Convert.ToInt32(txtTriceps.Text);
            variavel.axilar_Media = Convert.ToInt32(txtAxilarMedia.Text);
            variavel.sub_Escapular = Convert.ToInt32(txtSubEscapular.Text);
            variavel.supra_Iliaca = Convert.ToInt32(txtSupraIliaca.Text);
            variavel.Coxa = Convert.ToInt32(txtCoxa.Text);
            variavel.abdominal_DC = Convert.ToInt32(txtAbdominalDC.Text);
            variavel.torax_DC = Convert.ToInt32(txtToraxDC.Text);
            variavel.perc_Gordura = Convert.ToDouble(txtPercGordura.Text);

            variavel.bracoRelaxado_Dir = Convert.ToDouble(txtBracoRelaxadoDir.Text);
            variavel.bracoRelaxado_Esq = Convert.ToDouble(txtBracoRelaxadoEsq.Text);
            variavel.bracoContraido_Dir = Convert.ToDouble(txtBracoContraidoDir.Text);
            variavel.bracoContraido_Esq = Convert.ToDouble(txtBracoContraidoEsq.Text);
            variavel.anteBraco_Dir = Convert.ToDouble(txtAntebracoDir.Text);
            variavel.anteBraco_Esq = Convert.ToDouble(txtAntebracoEsq.Text);
            variavel.coxa_Dir = Convert.ToDouble(txtCoxaDir.Text);
            variavel.coxa_Esq = Convert.ToDouble(txtCoxaEsq.Text);
            variavel.perna_Dir = Convert.ToDouble(txtPernaDir.Text);
            variavel.perna_Esq = Convert.ToDouble(txtPernaEsq.Text);
            variavel.torax_P = Convert.ToDouble(txtToraxPerimetro.Text);
            variavel.abdominal_P = Convert.ToDouble(txtAbdominalPer.Text);
            variavel.Pescoco = Convert.ToDouble(txtPescoco.Text);
            variavel.Cintura = Convert.ToDouble(txtCintura.Text);
            variavel.Quadril = Convert.ToDouble(txtQuadril.Text);
            variavel.RCQ = Convert.ToDouble(txtRCQ.Text);


            variavel.freqCardiaca_Rep = Convert.ToDouble(txtFCR.Text);
            variavel.freqCardiaca_Max = Convert.ToDouble(txtFCM.Text);
            variavel.Vo2 = Convert.ToDouble(txtVO2.Text);
            variavel.pressao_Arterial = Convert.ToDouble(txtPressaoArterial.Text);
            variavel.massa_Magra = Convert.ToDouble(txtMassaMagra.Text);
            variavel.flexao_Braco = Convert.ToDouble(txtFlexaoBraco.Text);
            variavel.Peso = Convert.ToDouble(txtPeso.Text);
            variavel.Altura = Convert.ToDouble(txtAltura.Text);
            variavel.IMC = Convert.ToDouble(txtIMC.Text);
            variavel.flex_Test = Convert.ToDouble(txtFlexTest.Text);
            variavel.forca_Abdominal = Convert.ToDouble(txtForcaAbdominal.Text);

            bll.Alterar(variavel); // Efetiva a inclusão dos dados ao banco.                       
            MessageBox.Show("Salvo com sucessooo!");

            // Torna os campos inabilitados novamente.

            txtIdAvaliacao.Enabled = false;
            txtDataAvaliacao.Enabled = false;
            txtMatriculaAva.Enabled = false;


            txtTriceps.Enabled = false;
            txtAxilarMedia.Enabled = false;
            txtSubEscapular.Enabled = false;
            txtSupraIliaca.Enabled = false;
            txtCoxa.Enabled = false;
            txtAbdominalDC.Enabled = false;
            txtToraxDC.Enabled = false;
            txtPercGordura.Enabled = false;


            txtBracoRelaxadoDir.Enabled = false;
            txtBracoRelaxadoEsq.Enabled = false;
            txtBracoContraidoDir.Enabled = false;
            txtBracoContraidoEsq.Enabled = false;
            txtAntebracoDir.Enabled = false;
            txtAntebracoEsq.Enabled = false;
            txtCoxaDir.Enabled = false;
            txtCoxaEsq.Enabled = false;
            txtPernaDir.Enabled = false;
            txtPernaEsq.Enabled = false;
            txtToraxPerimetro.Enabled = false;
            txtAbdominalPer.Enabled = false;
            txtPescoco.Enabled = false;
            txtCintura.Enabled = false;
            txtQuadril.Enabled = false;
            txtRCQ.Enabled = false;
            
            txtFCR.Enabled = false;
            txtFCM.Enabled = false;
            txtVO2.Enabled = false;
            txtPressaoArterial.Enabled = false;
            txtMassaMagra.Enabled = false;
            txtFlexaoBraco.Enabled = false;
            txtPeso.Enabled = false;
            txtAltura.Enabled = false;
            txtIMC.Enabled = false;
            txtFlexTest.Enabled = false;
            txtForcaAbdominal.Enabled = false;


        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            txtIdAvaliacao.Enabled = false;
            txtDataAvaliacao.Enabled = true;
            txtMatriculaAva.Enabled = false;

            txtTriceps.Enabled = true;
            txtAxilarMedia.Enabled = true;
            txtSubEscapular.Enabled = true;
            txtSupraIliaca.Enabled = true;
            txtCoxa.Enabled = true;
            txtAbdominalDC.Enabled = true;
            txtToraxDC.Enabled = true;
            txtPercGordura.Enabled = false;


            txtBracoRelaxadoDir.Enabled = true;
            txtBracoRelaxadoEsq.Enabled = true;
            txtBracoContraidoDir.Enabled = true;
            txtBracoContraidoEsq.Enabled = true;
            txtAntebracoDir.Enabled = true;
            txtAntebracoEsq.Enabled = true;
            txtCoxaDir.Enabled = true;
            txtCoxaEsq.Enabled = true;
            txtPernaDir.Enabled = true;
            txtPernaEsq.Enabled = true;
            txtToraxPerimetro.Enabled = true;
            txtAbdominalPer.Enabled = true;
            txtPescoco.Enabled = true;
            txtCintura.Enabled = true;
            txtQuadril.Enabled = true;
            txtRCQ.Enabled = false;

            txtFCR.Enabled = true;
            txtFCM.Enabled = true;
            txtVO2.Enabled = true;
            txtPressaoArterial.Enabled = true;
            txtMassaMagra.Enabled = false;
            txtFlexaoBraco.Enabled = true;
            txtPeso.Enabled = true;
            txtAltura.Enabled = true;
            txtIMC.Enabled = false;
            txtFlexTest.Enabled = true;
            txtForcaAbdominal.Enabled = true;


        }

        private void telaVisualizaAvaliacao_Load(object sender, EventArgs e)
        {

            statusInicialItens();

            dataGVSerie.Columns[0].HeaderText = "Cod. Série"; // Renomeando a coluna do DataGridView.

            // Este trecho numera as linhas do DataGridView:

            foreach (DataGridViewRow row in dataGVSerie.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();                
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            int testeMat = Convert.ToInt32(txtMatriculaAva.Text);

            telaListaAvaliacoes telaLstAva = new telaListaAvaliacoes();
                                    
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCadastro bll = new BLLCadastro(cx);
            BLLAvaliacaoFisica bll2 = new BLLAvaliacaoFisica(cx);
            ModeloCadastro modelo = bll.CarregaModeloCadastro(testeMat);
            ModeloAvaliacaoFisica modeloAva = bll2.CarregaModeloAvaliacaoFisica(testeMat);
            
            telaLstAva.dgvCadastro.DataSource = bll.Localizar(testeMat);
            telaLstAva.dgvLstAvaliacoes.DataSource = bll2.Localizar(testeMat);
            
            this.Hide();
            telaLstAva.ShowDialog();
            this.Dispose();
              
        }

        private void dataGVSerie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void statusInicialItens()
        {
            txtIdAvaliacao.Enabled = false;
            txtDataAvaliacao.Enabled = false;
            txtMatriculaAva.Enabled = false;

            txtTriceps.Enabled = false;
            txtAxilarMedia.Enabled = false;
            txtSubEscapular.Enabled = false;
            txtSupraIliaca.Enabled = false;
            txtCoxa.Enabled = false;
            txtAbdominalDC.Enabled = false;
            txtToraxDC.Enabled = false;
            txtPercGordura.Enabled = false;


            txtBracoRelaxadoDir.Enabled = false;
            txtBracoRelaxadoEsq.Enabled = false;
            txtBracoContraidoDir.Enabled = false;
            txtBracoContraidoEsq.Enabled = false;
            txtAntebracoDir.Enabled = false;
            txtAntebracoEsq.Enabled = false;
            txtCoxaDir.Enabled = false;
            txtCoxaEsq.Enabled = false;
            txtPernaDir.Enabled = false;
            txtPernaEsq.Enabled = false;
            txtToraxPerimetro.Enabled = false;
            txtAbdominalPer.Enabled = false;
            txtPescoco.Enabled = false;
            txtCintura.Enabled = false;
            txtQuadril.Enabled = false;
            txtRCQ.Enabled = false;

            txtFCR.Enabled = false;
            txtFCM.Enabled = false;
            txtVO2.Enabled = false;
            txtPressaoArterial.Enabled = false;
            txtMassaMagra.Enabled = false;
            txtFlexaoBraco.Enabled = false;
            txtPeso.Enabled = false;
            txtAltura.Enabled = false;
            txtIMC.Enabled = false;
            txtFlexTest.Enabled = false;
            txtForcaAbdominal.Enabled = false;
        }


                                // Calcular RCQ:


        private void txtCintura_TextChanged(object sender, EventArgs e)
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

        private void txtQuadril_TextChanged(object sender, EventArgs e)
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

        private void txtRCQ_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPeso_TextChanged(object sender, EventArgs e)
        {
            calculaMassaMagra();

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

                                // Calculando o Percentual de Gordura Corporal:                        


        private void calculoPercGordura()
        {
            String strResultado = "";
            double densidadeCorporal = 0;
            double auxPercGordura = 0;


            auxMatricula = Convert.ToInt32(txtMatriculaAva.Text);

            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCadastro bll2 = new BLLCadastro(cx);
            ModeloCadastro modelo = bll2.CarregaModeloCadastro(auxMatricula);

            auxIdade = modelo.Idade; // Nesta tela de visualização de cadastro não há possibilidade de  pegarmos a idade ou sexo do aluno para usarmos
            auxSexo = modelo.Sexo;   // nas equações, pois não há a aba de cadastro para obtermos estes dados, sendo assim, foi preciso utilizar o método 
                                     // CarregaModeloCadastro para obtermos estes dois dados.
            

            //if (auxIdade != 0 && auxSexo != 0 && txtTriceps.Text.Length > 0 && txtAxilarMedia.Text.Length > 0 && txtSubEscapular.Text.Length > 0
                //&& txtSupraIliaca.Text.Length > 0 && txtCoxa.Text.Length > 0 && txtAbdominalDC.Text.Length > 0 && txtToraxDC.Text.Length > 0)


            if (auxIdade != 0 && auxSexo != 0 && txtTriceps.Text.Length > 0 && txtAxilarMedia.Text.Length > 0 && txtSubEscapular.Text.Length > 0
                && txtSupraIliaca.Text.Length > 0 && txtCoxa.Text.Length > 0 && txtAbdominalDC.Text.Length > 0 && txtToraxDC.Text.Length > 0)
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

        private void dataGVSerie_DoubleClick(object sender, EventArgs e)
        {
            
            auxSerie = Convert.ToInt32(dataGVSerie.Rows[0].Cells[0].Value);            
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLSerie bll2 = new BLLSerie(cx);
            ModeloSerie modelo = bll2.CarregaModeloSerie(auxSerie);
            telaVisualizaSerie visualizaSerie = new telaVisualizaSerie();

            visualizaSerie.pedeIdSerie = Convert.ToInt32(dataGVSerie.Rows[0].Cells[0].Value);

            visualizaSerie.txtIdSerie.Text = modelo.id_Serie.ToString();
            visualizaSerie.txtIdAvaliacaoSerie.Text = modelo.id_Avaliacao.ToString();
            visualizaSerie.txtMatriculaSerie.Text = modelo.id_Aluno.ToString();
            visualizaSerie.textoSerie.Text = modelo.Texto.ToString();

            this.Hide();
            visualizaSerie.ShowDialog();
            this.Dispose();

        }

        private void txtTriceps_TextChanged(object sender, EventArgs e)
        {
            calculoPercGordura();
        }

        private void txtAxilarMedia_TextChanged(object sender, EventArgs e)
        {
            calculoPercGordura();
        }

        private void txtSubEscapular_TextChanged(object sender, EventArgs e)
        {
            calculoPercGordura();
        }

        private void txtSupraIliaca_TextChanged(object sender, EventArgs e)
        {
            calculoPercGordura();
        }

        private void txtCoxa_TextChanged(object sender, EventArgs e)
        {
            calculoPercGordura();
        }

        private void txtAbdominalDC_TextChanged(object sender, EventArgs e)
        {
            calculoPercGordura();
        }

        private void txtToraxDC_TextChanged(object sender, EventArgs e)
        {
            calculoPercGordura();
        }

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

        private void txtPercGordura_TextChanged(object sender, EventArgs e)
        {
            calculaMassaMagra();
        }


    }
}
