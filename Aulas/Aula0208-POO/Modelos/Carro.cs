﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0208_POO.Modelos
{
    class Carro : Veiculo, IMotorizado
    {
        public int Velocidade { get ; set ; }

        public void Acelerar()
        {
            Console.WriteLine("Pisando no Pedal...");
            Velocidade += 5;
        }

        public void Frenar()
        {
            Console.WriteLine("Pisando no Pedal (Freio)...");
            Velocidade += 3;
        }
    }
}
