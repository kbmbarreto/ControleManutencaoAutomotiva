namespace View
{
    partial class frmCadListaCompras
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
            this.lblExecutado = new System.Windows.Forms.Label();
            this.txtBxExecutado = new System.Windows.Forms.TextBox();
            this.lblQtde = new System.Windows.Forms.Label();
            this.txtBxQtde = new System.Windows.Forms.TextBox();
            this.lblJustCompra = new System.Windows.Forms.Label();
            this.txtBxJustCompra = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblCodComponente = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodComponente = new System.Windows.Forms.TextBox();
            this.txtBxCodigo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dtGrdVwCadListaCompras = new System.Windows.Forms.DataGridView();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwCadListaCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // lblExecutado
            // 
            this.lblExecutado.AutoSize = true;
            this.lblExecutado.Location = new System.Drawing.Point(288, 158);
            this.lblExecutado.Name = "lblExecutado";
            this.lblExecutado.Size = new System.Drawing.Size(58, 13);
            this.lblExecutado.TabIndex = 115;
            this.lblExecutado.Text = "Executado";
            // 
            // txtBxExecutado
            // 
            this.txtBxExecutado.Location = new System.Drawing.Point(399, 155);
            this.txtBxExecutado.Name = "txtBxExecutado";
            this.txtBxExecutado.Size = new System.Drawing.Size(100, 20);
            this.txtBxExecutado.TabIndex = 114;
            // 
            // lblQtde
            // 
            this.lblQtde.AutoSize = true;
            this.lblQtde.Location = new System.Drawing.Point(34, 158);
            this.lblQtde.Name = "lblQtde";
            this.lblQtde.Size = new System.Drawing.Size(62, 13);
            this.lblQtde.TabIndex = 111;
            this.lblQtde.Text = "Quantidade";
            // 
            // txtBxQtde
            // 
            this.txtBxQtde.Location = new System.Drawing.Point(145, 155);
            this.txtBxQtde.Name = "txtBxQtde";
            this.txtBxQtde.Size = new System.Drawing.Size(100, 20);
            this.txtBxQtde.TabIndex = 110;
            // 
            // lblJustCompra
            // 
            this.lblJustCompra.AutoSize = true;
            this.lblJustCompra.Location = new System.Drawing.Point(34, 127);
            this.lblJustCompra.Name = "lblJustCompra";
            this.lblJustCompra.Size = new System.Drawing.Size(88, 13);
            this.lblJustCompra.TabIndex = 109;
            this.lblJustCompra.Text = "Justif. de Compra";
            // 
            // txtBxJustCompra
            // 
            this.txtBxJustCompra.Location = new System.Drawing.Point(145, 124);
            this.txtBxJustCompra.Name = "txtBxJustCompra";
            this.txtBxJustCompra.Size = new System.Drawing.Size(578, 20);
            this.txtBxJustCompra.TabIndex = 108;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(733, 7);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(39, 23);
            this.btnSair.TabIndex = 107;
            this.btnSair.Text = "X";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblCodComponente
            // 
            this.lblCodComponente.AutoSize = true;
            this.lblCodComponente.Location = new System.Drawing.Point(34, 97);
            this.lblCodComponente.Name = "lblCodComponente";
            this.lblCodComponente.Size = new System.Drawing.Size(92, 13);
            this.lblCodComponente.TabIndex = 106;
            this.lblCodComponente.Text = "Cód. Componente";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(34, 62);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 105;
            this.lblCodigo.Text = "Código";
            // 
            // txtCodComponente
            // 
            this.txtCodComponente.Location = new System.Drawing.Point(145, 94);
            this.txtCodComponente.Name = "txtCodComponente";
            this.txtCodComponente.Size = new System.Drawing.Size(100, 20);
            this.txtCodComponente.TabIndex = 104;
            // 
            // txtBxCodigo
            // 
            this.txtBxCodigo.Location = new System.Drawing.Point(145, 59);
            this.txtBxCodigo.Name = "txtBxCodigo";
            this.txtBxCodigo.ReadOnly = true;
            this.txtBxCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtBxCodigo.TabIndex = 103;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(298, 17);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(189, 13);
            this.lblTitulo.TabIndex = 102;
            this.lblTitulo.Text = "Cadastro de Ítens da Lista de Compras";
            // 
            // dtGrdVwCadListaCompras
            // 
            this.dtGrdVwCadListaCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVwCadListaCompras.Location = new System.Drawing.Point(37, 198);
            this.dtGrdVwCadListaCompras.Name = "dtGrdVwCadListaCompras";
            this.dtGrdVwCadListaCompras.Size = new System.Drawing.Size(707, 228);
            this.dtGrdVwCadListaCompras.TabIndex = 101;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(445, 92);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 100;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(648, 92);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 99;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(567, 50);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 98;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(648, 50);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 97;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(567, 92);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 96;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // frmCadListaCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.lblExecutado);
            this.Controls.Add(this.txtBxExecutado);
            this.Controls.Add(this.lblQtde);
            this.Controls.Add(this.txtBxQtde);
            this.Controls.Add(this.lblJustCompra);
            this.Controls.Add(this.txtBxJustCompra);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblCodComponente);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtCodComponente);
            this.Controls.Add(this.txtBxCodigo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dtGrdVwCadListaCompras);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnNovo);
            this.Name = "frmCadListaCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Compras";
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwCadListaCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExecutado;
        private System.Windows.Forms.TextBox txtBxExecutado;
        private System.Windows.Forms.Label lblQtde;
        private System.Windows.Forms.TextBox txtBxQtde;
        private System.Windows.Forms.Label lblJustCompra;
        private System.Windows.Forms.TextBox txtBxJustCompra;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblCodComponente;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodComponente;
        private System.Windows.Forms.TextBox txtBxCodigo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dtGrdVwCadListaCompras;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnNovo;
    }
}