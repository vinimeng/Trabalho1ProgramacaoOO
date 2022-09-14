using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    internal class Retangulo : Forma
    {
        public double Altura { get; private set; }
        public double Largura { get; private set; }

        public Retangulo()
        {

        }

        public Retangulo(double altura, double largura)
        {
            Altura = altura;
            Largura = largura;
        }

        public override double CalcularArea()
        {
            return Altura * Largura;
        }

        public override double CalcularPerimetro()
        {
            return (Largura * 2) + (Altura * 2);
        }

        public override string ToString()
        {
            return "Retangulo\n" +
                "Altura: " + Altura.ToString() + "\n" +
                "Largura: " + Largura.ToString() + "\n" +
                "Área: " + CalcularArea().ToString() + "\n" +
                "Perímetro: " + CalcularPerimetro().ToString();
        }
    }
}
