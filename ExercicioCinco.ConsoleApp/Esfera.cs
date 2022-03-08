using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCinco.ConsoleApp
{
    internal class Esfera
    {
        public double raio;
        public double volume;
        const double pi = 3.14;

        public double CalcularVolume(double raio)
        {
            volume = (4 * pi * (raio * raio * raio)) / 3;
            return volume;
        }
    }
}