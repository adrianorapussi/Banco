namespace Banco
{
    partial class FormBanco
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
            this.numeroConta = new System.Windows.Forms.TextBox();
            this.saldoConta = new System.Windows.Forms.TextBox();
            this.titularConta = new System.Windows.Forms.TextBox();
            this.valorSobreConta = new System.Windows.Forms.TextBox();
            this.depositarValor = new System.Windows.Forms.Button();
            this.saqueConta = new System.Windows.Forms.Button();
            this.labelTitularConta = new System.Windows.Forms.Label();
            this.labelNumeroConta = new System.Windows.Forms.Label();
            this.labelSaldoConta = new System.Windows.Forms.Label();
            this.labelValorSobreConta = new System.Windows.Forms.Label();
            this.groupBoxConta = new System.Windows.Forms.GroupBox();
            this.groupBoxBuscaConta = new System.Windows.Forms.GroupBox();
            this.buttonBuscarConta = new System.Windows.Forms.Button();
            this.textBoxNumeroContaBuscar = new System.Windows.Forms.TextBox();
            this.labelNumeroContaBuscar = new System.Windows.Forms.Label();
            this.escolhaConta = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxContaCadastrada = new System.Windows.Forms.ComboBox();
            this.buttonNovaConta = new System.Windows.Forms.Button();
            this.groupBoxConta.SuspendLayout();
            this.groupBoxBuscaConta.SuspendLayout();
            this.escolhaConta.SuspendLayout();
            this.SuspendLayout();
            // 
            // numeroConta
            // 
            this.numeroConta.Location = new System.Drawing.Point(100, 50);
            this.numeroConta.Name = "numeroConta";
            this.numeroConta.ReadOnly = true;
            this.numeroConta.Size = new System.Drawing.Size(161, 20);
            this.numeroConta.TabIndex = 2;
            this.numeroConta.TextChanged += new System.EventHandler(this.numeroConta_TextChanged);
            // 
            // saldoConta
            // 
            this.saldoConta.Location = new System.Drawing.Point(100, 76);
            this.saldoConta.Name = "saldoConta";
            this.saldoConta.ReadOnly = true;
            this.saldoConta.Size = new System.Drawing.Size(161, 20);
            this.saldoConta.TabIndex = 3;
            // 
            // titularConta
            // 
            this.titularConta.Location = new System.Drawing.Point(100, 24);
            this.titularConta.Name = "titularConta";
            this.titularConta.ReadOnly = true;
            this.titularConta.Size = new System.Drawing.Size(161, 20);
            this.titularConta.TabIndex = 5;
            // 
            // valorSobreConta
            // 
            this.valorSobreConta.Location = new System.Drawing.Point(100, 119);
            this.valorSobreConta.Name = "valorSobreConta";
            this.valorSobreConta.Size = new System.Drawing.Size(161, 20);
            this.valorSobreConta.TabIndex = 4;
            // 
            // depositarValor
            // 
            this.depositarValor.Location = new System.Drawing.Point(29, 156);
            this.depositarValor.Name = "depositarValor";
            this.depositarValor.Size = new System.Drawing.Size(75, 23);
            this.depositarValor.TabIndex = 4;
            this.depositarValor.Text = "Depositar";
            this.depositarValor.UseVisualStyleBackColor = true;
            this.depositarValor.Click += new System.EventHandler(this.depositarValor_Click);
            // 
            // saqueConta
            // 
            this.saqueConta.Location = new System.Drawing.Point(125, 156);
            this.saqueConta.Name = "saqueConta";
            this.saqueConta.Size = new System.Drawing.Size(75, 23);
            this.saqueConta.TabIndex = 5;
            this.saqueConta.Text = "Sacar";
            this.saqueConta.UseVisualStyleBackColor = true;
            this.saqueConta.Click += new System.EventHandler(this.saqueConta_Click);
            // 
            // labelTitularConta
            // 
            this.labelTitularConta.AutoSize = true;
            this.labelTitularConta.Location = new System.Drawing.Point(6, 31);
            this.labelTitularConta.Name = "labelTitularConta";
            this.labelTitularConta.Size = new System.Drawing.Size(36, 13);
            this.labelTitularConta.TabIndex = 6;
            this.labelTitularConta.Text = "Titular";
            this.labelTitularConta.Click += new System.EventHandler(this.labelTitularConta_Click);
            // 
            // labelNumeroConta
            // 
            this.labelNumeroConta.AutoSize = true;
            this.labelNumeroConta.Location = new System.Drawing.Point(6, 57);
            this.labelNumeroConta.Name = "labelNumeroConta";
            this.labelNumeroConta.Size = new System.Drawing.Size(44, 13);
            this.labelNumeroConta.TabIndex = 7;
            this.labelNumeroConta.Text = "Numero";
            // 
            // labelSaldoConta
            // 
            this.labelSaldoConta.AutoSize = true;
            this.labelSaldoConta.Location = new System.Drawing.Point(6, 83);
            this.labelSaldoConta.Name = "labelSaldoConta";
            this.labelSaldoConta.Size = new System.Drawing.Size(34, 13);
            this.labelSaldoConta.TabIndex = 8;
            this.labelSaldoConta.Text = "Saldo";
            // 
            // labelValorSobreConta
            // 
            this.labelValorSobreConta.AutoSize = true;
            this.labelValorSobreConta.Location = new System.Drawing.Point(6, 126);
            this.labelValorSobreConta.Name = "labelValorSobreConta";
            this.labelValorSobreConta.Size = new System.Drawing.Size(31, 13);
            this.labelValorSobreConta.TabIndex = 9;
            this.labelValorSobreConta.Text = "Valor";
            // 
            // groupBoxConta
            // 
            this.groupBoxConta.Controls.Add(this.labelTitularConta);
            this.groupBoxConta.Controls.Add(this.saqueConta);
            this.groupBoxConta.Controls.Add(this.labelValorSobreConta);
            this.groupBoxConta.Controls.Add(this.depositarValor);
            this.groupBoxConta.Controls.Add(this.titularConta);
            this.groupBoxConta.Controls.Add(this.labelSaldoConta);
            this.groupBoxConta.Controls.Add(this.labelNumeroConta);
            this.groupBoxConta.Controls.Add(this.valorSobreConta);
            this.groupBoxConta.Controls.Add(this.numeroConta);
            this.groupBoxConta.Controls.Add(this.saldoConta);
            this.groupBoxConta.Location = new System.Drawing.Point(12, 114);
            this.groupBoxConta.Name = "groupBoxConta";
            this.groupBoxConta.Size = new System.Drawing.Size(267, 187);
            this.groupBoxConta.TabIndex = 10;
            this.groupBoxConta.TabStop = false;
            this.groupBoxConta.Text = "Conta";
            // 
            // groupBoxBuscaConta
            // 
            this.groupBoxBuscaConta.Controls.Add(this.buttonBuscarConta);
            this.groupBoxBuscaConta.Controls.Add(this.textBoxNumeroContaBuscar);
            this.groupBoxBuscaConta.Controls.Add(this.labelNumeroContaBuscar);
            this.groupBoxBuscaConta.Location = new System.Drawing.Point(12, 13);
            this.groupBoxBuscaConta.Name = "groupBoxBuscaConta";
            this.groupBoxBuscaConta.Size = new System.Drawing.Size(267, 100);
            this.groupBoxBuscaConta.TabIndex = 11;
            this.groupBoxBuscaConta.TabStop = false;
            this.groupBoxBuscaConta.Text = "Busca de Conta";
            // 
            // buttonBuscarConta
            // 
            this.buttonBuscarConta.Location = new System.Drawing.Point(124, 64);
            this.buttonBuscarConta.Name = "buttonBuscarConta";
            this.buttonBuscarConta.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscarConta.TabIndex = 2;
            this.buttonBuscarConta.Text = "Buscar";
            this.buttonBuscarConta.UseVisualStyleBackColor = true;
            this.buttonBuscarConta.Click += new System.EventHandler(this.buttonBuscarConta_Click);
            // 
            // textBoxNumeroContaBuscar
            // 
            this.textBoxNumeroContaBuscar.Location = new System.Drawing.Point(100, 37);
            this.textBoxNumeroContaBuscar.Name = "textBoxNumeroContaBuscar";
            this.textBoxNumeroContaBuscar.Size = new System.Drawing.Size(161, 20);
            this.textBoxNumeroContaBuscar.TabIndex = 1;
            // 
            // labelNumeroContaBuscar
            // 
            this.labelNumeroContaBuscar.AutoSize = true;
            this.labelNumeroContaBuscar.Location = new System.Drawing.Point(9, 37);
            this.labelNumeroContaBuscar.Name = "labelNumeroContaBuscar";
            this.labelNumeroContaBuscar.Size = new System.Drawing.Size(89, 13);
            this.labelNumeroContaBuscar.TabIndex = 0;
            this.labelNumeroContaBuscar.Text = "Número da conta";
            // 
            // escolhaConta
            // 
            this.escolhaConta.Controls.Add(this.label1);
            this.escolhaConta.Controls.Add(this.comboBoxContaCadastrada);
            this.escolhaConta.Location = new System.Drawing.Point(286, 13);
            this.escolhaConta.Name = "escolhaConta";
            this.escolhaConta.Size = new System.Drawing.Size(200, 100);
            this.escolhaConta.TabIndex = 12;
            this.escolhaConta.TabStop = false;
            this.escolhaConta.Text = "Contas cadastradas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Conta";
            // 
            // comboBoxContaCadastrada
            // 
            this.comboBoxContaCadastrada.FormattingEnabled = true;
            this.comboBoxContaCadastrada.Location = new System.Drawing.Point(48, 44);
            this.comboBoxContaCadastrada.Name = "comboBoxContaCadastrada";
            this.comboBoxContaCadastrada.Size = new System.Drawing.Size(146, 21);
            this.comboBoxContaCadastrada.TabIndex = 0;
            this.comboBoxContaCadastrada.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonNovaConta
            // 
            this.buttonNovaConta.Location = new System.Drawing.Point(12, 319);
            this.buttonNovaConta.Name = "buttonNovaConta";
            this.buttonNovaConta.Size = new System.Drawing.Size(75, 23);
            this.buttonNovaConta.TabIndex = 13;
            this.buttonNovaConta.Text = "Nova Conta";
            this.buttonNovaConta.UseVisualStyleBackColor = true;
            this.buttonNovaConta.Click += new System.EventHandler(this.buttonNovaConta_Click);
            // 
            // FormBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 364);
            this.Controls.Add(this.buttonNovaConta);
            this.Controls.Add(this.escolhaConta);
            this.Controls.Add(this.groupBoxBuscaConta);
            this.Controls.Add(this.groupBoxConta);
            this.Name = "FormBanco";
            this.Text = "Banco";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxConta.ResumeLayout(false);
            this.groupBoxConta.PerformLayout();
            this.groupBoxBuscaConta.ResumeLayout(false);
            this.groupBoxBuscaConta.PerformLayout();
            this.escolhaConta.ResumeLayout(false);
            this.escolhaConta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox numeroConta;
        private System.Windows.Forms.TextBox saldoConta;
        private System.Windows.Forms.TextBox titularConta;
        private System.Windows.Forms.TextBox valorSobreConta;
        private System.Windows.Forms.Button depositarValor;
        private System.Windows.Forms.Button saqueConta;
        private System.Windows.Forms.Label labelTitularConta;
        private System.Windows.Forms.Label labelNumeroConta;
        private System.Windows.Forms.Label labelSaldoConta;
        private System.Windows.Forms.Label labelValorSobreConta;
        private System.Windows.Forms.GroupBox groupBoxConta;
        private System.Windows.Forms.GroupBox groupBoxBuscaConta;
        private System.Windows.Forms.Label labelNumeroContaBuscar;
        private System.Windows.Forms.Button buttonBuscarConta;
        private System.Windows.Forms.TextBox textBoxNumeroContaBuscar;
        private System.Windows.Forms.GroupBox escolhaConta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxContaCadastrada;
        private System.Windows.Forms.Button buttonNovaConta;
    }
}

