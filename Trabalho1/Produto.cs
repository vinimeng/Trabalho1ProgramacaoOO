using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho1
{
    internal class Produto
    {
        public string CodigoBarras { get; private set; }
        public double Custo { get; private set; }
        public double PorcentagemImposto { get; private set; }
        public double PorcentagemMargemLucro { get; set; }

        public Produto()
        {

        }

        public Produto(string codigoBarras, double custo, double porcentagemImposto, double porcentagemMargemLucro)
        {
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
    }
}
