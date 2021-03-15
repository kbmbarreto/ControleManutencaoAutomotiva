namespace View
{
    partial class frmConsultarVeiculos
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
            this.btnSair = new System.Windows.Forms.Button();
            this.lblVeiculo = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtBxVeiculo = new System.Windows.Forms.TextBox();
            this.txtBxCodigo = new System.Windows.Forms.TextBox();
            this.dtGrdVwVeiculo = new System.Windows.Forms.DataGridView();
            this.btnPesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwVeiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(733, 8);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(39, 23);
            this.btnSair.TabIndex = 46;
            this.btnSair.Text = "X";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblVeiculo
            // 
            this.lblVeiculo.AutoSize = true;
            this.lblVeiculo.Location = new System.Drawing.Point(34, 65);
            this.lblVeiculo.Name = "lblVeiculo";
            this.lblVeiculo.Size = new System.Drawing.Size(44, 13);
            this.lblVeiculo.TabIndex = 45;
            this.lblVeiculo.Text = "Veículo";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(34, 18);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 44;
            this.lblCodigo.Text = "Código";
            // 
            // txtBxVeiculo
            // 
            this.txtBxVeiculo.Location = new System.Drawing.Point(125, 62);
            this.txtBxVeiculo.Name = "txtBxVeiculo";
            this.txtBxVeiculo.Size = new System.Drawing.Size(305, 20);
            this.txtBxVeiculo.TabIndex = 43;
            // 
            // txtBxCodigo
            // 
            this.txtBxCodigo.Location = new System.Drawing.Point(125, 18);
            this.txtBxCodigo.Name = "txtBxCodigo";
            this.txtBxCodigo.ReadOnly = true;
            this.txtBxCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtBxCodigo.TabIndex = 42;
            // 
            // dtGrdVwVeiculo
            // 
            this.dtGrdVwVeiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVwVeiculo.Location = new System.Drawing.Point(37, 105);
            this.dtGrdVwVeiculo.Name = "dtGrdVwVeiculo";
            this.dtGrdVwVeiculo.Size = new System.Drawing.Size(707, 326);
            this.dtGrdVwVeiculo.TabIndex = 41;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(445, 60);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(97, 23);
            this.btnPesquisar.TabIndex = 40;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // frmConsultarVeiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblVeiculo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtBxVeiculo);
            this.Controls.Add(this.txtBxCodigo);
            this.Controls.Add(this.dtGrdVwVeiculo);
            this.Controls.Add(this.btnPesquisar);
            this.Name = "frmConsultarVeiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Veículos";
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwVeiculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblVeiculo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtBxVeiculo;
        private System.Windows.Forms.TextBox txtBxCodigo;
        private System.Windows.Forms.DataGridView dtGrdVwVeiculo;
        private System.Windows.Forms.Button btnPesquisar;
    }
}