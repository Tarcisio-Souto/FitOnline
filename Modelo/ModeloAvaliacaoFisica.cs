using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloAvaliacaoFisica
    {
        private int idAvaliacao = 0;

        public int id_Avaliacao
        {
            get { return this.idAvaliacao; }
            set { this.idAvaliacao = value; }
        }

        private String dataAvaliacao;

        public String data_Avaliacao
        {
            get { return this.dataAvaliacao; }
            set { this.dataAvaliacao = value; }
        }

        private int triceps = 0;
        
        public int Triceps
        {
            get { return this.triceps; }
            set { this.triceps = value; }

            //if (Convert.ToBoolean(triceps = Convert.ToInt32("")))
                //{
                //    triceps = 0;
                //}    


        }

        private int axilarMedia = 0;

        public int axilar_Media
        {
            get { return this.axilarMedia; }
            set { this.axilarMedia = value; }
        }

        private int subEscapular = 0;

        public int sub_Escapular
        {
            get { return this.subEscapular; }
            set { this.subEscapular = value; }
        }

        private int supraIliaca = 0;

        public int supra_Iliaca
        {
            get { return this.supraIliaca; }
            set { this.supraIliaca = value; }
        }

        private int coxa = 0;

        public int Coxa
        {
            get { return this.coxa; }
            set { this.coxa = value; }
        }

        private int abdominalDC = 0;

        public int abdominal_DC
        {
            get { return this.abdominalDC; }
            set { this.abdominalDC = value; }
        }

        private int toraxDC = 0;

        public int torax_DC
        {
            get { return this.toraxDC; }
            set { this.toraxDC = value; }
        }

        private double percGordura = 0;

        public double perc_Gordura
        {
            get { return this.percGordura; }
            set { this.percGordura = value; }
        }

        private double toraxP = 0;

        public double torax_P
        {
            get { return this.toraxP; }
            set { this.toraxP = value; }
        }

        private double abdominalP = 0;

        public double abdominal_P
        {
            get { return this.abdominalP; }
            set { this.abdominalP = value; }
        }

        private double cintura = 0;

        public double Cintura
        {
            get { return this.cintura; }
            set { this.cintura = value; }
        }

        private double quadril = 0;

        public double Quadril
        {
            get { return this.quadril; }
            set { this.quadril = value; }
        }

        private double pescoco = 0;

        public double Pescoco
        {
            get { return this.pescoco; }
            set { this.pescoco = value; }
        }

        private double bracoRelaxadoDir = 0;

        public double bracoRelaxado_Dir
        {
            get { return this.bracoRelaxadoDir; }
            set { this.bracoRelaxadoDir = value; }
        }

        private double bracoRelaxadoEsq = 0;

        public double bracoRelaxado_Esq
        {
            get { return this.bracoRelaxadoEsq; }
            set { this.bracoRelaxadoEsq = value; }
        }

        private double bracoContraidoDir = 0;

        public double bracoContraido_Dir
        {
            get { return this.bracoContraidoDir; }
            set { this.bracoContraidoDir = value; }
        }

        private double bracoContraidoEsq = 0;

        public double bracoContraido_Esq
        {
            get { return this.bracoContraidoEsq; }
            set { this.bracoContraidoEsq = value; }
        }

        private double anteBracoDir = 0;

        public double anteBraco_Dir
        {
            get { return this.anteBracoDir; }
            set { this.anteBracoDir = value; }
        }

        private double anteBracoEsq = 0;

        public double anteBraco_Esq
        {
            get { return this.anteBracoEsq; }
            set { this.anteBracoEsq = value; }
        }

        private double coxaDir = 0;

        public double coxa_Dir
        {
            get { return this.coxaDir; }
            set { this.coxaDir = value; }
        }

        private double coxaEsq = 0;

        public double coxa_Esq
        {
            get { return this.coxaEsq; }
            set { this.coxaEsq = value; }
        }

        private double pernaDir = 0;

        public double perna_Dir
        {
            get { return this.pernaDir; }
            set { this.pernaDir = value; }
        }

        private double pernaEsq = 0;

        public double perna_Esq
        {
            get { return this.pernaEsq; }
            set { this.pernaEsq = value; }
        }

        private double rcq = 0;

        public double RCQ
        {
            get { return this.rcq; }
            set { this.rcq = value; }
        }

        private double freqCardiacaRep = 0;

        public double freqCardiaca_Rep
        {
            get { return this.freqCardiacaRep; }
            set { this.freqCardiacaRep = value; }
        }

        private double freqCardiacaMax = 0;

        public double freqCardiaca_Max
        {
            get { return this.freqCardiacaMax; }
            set { this.freqCardiacaMax = value; }
        }

        private double peso = 0;

        public double Peso
        {
            get { return this.peso; }
            set { this.peso = value; }
        }

        private double massaMagra = 0;

        public double massa_Magra
        {
            get { return this.massaMagra; }
            set { this.massaMagra = value; }
        }

        private double flexTest = 0;

        public double flex_Test
        {
            get { return this.flexTest; }
            set { this.flexTest = value; }
        }

        private double altura = 0;

        public double Altura
        {
            get { return this.altura; }
            set { this.altura = value; }
        }

        private double flexaoBraco = 0;

        public double flexao_Braco
        {
            get { return this.flexaoBraco; }
            set { this.flexaoBraco = value; }
        }

        private double vo2 = 0;

        public double Vo2
        {
            get { return this.vo2; }
            set { this.vo2 = value; }
        }

        private double pressaoArterial = 0;

        public double pressao_Arterial
        {
            get { return this.pressaoArterial; }
            set { this.pressaoArterial = value; }
        }

        private double imc = 0;

        public double IMC
        {
            get { return this.imc; }
            set { this.imc = value; }
        }

        private double forcaAbdominal = 0;

        public double forca_Abdominal
        {
            get { return this.forcaAbdominal; }
            set { this.forcaAbdominal = value; }
        }

        private int idAluno = 0;

        public int id_Aluno
        {
            get { return this.idAluno; }
            set { this.idAluno = value; }
        }

    }
}
