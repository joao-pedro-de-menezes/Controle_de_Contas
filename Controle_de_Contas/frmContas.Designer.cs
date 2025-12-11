namespace Controle_de_Contas
{
    partial class frmContas
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
            this.txtQtdeContas = new System.Windows.Forms.TextBox();
            this.lblQtdeContas = new System.Windows.Forms.Label();
            this.lstContas = new System.Windows.Forms.ListBox();
            this.lblContas = new System.Windows.Forms.Label();
            this.grbDados = new System.Windows.Forms.GroupBox();
            this.numValor = new System.Windows.Forms.NumericUpDown();
            this.lblValor = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cmbConta = new System.Windows.Forms.ComboBox();
            this.lblConta = new System.Windows.Forms.Label();
            this.mskHoraLacto = new System.Windows.Forms.MaskedTextBox();
            this.lblHoraLacto = new System.Windows.Forms.Label();
            this.mskDataLancto = new System.Windows.Forms.MaskedTextBox();
            this.lblDataLancto = new System.Windows.Forms.Label();
            this.grbOpcoes = new System.Windows.Forms.GroupBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.grbDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numValor)).BeginInit();
            this.grbOpcoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtQtdeContas
            // 
            this.txtQtdeContas.Location = new System.Drawing.Point(569, 342);
            this.txtQtdeContas.Name = "txtQtdeContas";
            this.txtQtdeContas.ReadOnly = true;
            this.txtQtdeContas.Size = new System.Drawing.Size(100, 20);
            this.txtQtdeContas.TabIndex = 11;
            // 
            // lblQtdeContas
            // 
            this.lblQtdeContas.AutoSize = true;
            this.lblQtdeContas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblQtdeContas.Location = new System.Drawing.Point(482, 345);
            this.lblQtdeContas.Name = "lblQtdeContas";
            this.lblQtdeContas.Size = new System.Drawing.Size(81, 13);
            this.lblQtdeContas.TabIndex = 10;
            this.lblQtdeContas.Text = "Qtde de Contas";
            // 
            // lstContas
            // 
            this.lstContas.FormattingEnabled = true;
            this.lstContas.Location = new System.Drawing.Point(452, 131);
            this.lstContas.Name = "lstContas";
            this.lstContas.Size = new System.Drawing.Size(193, 186);
            this.lstContas.TabIndex = 9;
            // 
            // lblContas
            // 
            this.lblContas.AutoSize = true;
            this.lblContas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblContas.Location = new System.Drawing.Point(473, 115);
            this.lblContas.Name = "lblContas";
            this.lblContas.Size = new System.Drawing.Size(40, 13);
            this.lblContas.TabIndex = 8;
            this.lblContas.Text = "Contas";
            // 
            // grbDados
            // 
            this.grbDados.Controls.Add(this.numValor);
            this.grbDados.Controls.Add(this.lblValor);
            this.grbDados.Controls.Add(this.cmbTipo);
            this.grbDados.Controls.Add(this.lblTipo);
            this.grbDados.Controls.Add(this.cmbConta);
            this.grbDados.Controls.Add(this.lblConta);
            this.grbDados.Controls.Add(this.mskHoraLacto);
            this.grbDados.Controls.Add(this.lblHoraLacto);
            this.grbDados.Controls.Add(this.mskDataLancto);
            this.grbDados.Controls.Add(this.lblDataLancto);
            this.grbDados.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grbDados.Location = new System.Drawing.Point(12, 115);
            this.grbDados.Name = "grbDados";
            this.grbDados.Size = new System.Drawing.Size(434, 210);
            this.grbDados.TabIndex = 7;
            this.grbDados.TabStop = false;
            this.grbDados.Text = "Dados";
            // 
            // numValor
            // 
            this.numValor.DecimalPlaces = 2;
            this.numValor.Location = new System.Drawing.Point(329, 136);
            this.numValor.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numValor.Name = "numValor";
            this.numValor.ReadOnly = true;
            this.numValor.Size = new System.Drawing.Size(69, 20);
            this.numValor.TabIndex = 10;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(292, 142);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 9;
            this.lblValor.Text = "Valor";
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(123, 135);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipo.TabIndex = 8;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(17, 138);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 7;
            this.lblTipo.Text = "Tipo";
            // 
            // cmbConta
            // 
            this.cmbConta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConta.FormattingEnabled = true;
            this.cmbConta.Location = new System.Drawing.Point(123, 100);
            this.cmbConta.Name = "cmbConta";
            this.cmbConta.Size = new System.Drawing.Size(121, 21);
            this.cmbConta.TabIndex = 6;
            // 
            // lblConta
            // 
            this.lblConta.AutoSize = true;
            this.lblConta.Location = new System.Drawing.Point(17, 103);
            this.lblConta.Name = "lblConta";
            this.lblConta.Size = new System.Drawing.Size(35, 13);
            this.lblConta.TabIndex = 5;
            this.lblConta.Text = "Conta";
            // 
            // mskHoraLacto
            // 
            this.mskHoraLacto.Location = new System.Drawing.Point(123, 67);
            this.mskHoraLacto.Name = "mskHoraLacto";
            this.mskHoraLacto.Size = new System.Drawing.Size(121, 20);
            this.mskHoraLacto.TabIndex = 4;
            // 
            // lblHoraLacto
            // 
            this.lblHoraLacto.AutoSize = true;
            this.lblHoraLacto.Location = new System.Drawing.Point(16, 70);
            this.lblHoraLacto.Name = "lblHoraLacto";
            this.lblHoraLacto.Size = new System.Drawing.Size(71, 13);
            this.lblHoraLacto.TabIndex = 3;
            this.lblHoraLacto.Text = "Hora do lacto";
            // 
            // mskDataLancto
            // 
            this.mskDataLancto.Location = new System.Drawing.Point(123, 34);
            this.mskDataLancto.Name = "mskDataLancto";
            this.mskDataLancto.Size = new System.Drawing.Size(121, 20);
            this.mskDataLancto.TabIndex = 2;
            // 
            // lblDataLancto
            // 
            this.lblDataLancto.AutoSize = true;
            this.lblDataLancto.Location = new System.Drawing.Point(16, 37);
            this.lblDataLancto.Name = "lblDataLancto";
            this.lblDataLancto.Size = new System.Drawing.Size(81, 13);
            this.lblDataLancto.TabIndex = 0;
            this.lblDataLancto.Text = "Data de Lançto";
            // 
            // grbOpcoes
            // 
            this.grbOpcoes.Controls.Add(this.btnSair);
            this.grbOpcoes.Controls.Add(this.btnConfirmar);
            this.grbOpcoes.Controls.Add(this.btnNovo);
            this.grbOpcoes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grbOpcoes.Location = new System.Drawing.Point(12, 12);
            this.grbOpcoes.Name = "grbOpcoes";
            this.grbOpcoes.Size = new System.Drawing.Size(422, 97);
            this.grbOpcoes.TabIndex = 6;
            this.grbOpcoes.TabStop = false;
            this.grbOpcoes.Text = "Opções";
            // 
            // btnSair
            // 
            this.btnSair.Image = global::Controle_de_Contas.Properties.Resources.Sair;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(276, 30);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(122, 42);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConfirmar.Image = global::Controle_de_Contas.Properties.Resources.Confirmar;
            this.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmar.Location = new System.Drawing.Point(148, 30);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(122, 42);
            this.btnConfirmar.TabIndex = 1;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Image = global::Controle_de_Contas.Properties.Resources.Novo;
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.Location = new System.Drawing.Point(19, 30);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(122, 42);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(307, 349);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(117, 47);
            this.btnFinalizar.TabIndex = 12;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(287, 421);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(324, 418);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 14;
            // 
            // frmContas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.txtQtdeContas);
            this.Controls.Add(this.lblQtdeContas);
            this.Controls.Add(this.lstContas);
            this.Controls.Add(this.lblContas);
            this.Controls.Add(this.grbDados);
            this.Controls.Add(this.grbOpcoes);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "frmContas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Contas";
            this.Load += new System.EventHandler(this.frmContas_Load);
            this.grbDados.ResumeLayout(false);
            this.grbDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numValor)).EndInit();
            this.grbOpcoes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQtdeContas;
        private System.Windows.Forms.Label lblQtdeContas;
        private System.Windows.Forms.ListBox lstContas;
        private System.Windows.Forms.Label lblContas;
        private System.Windows.Forms.GroupBox grbDados;
        private System.Windows.Forms.NumericUpDown numValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cmbConta;
        private System.Windows.Forms.Label lblConta;
        private System.Windows.Forms.MaskedTextBox mskHoraLacto;
        private System.Windows.Forms.Label lblHoraLacto;
        private System.Windows.Forms.MaskedTextBox mskDataLancto;
        private System.Windows.Forms.Label lblDataLancto;
        private System.Windows.Forms.GroupBox grbOpcoes;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
    }
}

