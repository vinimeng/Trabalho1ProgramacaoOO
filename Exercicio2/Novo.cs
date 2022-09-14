using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    internal class Novo : Imovel
    {
        public double Adicional { get; private set; }

        public Novo()
        {

        }

        public Novo(string endereco, double preco, double adicional)
            : base(endereco, preco)
        {
            Adicional = adicional;
        }

        public override double CalcularPreco()
        {
            return base.CalcularPreco() + Adicional;
        }

        public override string ToString()
        {
            return base.ToString() + "\n" +
                "Tipo: Novo" + "\n" +
                "Adicional: " + Adicional.ToString("c");
        }
    }
}
