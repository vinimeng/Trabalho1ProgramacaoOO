using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio2
{
    public partial class FormularioPrincipal : Form
    {
        private List<Imovel> imoveis;

        public FormularioPrincipal()
        {
            InitializeComponent();
            imoveis = new List<Imovel>();
            comboBoxTipoImovel.SelectedItem = "Novo";
            numericDesconto.Enabled = false;
            numericAdicional.Enabled = true;
        }

        private void comboBoxTipoImovel_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxTipoImovel.SelectedItem)
            {
                case "Novo":
                    numericDesconto.Enabled = false;
                    numericAdicional.Enabled = true;
                    break;
                case "Velho":
                    numericDesconto.Enabled = true;
                    numericAdicional.Enabled = false;
                    break;
                default:
                    numericDesconto.Enabled = false;
                    numericAdicional.Enabled = false;
                    break;
            }
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            switch (comboBoxTipoImovel.SelectedItem)
            {
                case "Novo":
                    imoveis.Add(new Novo(
                        textBoxEndereco.Text,
                        Convert.ToDouble(numericPreco.Value),
                        Convert.ToDouble(numericAdicional.Value)
                    ));
                    break;
                case "Velho":
                    imoveis.Add(new Velho(
                        textBoxEndereco.Text,
                        Convert.ToDouble(numericPreco.Value),
                        Convert.ToDouble(numericDesconto.Value)
                    ));
                    break;
                default:
                    imoveis.Add(new Imovel(
                        textBoxEndereco.Text,
                        Convert.ToDouble(numericPreco.Value)
                    ));
                    break;
            }

            imprimirImoveisCadastrados();
        }

        public void imprimirImoveisCadastrados()
        {
            string imoveisCadastrados = "--- IMOVEIS ---\n\n";

            foreach (var imovel in imoveis)
            {
                imoveisCadastrados += imovel.ToString()
                    + "\n-----------------------------\n\n";
            }

            richTextBoxImoveis.Text = imoveisCadastrados;
        }
    }
}
