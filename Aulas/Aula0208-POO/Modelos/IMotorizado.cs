using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0208_POO.Modelos
{
    interface IMotorizado
    {
        void Acelerar();
        void Frenar();
        int Velocidade { get; set; }

    }
}
