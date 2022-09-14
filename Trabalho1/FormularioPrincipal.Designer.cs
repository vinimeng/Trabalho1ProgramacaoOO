namespace Trabalho1
{
    partial class FormularioPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTipoProduto = new System.Windows.Forms.Label();
            this.comboBoxTipoProduto = new System.Windows.Forms.ComboBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxCodigoBarras = new System.Windows.Forms.TextBox();
            this.labelCodigoBarras = new System.Windows.Forms.Label();
            this.labelCusto = new System.Windows.Forms.Label();
            this.numericCusto = new System.Windows.Forms.NumericUpDown();
            this.numericPorcentagemImposto = new System.Windows.Forms.NumericUpDown();
            this.labelImposto = new System.Windows.Forms.Label();
            this.numericPorcentagemLucro = new System.Windows.Forms.NumericUpDown();
            this.labelLucro = new System.Windows.Forms.Label();
            this.dateTimePickerDataValidade = new System.Windows.Forms.DateTimePicker();
            this.labelDataValidade = new System.Windows.Forms.Label();
            this.numericPorcentagemDepreciacao = new System.Windows.Forms.NumericUpDown();
            this.labelDeprecicao = new System.Windows.Forms.Label();
            this.checkBoxLinhaBranca = new System.Windows.Forms.CheckBox();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.groupBoxResultados = new System.Windows.Forms.GroupBox();
            this.richTextBoxProdutos = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericCusto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPorcentagemImposto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPorcentagemLucro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPorcentagemDepreciacao)).BeginInit();
            this.groupBoxResultados.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTipoProduto
            // 
            this.labelTipoProduto.AutoSize = true;
            this.labelTipoProduto.Location = new System.Drawing.Point(9, 7);
            this.labelTipoProduto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTipoProduto.Name = "labelTipoProduto";
            this.labelTipoProduto.Size = new System.Drawing.Size(82, 13);
            this.labelTipoProduto.TabIndex = 0;
            this.labelTipoProduto.Text = "Tipo do produto";
            // 
            // comboBoxTipoProduto
            // 
            this.comboBoxTipoProduto.FormattingEnabled = true;
            this.comboBoxTipoProduto.Items.AddRange(new object[] {
            "Alimento",
            "Eletrodoméstico",
            "Produto"});
            this.comboBoxTipoProduto.Location = new System.Drawing.Point(11, 23);
            this.comboBoxTipoProduto.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxTipoProduto.Name = "comboBoxTipoProduto";
            this.comboBoxTipoProduto.Size = new System.Drawing.Size(156, 21);
            this.comboBoxTipoProduto.TabIndex = 1;
            this.comboBoxTipoProduto.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipoProduto_SelectedIndexChanged);
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(9, 45);
            this.labelNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(35, 13);
            this.labelNome.TabIndex = 2;
            this.labelNome.Text = "Nome";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(11, 60);
            this.textBoxNome.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(156, 20);
            this.textBoxNome.TabIndex = 3;
            // 
            // textBoxCodigoBarras
            // 
            this.textBoxCodigoBarras.Location = new System.Drawing.Point(11, 96);
            this.textBoxCodigoBarras.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCodigoBarras.Name = "textBoxCodigoBarras";
            this.textBoxCodigoBarras.Size = new System.Drawing.Size(156, 20);
            this.textBoxCodigoBarras.TabIndex = 5;
            // 
            // labelCodigoBarras
            // 
            this.labelCodigoBarras.AutoSize = true;
            this.labelCodigoBarras.Location = new System.Drawing.Point(9, 80);
            this.labelCodigoBarras.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCodigoBarras.Name = "labelCodigoBarras";
            this.labelCodigoBarras.Size = new System.Drawing.Size(87, 13);
            this.labelCodigoBarras.TabIndex = 4;
            this.labelCodigoBarras.Text = "Código de barras";
            // 
            // labelCusto
            // 
            this.labelCusto.AutoSize = true;
            this.labelCusto.Location = new System.Drawing.Point(9, 116);
            this.labelCusto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCusto.Name = "labelCusto";
            this.labelCusto.Size = new System.Drawing.Size(57, 13);
            this.labelCusto.TabIndex = 6;
            this.labelCusto.Text = "Custo (R$)";
            // 
            // numericCusto
            // 
            this.numericCusto.DecimalPlaces = 2;
            this.numericCusto.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericCusto.Location = new System.Drawing.Point(11, 132);
            this.numericCusto.Margin = new System.Windows.Forms.Padding(2);
            this.numericCusto.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numericCusto.Name = "numericCusto";
            this.numericCusto.Size = new System.Drawing.Size(155, 20);
            this.numericCusto.TabIndex = 7;
            // 
            // numericPorcentagemImposto
            // 
            this.numericPorcentagemImposto.DecimalPlaces = 2;
            this.numericPorcentagemImposto.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericPorcentagemImposto.Location = new System.Drawing.Point(11, 167);
            this.numericPorcentagemImposto.Margin = new System.Windows.Forms.Padding(2);
            this.numericPorcentagemImposto.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numericPorcentagemImposto.Name = "numericPorcentagemImposto";
            this.numericPorcentagemImposto.Size = new System.Drawing.Size(155, 20);
            this.numericPorcentagemImposto.TabIndex = 9;
            // 
            // labelImposto
            // 
            this.labelImposto.AutoSize = true;
            this.labelImposto.Location = new System.Drawing.Point(9, 152);
            this.labelImposto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelImposto.Name = "labelImposto";
            this.labelImposto.Size = new System.Drawing.Size(61, 13);
            this.labelImposto.TabIndex = 8;
            this.labelImposto.Text = "Imposto (%)";
            // 
            // numericPorcentagemLucro
            // 
            this.numericPorcentagemLucro.DecimalPlaces = 2;
            this.numericPorcentagemLucro.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericPorcentagemLucro.Location = new System.Drawing.Point(11, 203);
            this.numericPorcentagemLucro.Margin = new System.Windows.Forms.Padding(2);
            this.numericPorcentagemLucro.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numericPorcentagemLucro.Name = "numericPorcentagemLucro";
            this.numericPorcentagemLucro.Size = new System.Drawing.Size(155, 20);
            this.numericPorcentagemLucro.TabIndex = 11;
            // 
            // labelLucro
            // 
            this.labelLucro.AutoSize = true;
            this.labelLucro.Location = new System.Drawing.Point(9, 188);
            this.labelLucro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLucro.Name = "labelLucro";
            this.labelLucro.Size = new System.Drawing.Size(51, 13);
            this.labelLucro.TabIndex = 10;
            this.labelLucro.Text = "Lucro (%)";
            // 
            // dateTimePickerDataValidade
            // 
            this.dateTimePickerDataValidade.Checked = false;
            this.dateTimePickerDataValidade.Enabled = false;
            this.dateTimePickerDataValidade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataValidade.Location = new System.Drawing.Point(11, 239);
            this.dateTimePickerDataValidade.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerDataValidade.Name = "dateTimePickerDataValidade";
            this.dateTimePickerDataValidade.Size = new System.Drawing.Size(156, 20);
            this.dateTimePickerDataValidade.TabIndex = 12;
            // 
            // labelDataValidade
            // 
            this.labelDataValidade.AutoSize = true;
            this.labelDataValidade.Location = new System.Drawing.Point(9, 223);
            this.labelDataValidade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDataValidade.Name = "labelDataValidade";
            this.labelDataValidade.Size = new System.Drawing.Size(88, 13);
            this.labelDataValidade.TabIndex = 13;
            this.labelDataValidade.Text = "Data de validade";
            // 
            // numericPorcentagemDepreciacao
            // 
            this.numericPorcentagemDepreciacao.DecimalPlaces = 2;
            this.numericPorcentagemDepreciacao.Enabled = false;
            this.numericPorcentagemDepreciacao.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericPorcentagemDepreciacao.Location = new System.Drawing.Point(11, 275);
            this.numericPorcentagemDepreciacao.Margin = new System.Windows.Forms.Padding(2);
            this.numericPorcentagemDepreciacao.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numericPorcentagemDepreciacao.Name = "numericPorcentagemDepreciacao";
            this.numericPorcentagemDepreciacao.Size = new System.Drawing.Size(155, 20);
            this.numericPorcentagemDepreciacao.TabIndex = 15;
            // 
            // labelDeprecicao
            // 
            this.labelDeprecicao.AutoSize = true;
            this.labelDeprecicao.Location = new System.Drawing.Point(9, 259);
            this.labelDeprecicao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDeprecicao.Name = "labelDeprecicao";
            this.labelDeprecicao.Size = new System.Drawing.Size(85, 13);
            this.labelDeprecicao.TabIndex = 14;
            this.labelDeprecicao.Text = "Depreciação (%)";
            // 
            // checkBoxLinhaBranca
            // 
            this.checkBoxLinhaBranca.AutoSize = true;
            this.checkBoxLinhaBranca.Enabled = false;
            this.checkBoxLinhaBranca.Location = new System.Drawing.Point(11, 298);
            this.checkBoxLinhaBranca.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxLinhaBranca.Name = "checkBoxLinhaBranca";
            this.checkBoxLinhaBranca.Size = new System.Drawing.Size(88, 17);
            this.checkBoxLinhaBranca.TabIndex = 16;
            this.checkBoxLinhaBranca.Text = "Linha branca";
            this.checkBoxLinhaBranca.UseVisualStyleBackColor = true;
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Location = new System.Drawing.Point(11, 319);
            this.buttonAdicionar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(155, 19);
            this.buttonAdicionar.TabIndex = 17;
            this.buttonAdicionar.Text = "Adicionar produto";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // groupBoxResultados
            // 
            this.groupBoxResultados.Controls.Add(this.richTextBoxProdutos);
            this.groupBoxResultados.Location = new System.Drawing.Point(172, 7);
            this.groupBoxResultados.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxResultados.Name = "groupBoxResultados";
            this.groupBoxResultados.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxResultados.Size = new System.Drawing.Size(184, 331);
            this.groupBoxResultados.TabIndex = 18;
            this.groupBoxResultados.TabStop = false;
            this.groupBoxResultados.Text = "Produtos cadastrados";
            // 
            // richTextBoxProdutos
            // 
            this.richTextBoxProdutos.Location = new System.Drawing.Point(5, 15);
            this.richTextBoxProdutos.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxProdutos.Name = "richTextBoxProdutos";
            this.richTextBoxProdutos.ReadOnly = true;
            this.richTextBoxProdutos.ShortcutsEnabled = false;
            this.richTextBoxProdutos.Size = new System.Drawing.Size(175, 311);
            this.richTextBoxProdutos.TabIndex = 0;
            this.richTextBoxProdutos.Text = "";
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 354);
            this.Controls.Add(this.groupBoxResultados);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.checkBoxLinhaBranca);
            this.Controls.Add(this.numericPorcentagemDepreciacao);
            this.Controls.Add(this.labelDeprecicao);
            this.Controls.Add(this.labelDataValidade);
            this.Controls.Add(this.dateTimePickerDataValidade);
            this.Controls.Add(this.numericPorcentagemLucro);
            this.Controls.Add(this.labelLucro);
            this.Controls.Add(this.numericPorcentagemImposto);
            this.Controls.Add(this.labelImposto);
            this.Controls.Add(this.numericCusto);
            this.Controls.Add(this.labelCusto);
            this.Controls.Add(this.textBoxCodigoBarras);
            this.Controls.Add(this.labelCodigoBarras);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.comboBoxTipoProduto);
            this.Controls.Add(this.labelTipoProduto);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(383, 393);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(383, 393);
            this.Name = "FormularioPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercicio1";
            ((System.ComponentModel.ISupportInitialize)(this.numericCusto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPorcentagemImposto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPorcentagemLucro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPorcentagemDepreciacao)).EndInit();
            this.groupBoxResultados.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTipoProduto;
        private System.Windows.Forms.ComboBox comboBoxTipoProduto;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxCodigoBarras;
        private System.Windows.Forms.Label labelCodigoBarras;
        private System.Windows.Forms.Label labelCusto;
        private System.Windows.Forms.NumericUpDown numericCusto;
        private System.Windows.Forms.NumericUpDown numericPorcentagemImposto;
        private System.Windows.Forms.Label labelImposto;
        private System.Windows.Forms.NumericUpDown numericPorcentagemLucro;
        private System.Windows.Forms.Label labelLucro;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataValidade;
        private System.Windows.Forms.Label labelDataValidade;
        private System.Windows.Forms.NumericUpDown numericPorcentagemDepreciacao;
        private System.Windows.Forms.Label labelDeprecicao;
        private System.Windows.Forms.CheckBox checkBoxLinhaBranca;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.GroupBox groupBoxResultados;
        private System.Windows.Forms.RichTextBox richTextBoxProdutos;
    }
}