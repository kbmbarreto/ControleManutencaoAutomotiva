namespace View
{
    partial class frmConsultarComponentes
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
            this.lblComponente = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtBxComponente = new System.Windows.Forms.TextBox();
            this.txtBxCodigo = new System.Windows.Forms.TextBox();
            this.dtGrdVwComponentes = new System.Windows.Forms.DataGridView();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblTotalRegistros = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwComponentes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(735, 8);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(39, 23);
            this.btnSair.TabIndex = 18;
            this.btnSair.Text = "X";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblComponente
            // 
            this.lblComponente.AutoSize = true;
            this.lblComponente.Location = new System.Drawing.Point(36, 65);
            this.lblComponente.Name = "lblComponente";
            this.lblComponente.Size = new System.Drawing.Size(67, 13);
            this.lblComponente.TabIndex = 17;
            this.lblComponente.Text = "Componente";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(36, 18);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 16;
            this.lblCodigo.Text = "Código";
            // 
            // txtBxComponente
            // 
            this.txtBxComponente.Location = new System.Drawing.Point(118, 62);
            this.txtBxComponente.Name = "txtBxComponente";
            this.txtBxComponente.Size = new System.Drawing.Size(314, 20);
            this.txtBxComponente.TabIndex = 15;
            this.txtBxComponente.TextChanged += new System.EventHandler(this.txtBxComponente_TextChanged);
            // 
            // txtBxCodigo
            // 
            this.txtBxCodigo.Location = new System.Drawing.Point(118, 18);
            this.txtBxCodigo.Name = "txtBxCodigo";
            this.txtBxCodigo.ReadOnly = true;
            this.txtBxCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtBxCodigo.TabIndex = 14;
            // 
            // dtGrdVwComponentes
            // 
            this.dtGrdVwComponentes.AllowUserToAddRows = false;
            this.dtGrdVwComponentes.AllowUserToDeleteRows = false;
            this.dtGrdVwComponentes.AllowUserToOrderColumns = true;
            this.dtGrdVwComponentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVwComponentes.Location = new System.Drawing.Point(39, 105);
            this.dtGrdVwComponentes.Name = "dtGrdVwComponentes";
            this.dtGrdVwComponentes.ReadOnly = true;
            this.dtGrdVwComponentes.Size = new System.Drawing.Size(707, 326);
            this.dtGrdVwComponentes.TabIndex = 13;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(447, 60);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(97, 23);
            this.btnPesquisar.TabIndex = 12;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // lblTotalRegistros
            // 
            this.lblTotalRegistros.AutoSize = true;
            this.lblTotalRegistros.Location = new System.Drawing.Point(616, 440);
            this.lblTotalRegistros.Name = "lblTotalRegistros";
            this.lblTotalRegistros.Size = new System.Drawing.Size(96, 13);
            this.lblTotalRegistros.TabIndex = 19;
            this.lblTotalRegistros.Text = "Total de Registros:";
            // 
            // frmConsultarComponentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.lblTotalRegistros);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblComponente);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtBxComponente);
            this.Controls.Add(this.txtBxCodigo);
            this.Controls.Add(this.dtGrdVwComponentes);
            this.Controls.Add(this.btnPesquisar);
            this.Name = "frmConsultarComponentes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Componentes (Peças e Serviços)";
            this.Load += new System.EventHandler(this.frmConsultarComponentes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwComponentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblComponente;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtBxComponente;
        private System.Windows.Forms.TextBox txtBxCodigo;
        private System.Windows.Forms.DataGridView dtGrdVwComponentes;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblTotalRegistros;
    }
}