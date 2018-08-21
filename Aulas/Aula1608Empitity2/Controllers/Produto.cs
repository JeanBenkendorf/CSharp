using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1608Empitity2.Controllers
{
    class Produto
    {
        void inserir(Product p)
        {
            AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();

            contexto.Product.Add(p);
            contexto.SaveChanges();
         }
        List<Product> ListarTodosProduct()
        {
            AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();
            return contexto.Product.ToList();
        }
        Product BuscarPorId (int id)
        {
            AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();
            return contexto.Product.Find();
        }
        void Excluir(int id)
        {
            Product pExcluir = BuscarPorId(id);

            if (pExcluir != null)

            {
                AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();
                contexto.Product.Remove(pExcluir);
                contexto.SaveChanges();
    
            }
            void editar (int id, Product NovoDadosProduct)
            {
                Product ProductAntigo = BuscarPorId(id);
                if( ProductAntigo != null)
                {
                    ProductAntigo.Name = NovoDadosProduct.Name;
                    ProductAntigo.Color = NovoDadosProduct.Color;
                    ProductAntigo.Class = NovoDadosProduct.Class;

                    AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();
                    contexto.Entry(ProductAntigo).State = System.Data.Entity.EntityState.Modified;
                    contexto.SaveChanges();
                }
            }
            List<Product> PesquisarPorName(String name)
            {
                var lista = from p in contexto.Product
                            where p.name == name
                            select p;
                return lista.tolist();
            }
        }
    }
}
