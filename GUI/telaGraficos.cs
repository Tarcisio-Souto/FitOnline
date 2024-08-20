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
    public partial class telaGraficos : Form
    {
        
        public int matriculaDGV = 0;


        public telaGraficos()
        {
            InitializeComponent();

        }

        private void graficoRCQ_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

            telaNovaAvaliacao novaAva = new telaNovaAvaliacao();
            telaListaAvaliacoes telaLstAva = new telaListaAvaliacoes();
            
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCadastro bll = new BLLCadastro(cx);
            BLLAvaliacaoFisica bll2 = new BLLAvaliacaoFisica(cx);

            telaLstAva.dgvCadastro.DataSource = bll.Localizar(matriculaDGV);
            telaLstAva.dgvLstAvaliacoes.DataSource = bll2.Localizar(matriculaDGV);

            this.Hide();
            telaLstAva.ShowDialog();
            this.Dispose();
        }

        private void btnAjuda_Click(object sender, EventArgs e)
        {
            telaParametros parametros = new telaParametros();

            parametros.ShowDialog();

        }
    }
}
