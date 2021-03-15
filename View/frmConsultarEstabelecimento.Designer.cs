namespace View
{
    partial class frmConsultarEstabelecimento
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
            this.lblEstabelecimento = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtBxEstabelecimento = new System.Windows.Forms.TextBox();
            this.txtBxCodigo = new System.Windows.Forms.TextBox();
            this.dtGrdVwEstabelecimento = new System.Windows.Forms.DataGridView();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblTotalRegistros = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwEstabelecimento)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(733, 8);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(39, 23);
            this.btnSair.TabIndex = 25;
            this.btnSair.Text = "X";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblEstabelecimento
            // 
            this.lblEstabelecimento.AutoSize = true;
            this.lblEstabelecimento.Location = new System.Drawing.Point(34, 65);
            this.lblEstabelecimento.Name = "lblEstabelecimento";
            this.lblEstabelecimento.Size = new System.Drawing.Size(85, 13);
            this.lblEstabelecimento.TabIndex = 24;
            this.lblEstabelecimento.Text = "Estabelecimento";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(34, 18);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 23;
            this.lblCodigo.Text = "Código";
            // 
            // txtBxEstabelecimento
            // 
            this.txtBxEstabelecimento.Location = new System.Drawing.Point(125, 62);
            this.txtBxEstabelecimento.Name = "txtBxEstabelecimento";
            this.txtBxEstabelecimento.Size = new System.Drawing.Size(305, 20);
            this.txtBxEstabelecimento.TabIndex = 22;
            // 
            // txtBxCodigo
            // 
            this.txtBxCodigo.Location = new System.Drawing.Point(125, 18);
            this.txtBxCodigo.Name = "txtBxCodigo";
            this.txtBxCodigo.ReadOnly = true;
            this.txtBxCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtBxCodigo.TabIndex = 21;
            // 
            // dtGrdVwEstabelecimento
            // 
            this.dtGrdVwEstabelecimento.AllowUserToAddRows = false;
            this.dtGrdVwEstabelecimento.AllowUserToDeleteRows = false;
            this.dtGrdVwEstabelecimento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVwEstabelecimento.Location = new System.Drawing.Point(37, 105);
            this.dtGrdVwEstabelecimento.Name = "dtGrdVwEstabelecimento";
            this.dtGrdVwEstabelecimento.ReadOnly = true;
            this.dtGrdVwEstabelecimento.Size = new System.Drawing.Size(707, 326);
            this.dtGrdVwEstabelecimento.TabIndex = 20;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(445, 60);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(97, 23);
            this.btnPesquisar.TabIndex = 19;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // lblTotalRegistros
            // 
            this.lblTotalRegistros.AutoSize = true;
            this.lblTotalRegistros.Location = new System.Drawing.Point(611, 439);
            this.lblTotalRegistros.Name = "lblTotalRegistros";
            this.lblTotalRegistros.Size = new System.Drawing.Size(96, 13);
            this.lblTotalRegistros.TabIndex = 26;
            this.lblTotalRegistros.Text = "Total de Registros:";
            // 
            // frmConsultarEstabelecimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.lblTotalRegistros);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblEstabelecimento);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtBxEstabelecimento);
            this.Controls.Add(this.txtBxCodigo);
            this.Controls.Add(this.dtGrdVwEstabelecimento);
            this.Controls.Add(this.btnPesquisar);
            this.Name = "frmConsultarEstabelecimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Estabelecimentos";
            this.Load += new System.EventHandler(this.frmConsultarEstabelecimento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwEstabelecimento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblEstabelecimento;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtBxEstabelecimento;
        private System.Windows.Forms.TextBox txtBxCodigo;
        private System.Windows.Forms.DataGridView dtGrdVwEstabelecimento;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblTotalRegistros;
    }
}