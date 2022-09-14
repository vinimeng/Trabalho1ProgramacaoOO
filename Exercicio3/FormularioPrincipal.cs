using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio3
{
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void buttonGerar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            Retangulo retangulo = new Retangulo((random.NextDouble() * 10), (random.NextDouble() * 10));
            Circulo circulo = new Circulo((random.NextDouble() * 10));
            Quadrado quadrado = new Quadrado((random.NextDouble() * 10));

            richTextBoxFormas.Text = retangulo.ToString() + 
                "\n-----------------------------\n\n" +
                circulo.ToString() +
                "\n-----------------------------\n\n" +
                quadrado.ToString();
        }
    }
}
