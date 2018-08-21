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
        List<Person> ListarTodosPerson()
        {
            AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();
            return contexto.Person.ToList();
        }

        Person BuscarPorID(int ID)
        {
            AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();

            return contexto.Person.Find(ID);
        }

        void Excluir(int ID)
        {

            Person pExcluir = BuscarPorID(ID);

            if (pExcluir != null)
            {
                AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();
                contexto.Person.Remove(pExcluir);
                contexto.SaveChanges();
            }

        }
        void editar (int id, Person novoDadosPerson)
            {
            Person personAntigo = BuscarPorID(ID);

            if(personAntigo != null)
            {
                personAntigo.FirstName = novoDadosPerson.FirstName;
                personAntigo.LastName = novoDadosPerson.LastName;
                personAntigo.Title = novoDadosPerson.Title;

                AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();
                contexto.Entry(personAntigo).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }

            }

        List<Person> PesquisarPorFirstName(string firstName)
        {
            AdventureWorks2016Entities contexto = new AdventureWorks2016Entities;
            //LINQ
            var lista = from p in contexto.Person
                       select p;//SELECT * FROM PERSON

            var lista = from p in contexto.Person
                        where p.FirstName == firstName
                        select p;//select * from (buscar por nome)
            return lista.ToList();


        }
    }
}
