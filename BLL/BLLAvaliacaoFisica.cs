using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLAvaliacaoFisica
    {
                
        private DALConexao conexao;
 

        public BLLAvaliacaoFisica(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloAvaliacaoFisica modelo)
        {

            DALAvaliacaoFisica DALobj = new DALAvaliacaoFisica(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloAvaliacaoFisica modelo)
        {
            DALAvaliacaoFisica DALobj = new DALAvaliacaoFisica(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(int id)
        {
            DALAvaliacaoFisica DALobj = new DALAvaliacaoFisica(conexao);
            DALobj.Excluir(id);
        }

        public DataTable Localizar(int valor)
        {
            DALAvaliacaoFisica DALobj = new DALAvaliacaoFisica(conexao);
            return DALobj.Localizar(valor);
        }

        public ModeloAvaliacaoFisica CarregaModeloAvaliacaoFisica(int id)
        {
            DALAvaliacaoFisica DALobj = new DALAvaliacaoFisica(conexao);
            return DALobj.CarregaModeloAvaliacaoFisica(id);
        }


    }
}
