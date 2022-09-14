using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    internal class Quadrado : Retangulo
    {
        public Quadrado()
        {

        }

        public Quadrado (double lado)
            : base(lado, lado)
        {

        }

        public override string ToString()
        {
            return "Quadrado\n" +
                "Lado: " + Altura.ToString() + "\n" +
                "Área: " + CalcularArea().ToString() + "\n" +
                "Perímetro: " + CalcularPerimetro().ToString();
        }
    }
}
