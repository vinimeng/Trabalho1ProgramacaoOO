using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    internal class Velho : Imovel
    {
        public double Desconto { get; private set; }

        public Velho()
        {

        }

        public Velho(string endereco, double preco, double desconto)
            : base(endereco, preco)
        {
            Desconto = desconto;
        }

        public override double CalcularPreco()
        {
            return base.CalcularPreco() - Desconto;
        }

        public override string ToString()
        {
            return base.ToString() + "\n" +
                "Tipo: Velho" + "\n" +
                "Desconto: " + Desconto.ToString("c");
        }
    }
}
