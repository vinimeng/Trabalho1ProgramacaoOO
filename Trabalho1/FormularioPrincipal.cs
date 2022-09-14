using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho1
{
    public partial class FormularioPrincipal : Form
    {
        private List<Produto> produtos;
        public FormularioPrincipal()
        {
            InitializeComponent();
            produtos = new List<Produto>();
            comboBoxTipoProduto.SelectedItem = "Produto";
        }

        private void comboBoxTipoProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxTipoProduto.SelectedItem)
            {
                case "Alimento":
                    dateTimePickerDataValidade.Enabled = true;
                    numericPorcentagemDepreciacao.Enabled = true;
                    checkBoxLinhaBranca.Enabled = false;
                    break;
                case "Eletrodoméstico":
                    dateTimePickerDataValidade.Enabled = false;
                    numericPorcentagemDepreciacao.Enabled = false;
                    checkBoxLinhaBranca.Enabled = true;
                    break;
                default:
                    dateTimePickerDataValidade.Enabled = false;
                    numericPorcentagemDepreciacao.Enabled = false;
                    checkBoxLinhaBranca.Enabled = false;
                    break;
            }
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            switch (comboBoxTipoProduto.SelectedItem)
            {
                case "Alimento":
                    produtos.Add(new Alimento(
                        textBoxNome.Text,
                        textBoxCodigoBarras.Text,
                        Convert.ToDouble(numericCusto.Value),
                        Convert.ToDouble(numericPorcentagemImposto.Value),
                        Convert.ToDouble(numericPorcentagemLucro.Value),
                        dateTimePickerDataValidade.Value,
                        Convert.ToDouble(numericPorcentagemDepreciacao.Value)
                    ));
                    break;
                case "Eletrodoméstico":
                    produtos.Add(new Eletrodomestico(
                        textBoxNome.Text,
                        textBoxCodigoBarras.Text,
                        Convert.ToDouble(numericCusto.Value),
                        Convert.ToDouble(numericPorcentagemImposto.Value),
                        Convert.ToDouble(numericPorcentagemLucro.Value),
                        checkBoxLinhaBranca.Checked
                    ));
                    break;
                default:
                    produtos.Add(new Produto(
                        textBoxNome.Text,
                        textBoxCodigoBarras.Text,
                        Convert.ToDouble(numericCusto.Value),
                        Convert.ToDouble(numericPorcentagemImposto.Value),
                        Convert.ToDouble(numericPorcentagemLucro.Value)
                    ));
                    break;
            }

            imprimirProdutosCadastrados();
        }

        public void imprimirProdutosCadastrados()
        {
            string produtosCadastrados = "--- PRODUTOS ---\n\n"; 

            foreach (var produto in produtos)
            {
                produtosCadastrados += produto.ToString() 
                    + "\n-----------------------------\n\n";
            }

            richTextBoxProdutos.Text = produtosCadastrados;
        }
    }
}
