using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1608Empitity2.Controllers
{
    class PersonController
    {

        void inserir(Person p)
        {
            AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();

            contexto.Person.Add(p);
            contexto.SaveChanges();

        }

        List<Person> ListarTodoPerson()
        {
            AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();
            return contexto.Person.ToList();

        }


    }
}
