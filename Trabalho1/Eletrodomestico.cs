using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho1
{
    internal class Eletrodomestico : Produto
    {
        public bool LinhaBranca { get; private set; }

        public Eletrodomestico()
        {

        }

        public Eletrodomestico(
            string codigoBarras,
            double custo,
            double porcentagemImposto,
            double porcentagemMargemLucro,
            bool linhaBranca
        ) : base(codigoBarras, custo, porcentagemImposto, porcentagemMargemLucro)
        {
            LinhaBranca = linhaBranca;
        }

        public override double CalcularPreco()
        {
            double precoFinal;

            if (LinhaBranca)
            {
                double multiplicadorLucro = PorcentagemMargemLucro / 100.0;
                double precoSemImposto = Custo + (Custo * multiplicadorLucro);
                precoFinal = precoSemImposto;
            }
            else
            {
                precoFinal = base.CalcularPreco();
            }

            return precoFinal;
        }
    }
}
