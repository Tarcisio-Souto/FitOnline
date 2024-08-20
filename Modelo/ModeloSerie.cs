using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloSerie
    {
        private int idSerie;

        public int id_Serie
        {
            get { return this.idSerie; }
            set { this.idSerie = value; }
        }

        private int idAluno;

        public int id_Aluno
        {
            get { return this.idAluno; }
            set { this.idAluno = value; }
        }

        private int idAvaliacao;

        public int id_Avaliacao
        {
            get { return this.idAvaliacao; }
            set { this.idAvaliacao = value; }
        }

        private String texto;

        public String Texto
        {
            get { return this.texto; }
            set { this.texto = value; }
        }
    }
}
