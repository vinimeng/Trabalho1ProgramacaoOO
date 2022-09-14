using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho1
{
    internal class Alimento : Produto
    {
        public DateTime DataDeValidade { get; private set; }
        public double PorcentagemDepreciacao { get; private set; }

        public Alimento()
        {

        }

        public Alimento(
            string codigoBarras,
            double custo,
            double porcentagemImposto,
            double porcentagemMargemLucro,
            DateTime dataDeValidade,
            double porcentagemDepreciacao
        ) : base(codigoBarras, custo, porcentagemImposto,porcentagemMargemLucro)
        {
            DataDeValidade = dataDeValidade;
            PorcentagemDepreciacao = porcentagemDepreciacao;
        }

        public override double CalcularPreco()
        {
            double precoSemDepreciacao = base.CalcularPreco();
            double multiplicadorDepreciacao = PorcentagemDepreciacao / 100.0;

            int quantosDiasParaVencer = (DataDeValidade - DateTime.Today).Days;
            int quantasVezesMultiplicarDepreciacao = 0;
            bool zerar = false;

            // Quantas vezes aplicar depreciação, se baseando em quantos dias falta para vencer
            if (quantosDiasParaVencer >= 7 && quantosDiasParaVencer < 15)
            {
                quantasVezesMultiplicarDepreciacao = 1;
            }
            else if (quantosDiasParaVencer >= 3 && quantosDiasParaVencer < 7)
            {
                quantasVezesMultiplicarDepreciacao = 2;
            }
            else if (quantosDiasParaVencer >= 0 && quantosDiasParaVencer < 3)
            {
                quantasVezesMultiplicarDepreciacao = 3;
            }
            else if (quantosDiasParaVencer < 0)
            {
                zerar = true;
            }

            double precoFinal;

            // Se deve zerar ou depreciar o valor do produto
            if (zerar)
            {
                precoFinal = 0;
            }
            else
            {
                precoFinal = precoSemDepreciacao - ((precoSemDepreciacao * multiplicadorDepreciacao) * quantasVezesMultiplicarDepreciacao);

                if (precoFinal < Custo)
                {
                    precoFinal = Custo;
                }
            }            

            return precoFinal;
        }

    }
}
