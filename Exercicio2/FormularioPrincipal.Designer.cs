namespace Exercicio2
{
    partial class FormularioPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxResultados = new System.Windows.Forms.GroupBox();
            this.richTextBoxImoveis = new System.Windows.Forms.RichTextBox();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.numericAdicional = new System.Windows.Forms.NumericUpDown();
            this.labelAdicional = new System.Windows.Forms.Label();
            this.numericDesconto = new System.Windows.Forms.NumericUpDown();
            this.labelDesconto = new System.Windows.Forms.Label();
            this.numericPreco = new System.Windows.Forms.NumericUpDown();
            this.labelPreco = new System.Windows.Forms.Label();
            this.textBoxEndereco = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.comboBoxTipoImovel = new System.Windows.Forms.ComboBox();
            this.labelTipoImovel = new System.Windows.Forms.Label();
            this.groupBoxResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAdicional)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDesconto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPreco)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxResultados
            // 
            this.groupBoxResultados.Controls.Add(this.richTextBoxImoveis);
            this.groupBoxResultados.Location = new System.Drawing.Point(174, 9);
            this.groupBoxResultados.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxResultados.Name = "groupBoxResultados";
            this.groupBoxResultados.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxResultados.Size = new System.Drawing.Size(184, 207);
            this.groupBoxResultados.TabIndex = 37;
            this.groupBoxResultados.TabStop = false;
            this.groupBoxResultados.Text = "Imóveis cadastrados";
            // 
            // richTextBoxImoveis
            // 
            this.richTextBoxImoveis.Location = new System.Drawing.Point(5, 15);
            this.richTextBoxImoveis.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxImoveis.Name = "richTextBoxImoveis";
            this.richTextBoxImoveis.ReadOnly = true;
            this.richTextBoxImoveis.ShortcutsEnabled = false;
            this.richTextBoxImoveis.Size = new System.Drawing.Size(175, 188);
            this.richTextBoxImoveis.TabIndex = 0;
            this.richTextBoxImoveis.Text = "";
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Location = new System.Drawing.Point(13, 197);
            this.buttonAdicionar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(155, 19);
            this.buttonAdicionar.TabIndex = 36;
            this.buttonAdicionar.Text = "Adicionar imóvel";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // numericAdicional
            // 
            this.numericAdicional.DecimalPlaces = 2;
            this.numericAdicional.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericAdicional.Location = new System.Drawing.Point(13, 173);
            this.numericAdicional.Margin = new System.Windows.Forms.Padding(2);
            this.numericAdicional.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numericAdicional.Name = "numericAdicional";
            this.numericAdicional.Size = new System.Drawing.Size(155, 20);
            this.numericAdicional.TabIndex = 30;
            // 
            // labelAdicional
            // 
            this.labelAdicional.AutoSize = true;
            this.labelAdicional.Location = new System.Drawing.Point(11, 158);
            this.labelAdicional.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAdicional.Name = "labelAdicional";
            this.labelAdicional.Size = new System.Drawing.Size(73, 13);
            this.labelAdicional.TabIndex = 29;
            this.labelAdicional.Text = "Adicional (R$)";
            // 
            // numericDesconto
            // 
            this.numericDesconto.DecimalPlaces = 2;
            this.numericDesconto.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericDesconto.Location = new System.Drawing.Point(13, 136);
            this.numericDesconto.Margin = new System.Windows.Forms.Padding(2);
            this.numericDesconto.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numericDesconto.Name = "numericDesconto";
            this.numericDesconto.Size = new System.Drawing.Size(155, 20);
            this.numericDesconto.TabIndex = 28;
            // 
            // labelDesconto
            // 
            this.labelDesconto.AutoSize = true;
            this.labelDesconto.Location = new System.Drawing.Point(11, 121);
            this.labelDesconto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDesconto.Name = "labelDesconto";
            this.labelDesconto.Size = new System.Drawing.Size(76, 13);
            this.labelDesconto.TabIndex = 27;
            this.labelDesconto.Text = "Desconto (R$)";
            // 
            // numericPreco
            // 
            this.numericPreco.DecimalPlaces = 2;
            this.numericPreco.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericPreco.Location = new System.Drawing.Point(13, 99);
            this.numericPreco.Margin = new System.Windows.Forms.Padding(2);
            this.numericPreco.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numericPreco.Name = "numericPreco";
            this.numericPreco.Size = new System.Drawing.Size(155, 20);
            this.numericPreco.TabIndex = 26;
            // 
            // labelPreco
            // 
            this.labelPreco.AutoSize = true;
            this.labelPreco.Location = new System.Drawing.Point(11, 84);
            this.labelPreco.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPreco.Name = "labelPreco";
            this.labelPreco.Size = new System.Drawing.Size(84, 13);
            this.labelPreco.TabIndex = 25;
            this.labelPreco.Text = "Preço base (R$)";
            // 
            // textBoxEndereco
            // 
            this.textBoxEndereco.Location = new System.Drawing.Point(13, 62);
            this.textBoxEndereco.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEndereco.Name = "textBoxEndereco";
            this.textBoxEndereco.Size = new System.Drawing.Size(156, 20);
            this.textBoxEndereco.TabIndex = 22;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(11, 47);
            this.labelNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(53, 13);
            this.labelNome.TabIndex = 21;
            this.labelNome.Text = "Endereço";
            // 
            // comboBoxTipoImovel
            // 
            this.comboBoxTipoImovel.FormattingEnabled = true;
            this.comboBoxTipoImovel.Items.AddRange(new object[] {
            "Novo",
            "Velho"});
            this.comboBoxTipoImovel.Location = new System.Drawing.Point(13, 25);
            this.comboBoxTipoImovel.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxTipoImovel.Name = "comboBoxTipoImovel";
            this.comboBoxTipoImovel.Size = new System.Drawing.Size(156, 21);
            this.comboBoxTipoImovel.TabIndex = 20;
            this.comboBoxTipoImovel.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipoImovel_SelectedIndexChanged);
            // 
            // labelTipoImovel
            // 
            this.labelTipoImovel.AutoSize = true;
            this.labelTipoImovel.Location = new System.Drawing.Point(11, 9);
            this.labelTipoImovel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTipoImovel.Name = "labelTipoImovel";
            this.labelTipoImovel.Size = new System.Drawing.Size(76, 13);
            this.labelTipoImovel.TabIndex = 19;
            this.labelTipoImovel.Text = "Tipo do imóvel";
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 222);
            this.Controls.Add(this.groupBoxResultados);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.numericAdicional);
            this.Controls.Add(this.labelAdicional);
            this.Controls.Add(this.numericDesconto);
            this.Controls.Add(this.labelDesconto);
            this.Controls.Add(this.numericPreco);
            this.Controls.Add(this.labelPreco);
            this.Controls.Add(this.textBoxEndereco);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.comboBoxTipoImovel);
            this.Controls.Add(this.labelTipoImovel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(384, 261);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(384, 261);
            this.Name = "FormularioPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercicio2";
            this.groupBoxResultados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericAdicional)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDesconto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPreco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxResultados;
        private System.Windows.Forms.RichTextBox richTextBoxImoveis;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.NumericUpDown numericAdicional;
        private System.Windows.Forms.Label labelAdicional;
        private System.Windows.Forms.NumericUpDown numericDesconto;
        private System.Windows.Forms.Label labelDesconto;
        private System.Windows.Forms.NumericUpDown numericPreco;
        private System.Windows.Forms.Label labelPreco;
        private System.Windows.Forms.TextBox textBoxEndereco;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.ComboBox comboBoxTipoImovel;
        private System.Windows.Forms.Label labelTipoImovel;
    }
}

