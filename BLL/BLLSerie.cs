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
    public class BLLSerie
    {
        private DALConexao conexao;
 

        public BLLSerie(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloSerie modelo)
        {            
            DALSerie DALobj = new DALSerie(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloSerie modelo)
        {
            DALSerie DALobj = new DALSerie(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(int id)
        {
            DALSerie DALobj = new DALSerie(conexao);
            DALobj.Excluir(id);
        }

        public DataTable Localizar(int valor)
        {
            DALSerie DALobj = new DALSerie(conexao);
            return DALobj.Localizar(valor);
        }

        public ModeloSerie CarregaModeloSerie(int id)
        {
            DALSerie DALobj = new DALSerie(conexao);
            return DALobj.CarregaModeloSerie(id);
        }
    }
}
