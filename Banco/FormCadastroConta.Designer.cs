namespace Banco
{
    partial class FormCadastroConta
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
            this.textBoxNomeCadastroConta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCriarConta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNomeCadastroConta
            // 
            this.textBoxNomeCadastroConta.Location = new System.Drawing.Point(91, 87);
            this.textBoxNomeCadastroConta.Name = "textBoxNomeCadastroConta";
            this.textBoxNomeCadastroConta.Size = new System.Drawing.Size(100, 20);
            this.textBoxNomeCadastroConta.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // buttonCriarConta
            // 
            this.buttonCriarConta.Location = new System.Drawing.Point(91, 191);
            this.buttonCriarConta.Name = "buttonCriarConta";
            this.buttonCriarConta.Size = new System.Drawing.Size(75, 23);
            this.buttonCriarConta.TabIndex = 2;
            this.buttonCriarConta.Text = "Criar";
            this.buttonCriarConta.UseVisualStyleBackColor = true;
            this.buttonCriarConta.Click += new System.EventHandler(this.buttonCriarConta_Click);
            // 
            // FormCadastroConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.buttonCriarConta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNomeCadastroConta);
            this.Name = "FormCadastroConta";
            this.Text = "Cadastro de nova conta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNomeCadastroConta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCriarConta;
    }
}