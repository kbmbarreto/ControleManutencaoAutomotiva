namespace View
{
    partial class frmConsultarManutencoes
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtBxCodigo = new System.Windows.Forms.TextBox();
            this.dtGrdVwManutencoes = new System.Windows.Forms.DataGridView();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblTotalRegistros = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwManutencoes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(933, 7);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(39, 23);
            this.btnSair.TabIndex = 32;
            this.btnSair.Text = "X";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(34, 17);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 30;
            this.lblCodigo.Text = "Código";
            // 
            // txtBxCodigo
            // 
            this.txtBxCodigo.Location = new System.Drawing.Point(125, 17);
            this.txtBxCodigo.Name = "txtBxCodigo";
            this.txtBxCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtBxCodigo.TabIndex = 28;
            // 
            // dtGrdVwManutencoes
            // 
            this.dtGrdVwManutencoes.AllowUserToAddRows = false;
            this.dtGrdVwManutencoes.AllowUserToDeleteRows = false;
            this.dtGrdVwManutencoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVwManutencoes.Location = new System.Drawing.Point(37, 56);
            this.dtGrdVwManutencoes.Name = "dtGrdVwManutencoes";
            this.dtGrdVwManutencoes.ReadOnly = true;
            this.dtGrdVwManutencoes.Size = new System.Drawing.Size(911, 568);
            this.dtGrdVwManutencoes.TabIndex = 27;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(246, 15);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(97, 23);
            this.btnPesquisar.TabIndex = 26;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // lblTotalRegistros
            // 
            this.lblTotalRegistros.AutoSize = true;
            this.lblTotalRegistros.Location = new System.Drawing.Point(775, 639);
            this.lblTotalRegistros.Name = "lblTotalRegistros";
            this.lblTotalRegistros.Size = new System.Drawing.Size(96, 13);
            this.lblTotalRegistros.TabIndex = 34;
            this.lblTotalRegistros.Text = "Total de Registros:";
            // 
            // frmConsultarManutencoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.lblTotalRegistros);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtBxCodigo);
            this.Controls.Add(this.dtGrdVwManutencoes);
            this.Controls.Add(this.btnPesquisar);
            this.Name = "frmConsultarManutencoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Manutenções Realizadas";
            this.Load += new System.EventHandler(this.frmConsultarManutencoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwManutencoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtBxCodigo;
        private System.Windows.Forms.DataGridView dtGrdVwManutencoes;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblTotalRegistros;
    }
}