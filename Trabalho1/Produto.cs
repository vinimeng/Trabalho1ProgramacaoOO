using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho1
{
    internal class Produto
    {
        public string Nome { get; private set; }
        public string CodigoBarras { get; private set; }
        public double Custo { get; private set; }
        public double PorcentagemImposto { get; private set; }
        public double PorcentagemMargemLucro { get; set; }

        public Produto()
        {

        }

        public Produto(string nome, string codigoBarras, double custo, double porcentagemImposto, double porcentagemMargemLucro)
        {
            Nome = nome;
            CodigoBarras = codigoBarras;
            Custo = custo;
            PorcentagemImposto = porcentagemImposto;
            PorcentagemMargemLucro = porcentagemMargemLucro;
        }

        public virtual double CalcularPreco()
        {
            double multiplicadorImposto = PorcentagemImposto / 100.0;
            double multiplicadorLucro = PorcentagemMargemLucro / 100.0;
            double precoSemImposto = Custo + (Custo * multiplicadorLucro);
            double imposto = precoSemImposto * multiplicadorImposto;
            double precoFinal = precoSemImposto + imposto;

            return precoFinal;
        }
        public override string ToString()
        {
            return "Nome: " + Nome + "\n" +
                "Código de barras: " + CodigoBarras + "\n" +
                "Custo: " + Custo.ToString("c") + "\n" +
                "% imposto: " + PorcentagemImposto.ToString(CultureInfo.CurrentCulture) + "%\n" +
                "% margem lucro: " + PorcentagemMargemLucro.ToString(CultureInfo.CurrentCulture) + "%\n" +
                "Preço:" + CalcularPreco().ToString("c");
        }
    }
}
