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
using System.Data.SqlClient;
using GUI;

namespace GUI
{
    public partial class telaInicial : Form
    {
        public telaInicial()
        {
            InitializeComponent();
        }

        
        private void btnNovoAluno_Click(object sender, EventArgs e)
        {
            
            telaCadastroEAvaliacao1 telaCadAva = new telaCadastroEAvaliacao1();
            this.Hide(); // Fecha a tela anterior que poderá ser 'resgatada' novamente.
            telaCadAva.ShowDialog(); // chama a nova tela.  
            this.Dispose(); // "Destrói" o formulário para que este não continue ocupando espaço na memória.                      
        
        }

        // Este método é responsável por pesquisar o aluno através da matrícula. Isto será feito através de uma
        // consulta ao banco de dados que será realizada no formulário seguinte, i.e., telaPedeMatricula.

        private void btnPesquisarAluno_Click(object sender, EventArgs e)
        {
            telaPedeMatricula pedeMatricula = new telaPedeMatricula();
            this.Hide();
            pedeMatricula.ShowDialog();
            this.Dispose();
            
        }

        private void telaInicial_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Esta função "Application.ExitThread()" está sendo utilizada para encerrar, definitivamente, todos os
            // processos desta aplicação quando o usuário fechar ( x ) este formulário.

            Application.ExitThread();
        }

        private void telaInicial_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
