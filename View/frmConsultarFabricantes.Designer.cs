namespace View
{
    partial class frmConsultarFabricantes
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
            this.lblFabricante = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtBxFabricante = new System.Windows.Forms.TextBox();
            this.txtBxCodigo = new System.Windows.Forms.TextBox();
            this.dtGrdVwFabricante = new System.Windows.Forms.DataGridView();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblTotalRegistros = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwFabricante)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(732, 8);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(39, 23);
            this.btnSair.TabIndex = 32;
            this.btnSair.Text = "X";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblFabricante
            // 
            this.lblFabricante.AutoSize = true;
            this.lblFabricante.Location = new System.Drawing.Point(33, 65);
            this.lblFabricante.Name = "lblFabricante";
            this.lblFabricante.Size = new System.Drawing.Size(57, 13);
            this.lblFabricante.TabIndex = 31;
            this.lblFabricante.Text = "Fabricante";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(33, 18);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 30;
            this.lblCodigo.Text = "Código";
            // 
            // txtBxFabricante
            // 
            this.txtBxFabricante.Location = new System.Drawing.Point(124, 62);
            this.txtBxFabricante.Name = "txtBxFabricante";
            this.txtBxFabricante.Size = new System.Drawing.Size(305, 20);
            this.txtBxFabricante.TabIndex = 29;
            // 
            // txtBxCodigo
            // 
            this.txtBxCodigo.Location = new System.Drawing.Point(124, 18);
            this.txtBxCodigo.Name = "txtBxCodigo";
            this.txtBxCodigo.ReadOnly = true;
            this.txtBxCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtBxCodigo.TabIndex = 28;
            // 
            // dtGrdVwFabricante
            // 
            this.dtGrdVwFabricante.AllowUserToAddRows = false;
            this.dtGrdVwFabricante.AllowUserToDeleteRows = false;
            this.dtGrdVwFabricante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVwFabricante.Location = new System.Drawing.Point(36, 105);
            this.dtGrdVwFabricante.Name = "dtGrdVwFabricante";
            this.dtGrdVwFabricante.ReadOnly = true;
            this.dtGrdVwFabricante.Size = new System.Drawing.Size(707, 326);
            this.dtGrdVwFabricante.TabIndex = 27;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(444, 60);
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
            this.lblTotalRegistros.Location = new System.Drawing.Point(602, 439);
            this.lblTotalRegistros.Name = "lblTotalRegistros";
            this.lblTotalRegistros.Size = new System.Drawing.Size(96, 13);
            this.lblTotalRegistros.TabIndex = 33;
            this.lblTotalRegistros.Text = "Total de Registros:";
            // 
            // frmConsultarFabricantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.lblTotalRegistros);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblFabricante);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtBxFabricante);
            this.Controls.Add(this.txtBxCodigo);
            this.Controls.Add(this.dtGrdVwFabricante);
            this.Controls.Add(this.btnPesquisar);
            this.Name = "frmConsultarFabricantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Fabricantes";
            this.Load += new System.EventHandler(this.frmConsultarFabricantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwFabricante)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblFabricante;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtBxFabricante;
        private System.Windows.Forms.TextBox txtBxCodigo;
        private System.Windows.Forms.DataGridView dtGrdVwFabricante;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblTotalRegistros;
    }
}