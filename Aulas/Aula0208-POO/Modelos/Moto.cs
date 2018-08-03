using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0208_POO.Modelos
{
    class Moto : Veiculo, IMotorizado
    {
        public int Velocidade { get ; set ; }

        public void Frenar()
        {
            Console.WriteLine("Moto: Acelerando pela manopla.");
            Velocidade += 10;
        }

        void IMotorizado.Acelerar()
        {
            Console.WriteLine("Descendo a ladeira...");
            Velocidade += 20;
        }
    }
}
