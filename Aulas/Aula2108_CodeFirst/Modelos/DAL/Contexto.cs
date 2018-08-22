using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2108_CodeFirst.Modelos.DAL
{
    //herdar do dbcontexto
    public class Contexto : DbContext
    {
        public Contexto() : base("nomeStringConexao")
        {

        }
    }
}
