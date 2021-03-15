namespace View
{
    partial class frmCadVeiculos
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
            this.lblApelido = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtBxApelido = new System.Windows.Forms.TextBox();
            this.txtBxCodigo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dtGrdVwCadManutencoes = new System.Windows.Forms.DataGridView();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.lblMontadora = new System.Windows.Forms.Label();
            this.txtBxMontadora = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtBxModelo = new System.Windows.Forms.TextBox();
            this.lblAno = new System.Windows.Forms.Label();
            this.txtBxAno = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwCadManutencoes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(740, 10);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(39, 23);
            this.btnSair.TabIndex = 35;
            this.btnSair.Text = "X";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblApelido
            // 
            this.lblApelido.AutoSize = true;
            this.lblApelido.Location = new System.Drawing.Point(41, 100);
            this.lblApelido.Name = "lblApelido";
            this.lblApelido.Size = new System.Drawing.Size(42, 13);
            this.lblApelido.TabIndex = 34;
            this.lblApelido.Text = "Apelido";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(41, 65);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 33;
            this.lblCodigo.Text = "Código";
            // 
            // txtBxApelido
            // 
            this.txtBxApelido.Location = new System.Drawing.Point(152, 97);
            this.txtBxApelido.Name = "txtBxApelido";
            this.txtBxApelido.Size = new System.Drawing.Size(285, 20);
            this.txtBxApelido.TabIndex = 32;
            // 
            // txtBxCodigo
            // 
            this.txtBxCodigo.Location = new System.Drawing.Point(152, 62);
            this.txtBxCodigo.Name = "txtBxCodigo";
            this.txtBxCodigo.ReadOnly = true;
            this.txtBxCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtBxCodigo.TabIndex = 31;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(348, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(109, 13);
            this.lblTitulo.TabIndex = 30;
            this.lblTitulo.Text = "Cadastro de Veículos";
            // 
            // dtGrdVwCadManutencoes
            // 
            this.dtGrdVwCadManutencoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVwCadManutencoes.Location = new System.Drawing.Point(44, 205);
            this.dtGrdVwCadManutencoes.Name = "dtGrdVwCadManutencoes";
            this.dtGrdVwCadManutencoes.Size = new System.Drawing.Size(707, 224);
            this.dtGrdVwCadManutencoes.TabIndex = 29;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(452, 95);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 28;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(655, 95);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 27;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(574, 53);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 26;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(655, 53);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 25;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(574, 95);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 24;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // lblMontadora
            // 
            this.lblMontadora.AutoSize = true;
            this.lblMontadora.Location = new System.Drawing.Point(41, 130);
            this.lblMontadora.Name = "lblMontadora";
            this.lblMontadora.Size = new System.Drawing.Size(58, 13);
            this.lblMontadora.TabIndex = 37;
            this.lblMontadora.Text = "Montadora";
            // 
            // txtBxMontadora
            // 
            this.txtBxMontadora.Location = new System.Drawing.Point(152, 127);
            this.txtBxMontadora.Name = "txtBxMontadora";
            this.txtBxMontadora.Size = new System.Drawing.Size(285, 20);
            this.txtBxMontadora.TabIndex = 36;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(41, 161);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(42, 13);
            this.lblModelo.TabIndex = 39;
            this.lblModelo.Text = "Modelo";
            // 
            // txtBxModelo
            // 
            this.txtBxModelo.Location = new System.Drawing.Point(152, 158);
            this.txtBxModelo.Name = "txtBxModelo";
            this.txtBxModelo.Size = new System.Drawing.Size(285, 20);
            this.txtBxModelo.TabIndex = 38;
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Location = new System.Drawing.Point(463, 161);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(26, 13);
            this.lblAno.TabIndex = 41;
            this.lblAno.Text = "Ano";
            // 
            // txtBxAno
            // 
            this.txtBxAno.Location = new System.Drawing.Point(574, 158);
            this.txtBxAno.Name = "txtBxAno";
            this.txtBxAno.Size = new System.Drawing.Size(177, 20);
            this.txtBxAno.TabIndex = 40;
            // 
            // frmCadVeiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.txtBxAno);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.txtBxModelo);
            this.Controls.Add(this.lblMontadora);
            this.Controls.Add(this.txtBxMontadora);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblApelido);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtBxApelido);
            this.Controls.Add(this.txtBxCodigo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dtGrdVwCadManutencoes);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnNovo);
            this.Name = "frmCadVeiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Veículos";
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwCadManutencoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblApelido;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtBxApelido;
        private System.Windows.Forms.TextBox txtBxCodigo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dtGrdVwCadManutencoes;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label lblMontadora;
        private System.Windows.Forms.TextBox txtBxMontadora;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtBxModelo;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.TextBox txtBxAno;
    }
}