using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    internal class Imovel
    {
        public string Endereco { get; private set; }
        public double Preco { get; private set; }

        public Imovel()
        {

        }

        public Imovel(string endereco, double preco)
        {
            Endereco = endereco;
            Preco = preco;
        }

        public virtual double CalcularPreco()
        {
            return Preco;
        }

        public override string ToString()
        {
            return "Endereço: " + Endereco + "\n" +
                "Preço: " + CalcularPreco().ToString("c");
        }
    }
}
