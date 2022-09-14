using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    internal class Circulo : Forma
    {
        public double Raio { get; private set; }

        public Circulo()
        {

        }

        public Circulo(double raio)
        {
            Raio = raio;
        }

        public override double CalcularArea()
        {
            return Math.PI * (Raio * Raio);
        }

        public override double CalcularPerimetro()
        {
            return (2 * Math.PI) * Raio;
        }

        public override string ToString()
        {
            return "Círculo\n" +
                "Raio: " + Raio.ToString() + "\n" +
                "Área: " + CalcularArea().ToString() + "\n" +
                "Perímetro: " + CalcularPerimetro().ToString();
        }
    }
}
