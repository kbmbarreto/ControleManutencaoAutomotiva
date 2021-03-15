namespace View
{
    partial class frmCadEstabelecimento
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dtGrdVwCadEstabelecimento = new System.Windows.Forms.DataGridView();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwCadEstabelecimento)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(728, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(39, 23);
            this.btnSair.TabIndex = 23;
            this.btnSair.Text = "X";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblEstabelecimento
            // 
            this.lblEstabelecimento.AutoSize = true;
            this.lblEstabelecimento.Location = new System.Drawing.Point(29, 102);
            this.lblEstabelecimento.Name = "lblEstabelecimento";
            this.lblEstabelecimento.Size = new System.Drawing.Size(85, 13);
            this.lblEstabelecimento.TabIndex = 22;
            this.lblEstabelecimento.Text = "Estabelecimento";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(29, 55);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 21;
            this.lblCodigo.Text = "Código";
            // 
            // txtBxEstabelecimento
            // 
            this.txtBxEstabelecimento.Location = new System.Drawing.Point(120, 99);
            this.txtBxEstabelecimento.Name = "txtBxEstabelecimento";
            this.txtBxEstabelecimento.Size = new System.Drawing.Size(305, 20);
            this.txtBxEstabelecimento.TabIndex = 20;
            // 
            // txtBxCodigo
            // 
            this.txtBxCodigo.Location = new System.Drawing.Point(120, 52);
            this.txtBxCodigo.Name = "txtBxCodigo";
            this.txtBxCodigo.ReadOnly = true;
            this.txtBxCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtBxCodigo.TabIndex = 19;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(345, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(150, 13);
            this.lblTitulo.TabIndex = 18;
            this.lblTitulo.Text = "Cadastro de Estabelecimentos";
            // 
            // dtGrdVwCadEstabelecimento
            // 
            this.dtGrdVwCadEstabelecimento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVwCadEstabelecimento.Location = new System.Drawing.Point(32, 155);
            this.dtGrdVwCadEstabelecimento.Name = "dtGrdVwCadEstabelecimento";
            this.dtGrdVwCadEstabelecimento.Size = new System.Drawing.Size(707, 272);
            this.dtGrdVwCadEstabelecimento.TabIndex = 17;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(440, 97);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 16;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(643, 97);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(562, 55);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 14;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(643, 55);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 13;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(562, 97);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 12;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // frmCadEstabelecimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblEstabelecimento);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtBxEstabelecimento);
            this.Controls.Add(this.txtBxCodigo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dtGrdVwCadEstabelecimento);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnNovo);
            this.Name = "frmCadEstabelecimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Estabelecimentos";
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwCadEstabelecimento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblEstabelecimento;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtBxEstabelecimento;
        private System.Windows.Forms.TextBox txtBxCodigo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dtGrdVwCadEstabelecimento;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnNovo;
    }
}