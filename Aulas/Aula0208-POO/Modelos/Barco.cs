using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0208_POO.Modelos
{
    class Barco : Veiculo, IMotorizado
    {
        public int Velocidade { get ; set ; }

        public void Acelerar()
        {
            Console.WriteLine("BARCO: Acelerando, empurrando a maneta");
            Velocidade += 5;
        }

        public void Frenar()
        {
            Console.WriteLine("Reverso acionado...");
            Velocidade += 3;
        }
    }
}
