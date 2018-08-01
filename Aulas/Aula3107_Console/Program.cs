using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3107_Console
{
    class Program
    {

        public static int Id { get; set; }
        static void Main (string[] args)
        
        {
            Console.WriteLine("Hello Wordl!");
            Console.ReadKey();
           
            Console.WriteLine("Digite um numero");
            Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Voce digitou: " + Id);
            Console.ReadKey();
        }
    }
}
