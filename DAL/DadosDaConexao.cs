using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{

    // Este namespace retorna a string de conexão com o banco de dados, possibilitando o acesso à ele.

    public class DadosDaConexao
    {
        public static String StringDeConexao
        {
            get
            {
                return "Data Source=VH-NT-TI-01\\SQLEXPRESS;Initial Catalog=FitOnline;Integrated Security=True";
            }
        }
    }
}
