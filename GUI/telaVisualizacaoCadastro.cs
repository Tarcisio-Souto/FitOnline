using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;
using Modelo;

namespace GUI
{
    public partial class telaVisualizacaoCadastro : Form
    {

        public int matriculaDGV = 0;


        public telaVisualizacaoCadastro()
        {             
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            // Desabilitando os textBoxes dos Dados Cadastrais:

            txtMatricula.Enabled = false;
            txtIdade.Enabled = false;
            txtSexo.Enabled = false;
            txtNome.Enabled = false;
            txtDataNascimento.Enabled = false;
            txtTelefone.Enabled = false;
            txtCelular.Enabled = false;
            txtTipoSanguineo.Enabled = false;
            txtEmail.Enabled = false;
            txtEndereco.Enabled = false;
            txtBairro.Enabled = false;
            txtComplemento.Enabled = false;
            txtCidade.Enabled = false;
            txtUF.Enabled = false;
            txtCEP.Enabled = false;

            // Desabilitando os checkBoxes dos Dados Clínicos:

            chkTeste.Enabled = false;
            chkDadosClinicos2.Enabled = false;
            chkDadosClinicos3.Enabled = false;
            chkDadosClinicos4.Enabled = false;
            chkDadosClinicos5.Enabled = false;
            chkDadosClinicos6.Enabled = false;
            chkDadosClinicos7.Enabled = false;
            chkDadosClinicos8.Enabled = false;
            chkDadosClinicos9.Enabled = false;
            chkDadosClinicos10.Enabled = false;
            chkDadosClinicos11.Enabled = false;
            chkDadosClinicos12.Enabled = false;
            txtRespDadoClinico12.Enabled = false;

            // Desabilitando os checkBoxes dos Objetivos:

            chkObjetivo1.Enabled = false;
            chkObjetivo2.Enabled = false;
            chkObjetivo3.Enabled = false;
            chkObjetivo4.Enabled = false;
            chkObjetivo5.Enabled = false;
            chkObjetivo6.Enabled = false;
            chkObjetivo7.Enabled = false;
            chkObjetivo8.Enabled = false;

            // Desabilitando o campo de texto Observações e o botão Salvar:
            
            textObservacoes.Enabled = false;
            btnSalvar.Enabled = false;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void txtMatricula_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            txtMatricula.Enabled = false; // A matrícula não pode ser alterada, portanto ficará sempre desabilitada.

            // Habilitando os textBoxes dos Dados Cadastrais:

            txtIdade.Enabled = true;
            txtSexo.Enabled = true;
            txtNome.Enabled = true;
            txtDataNascimento.Enabled = true;
            txtTelefone.Enabled = true;
            txtCelular.Enabled = true;
            txtTipoSanguineo.Enabled = true;
            txtEmail.Enabled = true;
            txtEndereco.Enabled = true;
            txtBairro.Enabled = true;
            txtComplemento.Enabled = true;
            txtCidade.Enabled = true;
            txtUF.Enabled = true;
            txtCEP.Enabled = true;

            // Habilitando os checkBoxes dos Dados Clínicos:

            chkTeste.Enabled = true;
            chkDadosClinicos2.Enabled = true;
            chkDadosClinicos3.Enabled = true;
            chkDadosClinicos4.Enabled = true;
            chkDadosClinicos5.Enabled = true;
            chkDadosClinicos6.Enabled = true;
            chkDadosClinicos7.Enabled = true;
            chkDadosClinicos8.Enabled = true;
            chkDadosClinicos9.Enabled = true;
            chkDadosClinicos10.Enabled = true;
            chkDadosClinicos11.Enabled = true;
            chkDadosClinicos12.Enabled = true;
            txtRespDadoClinico12.Enabled = true;

            // Habilitando os checkBoxes dos Objetivos:

            chkObjetivo1.Enabled = true;
            chkObjetivo2.Enabled = true;
            chkObjetivo3.Enabled = true;
            chkObjetivo4.Enabled = true;
            chkObjetivo5.Enabled = true;
            chkObjetivo6.Enabled = true;
            chkObjetivo7.Enabled = true;
            chkObjetivo8.Enabled = true;

            // Habilitando o campo de texto Observações e o botão Salvar:

            textObservacoes.Enabled = true;
            btnSalvar.Enabled = true;

        }

        public void telaVisualizacaoCadastro_Load(object sender, EventArgs e)
        {
            // Desabilitando os textBoxes dos Dados Cadastrais:

            txtMatricula.Enabled = false;
            txtIdade.Enabled = false;
            txtSexo.Enabled = false;
            txtNome.Enabled = false;
            txtDataNascimento.Enabled = false;
            txtTelefone.Enabled = false;
            txtCelular.Enabled = false;
            txtTipoSanguineo.Enabled = false;
            txtEmail.Enabled = false;
            txtEndereco.Enabled = false;
            txtBairro.Enabled = false;
            txtComplemento.Enabled = false;
            txtCidade.Enabled = false;
            txtUF.Enabled = false;
            txtCEP.Enabled = false;

            // Desabilitando os checkBoxes dos Dados Clínicos:

            chkTeste.Enabled = false;
            chkDadosClinicos2.Enabled = false;
            chkDadosClinicos3.Enabled = false;
            chkDadosClinicos4.Enabled = false;
            chkDadosClinicos5.Enabled = false;
            chkDadosClinicos6.Enabled = false;
            chkDadosClinicos7.Enabled = false;
            chkDadosClinicos8.Enabled = false;
            chkDadosClinicos9.Enabled = false;
            chkDadosClinicos10.Enabled = false;
            chkDadosClinicos11.Enabled = false;
            chkDadosClinicos12.Enabled = false;
            txtRespDadoClinico12.Enabled = false;

            // Desabilitando os checkBoxes dos Objetivos:

            chkObjetivo1.Enabled = false;
            chkObjetivo2.Enabled = false;
            chkObjetivo3.Enabled = false;
            chkObjetivo4.Enabled = false;
            chkObjetivo5.Enabled = false;
            chkObjetivo6.Enabled = false;
            chkObjetivo7.Enabled = false;
            chkObjetivo8.Enabled = false;

            // Desabilitando o campo de texto Observações e o botão Salvar:

            textObservacoes.Enabled = false;
            btnSalvar.Enabled = false;

        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
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

        private void telaVisualizacaoCadastro_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {

            try
            {
                //NÃO ALTERA A MATRÍCULA DO ALUNO!!!   

                telaListaAvaliacoes telaLstAva = new telaListaAvaliacoes();

                int intMat = Convert.ToInt32(telaLstAva.matricula);
                System.Console.WriteLine("intMat: " + intMat);
                ModeloCadastro variavel = new ModeloCadastro();
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCadastro bll = new BLLCadastro(cx);

                // Salvando os Dados Cadastrais:        

                
                
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

                    variavel.tipo_Sangue = Convert.ToString(txtTipoSanguineo.Text);


                variavel.Email = Convert.ToString(txtEmail.Text);
                variavel.Endereco = Convert.ToString(txtEndereco.Text);
                variavel.Bairro = Convert.ToString(txtBairro.Text);
                variavel.Complemento = Convert.ToString(txtComplemento.Text);
                variavel.Cidade = Convert.ToString(txtCidade.Text);
                variavel.Uf = Convert.ToString(txtUF.Text);
                variavel.CEP = Convert.ToString(txtCEP.Text);

                // Salvando os Dados Clínicos:  

                variavel.dados_Clinicos1 = Convert.ToBoolean(chkTeste.Checked ? true : false);
                variavel.dados_Clinicos2 = Convert.ToBoolean(chkDadosClinicos2.Checked ? true : false);
                variavel.dados_Clinicos3 = Convert.ToBoolean(chkDadosClinicos3.Checked ? true : false);
                variavel.dados_Clinicos4 = Convert.ToBoolean(chkDadosClinicos4.Checked ? true : false);
                variavel.dados_Clinicos5 = Convert.ToBoolean(chkDadosClinicos5.Checked ? true : false);
                variavel.dados_Clinicos6 = Convert.ToBoolean(chkDadosClinicos6.Checked ? true : false);
                variavel.dados_Clinicos7 = Convert.ToBoolean(chkDadosClinicos7.Checked ? true : false);
                variavel.dados_Clinicos8 = Convert.ToBoolean(chkDadosClinicos8.Checked ? true : false);
                variavel.dados_Clinicos9 = Convert.ToBoolean(chkDadosClinicos9.Checked ? true : false);
                variavel.dados_Clinicos10 = Convert.ToBoolean(chkDadosClinicos10.Checked ? true : false);
                variavel.dados_Clinicos11 = Convert.ToBoolean(chkDadosClinicos11.Checked ? true : false);
                variavel.dados_Clinicos12 = Convert.ToBoolean(chkDadosClinicos12.Checked ? true : false);
                variavel.dados_Clinicos12Resp = Convert.ToString(txtRespDadoClinico12.Text);

                // Salvando os Objetivos:  

                variavel.Obj1 = Convert.ToBoolean(chkObjetivo1.Checked ? true : false);
                variavel.Obj2 = Convert.ToBoolean(chkObjetivo2.Checked ? true : false);
                variavel.Obj3 = Convert.ToBoolean(chkObjetivo3.Checked ? true : false);
                variavel.Obj4 = Convert.ToBoolean(chkObjetivo4.Checked ? true : false);
                variavel.Obj5 = Convert.ToBoolean(chkObjetivo5.Checked ? true : false);
                variavel.Obj6 = Convert.ToBoolean(chkObjetivo6.Checked ? true : false);
                variavel.Obj7 = Convert.ToBoolean(chkObjetivo7.Checked ? true : false);
                variavel.Obj8 = Convert.ToBoolean(chkObjetivo8.Checked ? true : false);

                // Salvando o campo de Observações:

                variavel.Observacoes = Convert.ToString(textObservacoes.Text);

                bll.Alterar(variavel); // Efetiva a inclusão dos dados ao banco.                       
                
                MessageBox.Show("Salvo com sucesso!");


                // Chamando o método btnSalvar_Click para desabilitar os botões após salvar: 

                btnSalvar_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
                      
        }

        private void chkTeste_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void textObservacoes_TextChanged(object sender, EventArgs e)
        {

        }

        private void textObservacoes_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textObservacoes_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtTipoSanguineo_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
