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

    /*
     * Esta classe representa a regra de negócio, onde os dados informados serão validados antes 
     * de serem gravados no banco de dados.
     *
    */

    public class BLLCadastro
    {
        private DALConexao conexao;
 

        public BLLCadastro(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloCadastro modelo)            
        {              
            
            DALCadastro DALobj = new DALCadastro(conexao);
            DALobj.Incluir(modelo);

        }

        public void Alterar(ModeloCadastro modelo)
        {
            
            DALCadastro DALobj = new DALCadastro(conexao);
            DALobj.Alterar(modelo);

        }

        public void Excluir(int id)
        {
            DALCadastro DALobj = new DALCadastro(conexao);
            DALobj.Excluir(id);
        }

        public DataTable Localizar(int valor)
        {
            DALCadastro DALobj = new DALCadastro(conexao);
            return DALobj.Localizar(valor);
        }

        public ModeloCadastro CarregaModeloCadastro(int id)
        {
            DALCadastro DALobj = new DALCadastro(conexao);
            return DALobj.CarregaModeloCadastro(id);
        }
    }
}
