namespace Exercicio3
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
            this.richTextBoxFormas = new System.Windows.Forms.RichTextBox();
            this.buttonGerar = new System.Windows.Forms.Button();
            this.groupBoxResultados.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxResultados
            // 
            this.groupBoxResultados.Controls.Add(this.richTextBoxFormas);
            this.groupBoxResultados.Location = new System.Drawing.Point(11, 11);
            this.groupBoxResultados.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxResultados.Name = "groupBoxResultados";
            this.groupBoxResultados.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxResultados.Size = new System.Drawing.Size(270, 299);
            this.groupBoxResultados.TabIndex = 38;
            this.groupBoxResultados.TabStop = false;
            this.groupBoxResultados.Text = "Resultados";
            // 
            // richTextBoxFormas
            // 
            this.richTextBoxFormas.Location = new System.Drawing.Point(5, 15);
            this.richTextBoxFormas.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxFormas.Name = "richTextBoxFormas";
            this.richTextBoxFormas.ReadOnly = true;
            this.richTextBoxFormas.ShortcutsEnabled = false;
            this.richTextBoxFormas.Size = new System.Drawing.Size(261, 280);
            this.richTextBoxFormas.TabIndex = 0;
            this.richTextBoxFormas.Text = "";
            // 
            // buttonGerar
            // 
            this.buttonGerar.Location = new System.Drawing.Point(11, 316);
            this.buttonGerar.Name = "buttonGerar";
            this.buttonGerar.Size = new System.Drawing.Size(270, 23);
            this.buttonGerar.TabIndex = 39;
            this.buttonGerar.Text = "Gerar formas";
            this.buttonGerar.UseVisualStyleBackColor = true;
            this.buttonGerar.Click += new System.EventHandler(this.buttonGerar_Click);
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 346);
            this.Controls.Add(this.buttonGerar);
            this.Controls.Add(this.groupBoxResultados);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(308, 385);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(308, 385);
            this.Name = "FormularioPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercicio3";
            this.groupBoxResultados.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxResultados;
        private System.Windows.Forms.RichTextBox richTextBoxFormas;
        private System.Windows.Forms.Button buttonGerar;
    }
}

