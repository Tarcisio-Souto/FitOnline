using BLL;
using DAL;
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
    public partial class telaPedeMatricula : Form
    {
        
        public telaPedeMatricula()
        {
            InitializeComponent();            
        }

        private void telaPedeMatricula_Load(object sender, EventArgs e)
        {
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            String testeMat = "";
            int idAluno2 = 0;

            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCadastro bll = new BLLCadastro(cx);
            BLLAvaliacaoFisica bll2 = new BLLAvaliacaoFisica(cx);
            telaListaAvaliacoes telaLstAva = new telaListaAvaliacoes();
            telaPedeMatricula pedeMatricula = new telaPedeMatricula();
            DALCadastro matriculas = new DALCadastro(cx);

            
            testeMat = txtBoxPedeMat.Text;

            // Esta função abaixo, checa se o que tem no textBox txtBoxPedeMat.Text pode ser convertido para int e passa o valor para idAluno2.
            // Esta verificação é necessária, pois a matrícula é do tipo int, logo esta não aceita valor nulo (neste contexto), então, caso o usuário
            // não insira algum valor, o sistema irá tratar essa ocorrência nas condições seguintes.

            int.TryParse(testeMat, out idAluno2); // Caso não seja nulo, a variável idAluno2 recebe o valor de testeMat convertido em int.
                        
                        
            // Verifica se a matrícula fornecida existe no banco de dados através do método verificaMatricula usando como parâmetro a variável
            // idAluno2 que armazena o dado fornecido pelo usuário.

            if (matriculas.verificaMatricula(idAluno2) == true)
            {
                // Caso a matrícula exista, as tabelas da próxima tela (tela da lista de avaliações) serão carregadas através do método Localizar
                // que está na classe DALCadastro, utilizando, novamente, o idAluno para carregar as avaliações deste aluno especificamente.

                telaLstAva.dgvCadastro.DataSource = bll.Localizar(idAluno2);
                telaLstAva.dgvLstAvaliacoes.DataSource = bll2.Localizar(idAluno2);
                this.Hide();
                telaLstAva.ShowDialog();
            }

            // Se a matrícula não estiver cadastrada e o campo não estiver vazio, o sistema indica que o aluno não está cadastrado:

            else if (matriculas.verificaMatricula(idAluno2) == false && !String.IsNullOrWhiteSpace(testeMat))
            {
                MessageBox.Show("Aluno não cadastrado.");
            }

            // Se o campo de matrícula estiver vazio e o usuário clicou em 'ok', o sistema pede uma matrícula válida.

            if (String.IsNullOrWhiteSpace(testeMat))
            {
                MessageBox.Show("Informe uma matrícula válida.");
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            telaInicial tInicio = new telaInicial();
            this.Hide(); // Fecha este formulário.
            tInicio.ShowDialog();  // Carrega o formulário telaInicial.
        }

        private void telaPedeMatricula_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Caso este formulário seja fechado ( x ), o sistema carrega o forumulário telaInicial.

            telaInicial tInicio = new telaInicial();
            this.Hide();
            tInicio.ShowDialog();
            this.Dispose();
        }
    }
}
