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
    public partial class telaVisualizaSerie : Form
    {

        public int pedeIdSerie = 0;
        

        public telaVisualizaSerie()
        {
            InitializeComponent();

            textoSerie.Enabled = false;
            btnSalvar.Enabled = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            textoSerie.Enabled = true;
            btnSalvar.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            telaVisualizaAvaliacao visualizaAva = new telaVisualizaAvaliacao();
            int auxIdAva = Convert.ToInt32(txtIdAvaliacaoSerie.Text);
                        
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLSerie bll = new BLLSerie(cx);
            ModeloSerie modeloSerie = bll.CarregaModeloSerie(pedeIdSerie);
            BLLAvaliacaoFisica bll2 = new BLLAvaliacaoFisica(cx);
            ModeloAvaliacaoFisica modelo = bll2.CarregaModeloAvaliacaoFisica(auxIdAva);

            visualizaAva.dataGVSerie.DataSource = bll.Localizar(pedeIdSerie);

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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ModeloSerie variavelSerie = new ModeloSerie();
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLSerie bll = new BLLSerie(cx);          
            
            
            // Passando os dados da aba Série:

            // Obs.: o idSerie não é passado pelo usuário, pois é auto-increment.


            variavelSerie.id_Serie = Convert.ToInt32(txtIdSerie.Text);
            variavelSerie.id_Avaliacao = Convert.ToInt32(txtIdAvaliacaoSerie.Text); // Passando o valor da PK idAvaliacao auto-increment para a FK da tblSerie.
            variavelSerie.id_Aluno = Convert.ToInt32(txtMatriculaSerie.Text);
            variavelSerie.Texto = Convert.ToString(textoSerie.Text);

            bll.Alterar(variavelSerie); // Incluindo os dados inseridos pelo usuário ao banco de dados.

            MessageBox.Show("Salvo com sucesso!");

            textoSerie.Enabled = false;
            btnSalvar.Enabled = false;

        }
    }
}
