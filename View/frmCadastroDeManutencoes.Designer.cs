namespace View
{
    partial class frmCadastroDeManutencoes
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
            this.lblKmProxTroca = new System.Windows.Forms.Label();
            this.txtBxKmProxTroca = new System.Windows.Forms.TextBox();
            this.lblDataManutencao = new System.Windows.Forms.Label();
            this.txtBxDataManutencao = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblKm = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtBxKm = new System.Windows.Forms.TextBox();
            this.txtBxCodigo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dtGrdVwCadTipoManutencao = new System.Windows.Forms.DataGridView();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtBxValor = new System.Windows.Forms.TextBox();
            this.lblCodTipoManutencao = new System.Windows.Forms.Label();
            this.txtBxCodTpManutencao = new System.Windows.Forms.TextBox();
            this.lblCodFabricante = new System.Windows.Forms.Label();
            this.txtBxCodFabricante = new System.Windows.Forms.TextBox();
            this.lblCodVeiculo = new System.Windows.Forms.Label();
            this.txtBxCodVeiculo = new System.Windows.Forms.TextBox();
            this.lblCodComponente = new System.Windows.Forms.Label();
            this.txtBxCodComponente = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwCadTipoManutencao)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKmProxTroca
            // 
            this.lblKmProxTroca.AutoSize = true;
            this.lblKmProxTroca.Location = new System.Drawing.Point(34, 163);
            this.lblKmProxTroca.Name = "lblKmProxTroca";
            this.lblKmProxTroca.Size = new System.Drawing.Size(90, 13);
            this.lblKmProxTroca.TabIndex = 57;
            this.lblKmProxTroca.Text = "Km da próx. troca";
            // 
            // txtBxKmProxTroca
            // 
            this.txtBxKmProxTroca.Location = new System.Drawing.Point(145, 160);
            this.txtBxKmProxTroca.Name = "txtBxKmProxTroca";
            this.txtBxKmProxTroca.Size = new System.Drawing.Size(100, 20);
            this.txtBxKmProxTroca.TabIndex = 56;
            // 
            // lblDataManutencao
            // 
            this.lblDataManutencao.AutoSize = true;
            this.lblDataManutencao.Location = new System.Drawing.Point(34, 132);
            this.lblDataManutencao.Name = "lblDataManutencao";
            this.lblDataManutencao.Size = new System.Drawing.Size(108, 13);
            this.lblDataManutencao.TabIndex = 55;
            this.lblDataManutencao.Text = "Data de Manutenção";
            // 
            // txtBxDataManutencao
            // 
            this.txtBxDataManutencao.Location = new System.Drawing.Point(145, 129);
            this.txtBxDataManutencao.Name = "txtBxDataManutencao";
            this.txtBxDataManutencao.Size = new System.Drawing.Size(100, 20);
            this.txtBxDataManutencao.TabIndex = 54;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(733, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(39, 23);
            this.btnSair.TabIndex = 53;
            this.btnSair.Text = "X";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblKm
            // 
            this.lblKm.AutoSize = true;
            this.lblKm.Location = new System.Drawing.Point(34, 102);
            this.lblKm.Name = "lblKm";
            this.lblKm.Size = new System.Drawing.Size(22, 13);
            this.lblKm.TabIndex = 52;
            this.lblKm.Text = "Km";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(34, 67);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 51;
            this.lblCodigo.Text = "Código";
            // 
            // txtBxKm
            // 
            this.txtBxKm.Location = new System.Drawing.Point(145, 99);
            this.txtBxKm.Name = "txtBxKm";
            this.txtBxKm.Size = new System.Drawing.Size(100, 20);
            this.txtBxKm.TabIndex = 50;
            // 
            // txtBxCodigo
            // 
            this.txtBxCodigo.Location = new System.Drawing.Point(145, 64);
            this.txtBxCodigo.Name = "txtBxCodigo";
            this.txtBxCodigo.ReadOnly = true;
            this.txtBxCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtBxCodigo.TabIndex = 49;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(341, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(132, 13);
            this.lblTitulo.TabIndex = 48;
            this.lblTitulo.Text = "Cadastro de Manutenções";
            // 
            // dtGrdVwCadTipoManutencao
            // 
            this.dtGrdVwCadTipoManutencao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVwCadTipoManutencao.Location = new System.Drawing.Point(37, 248);
            this.dtGrdVwCadTipoManutencao.Name = "dtGrdVwCadTipoManutencao";
            this.dtGrdVwCadTipoManutencao.Size = new System.Drawing.Size(707, 183);
            this.dtGrdVwCadTipoManutencao.TabIndex = 47;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(445, 97);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 46;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(648, 97);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 45;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(567, 55);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 44;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(648, 55);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 43;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(567, 97);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 42;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(34, 195);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(54, 13);
            this.lblValor.TabIndex = 61;
            this.lblValor.Text = "Valor (R$)";
            // 
            // txtBxValor
            // 
            this.txtBxValor.Location = new System.Drawing.Point(145, 192);
            this.txtBxValor.Name = "txtBxValor";
            this.txtBxValor.Size = new System.Drawing.Size(100, 20);
            this.txtBxValor.TabIndex = 60;
            // 
            // lblCodTipoManutencao
            // 
            this.lblCodTipoManutencao.AutoSize = true;
            this.lblCodTipoManutencao.Location = new System.Drawing.Point(271, 195);
            this.lblCodTipoManutencao.Name = "lblCodTipoManutencao";
            this.lblCodTipoManutencao.Size = new System.Drawing.Size(131, 13);
            this.lblCodTipoManutencao.TabIndex = 65;
            this.lblCodTipoManutencao.Text = "Cód. Tipo de Manutenção";
            // 
            // txtBxCodTpManutencao
            // 
            this.txtBxCodTpManutencao.Location = new System.Drawing.Point(407, 192);
            this.txtBxCodTpManutencao.Name = "txtBxCodTpManutencao";
            this.txtBxCodTpManutencao.Size = new System.Drawing.Size(100, 20);
            this.txtBxCodTpManutencao.TabIndex = 64;
            // 
            // lblCodFabricante
            // 
            this.lblCodFabricante.AutoSize = true;
            this.lblCodFabricante.Location = new System.Drawing.Point(271, 163);
            this.lblCodFabricante.Name = "lblCodFabricante";
            this.lblCodFabricante.Size = new System.Drawing.Size(115, 13);
            this.lblCodFabricante.TabIndex = 63;
            this.lblCodFabricante.Text = "Cód. Fabricante (peça)";
            // 
            // txtBxCodFabricante
            // 
            this.txtBxCodFabricante.Location = new System.Drawing.Point(407, 160);
            this.txtBxCodFabricante.Name = "txtBxCodFabricante";
            this.txtBxCodFabricante.Size = new System.Drawing.Size(100, 20);
            this.txtBxCodFabricante.TabIndex = 62;
            // 
            // lblCodVeiculo
            // 
            this.lblCodVeiculo.AutoSize = true;
            this.lblCodVeiculo.Location = new System.Drawing.Point(532, 195);
            this.lblCodVeiculo.Name = "lblCodVeiculo";
            this.lblCodVeiculo.Size = new System.Drawing.Size(69, 13);
            this.lblCodVeiculo.TabIndex = 69;
            this.lblCodVeiculo.Text = "Cód. Veículo";
            // 
            // txtBxCodVeiculo
            // 
            this.txtBxCodVeiculo.Location = new System.Drawing.Point(643, 192);
            this.txtBxCodVeiculo.Name = "txtBxCodVeiculo";
            this.txtBxCodVeiculo.Size = new System.Drawing.Size(100, 20);
            this.txtBxCodVeiculo.TabIndex = 68;
            // 
            // lblCodComponente
            // 
            this.lblCodComponente.AutoSize = true;
            this.lblCodComponente.Location = new System.Drawing.Point(532, 163);
            this.lblCodComponente.Name = "lblCodComponente";
            this.lblCodComponente.Size = new System.Drawing.Size(92, 13);
            this.lblCodComponente.TabIndex = 67;
            this.lblCodComponente.Text = "Cód. Componente";
            // 
            // txtBxCodComponente
            // 
            this.txtBxCodComponente.Location = new System.Drawing.Point(643, 160);
            this.txtBxCodComponente.Name = "txtBxCodComponente";
            this.txtBxCodComponente.Size = new System.Drawing.Size(100, 20);
            this.txtBxCodComponente.TabIndex = 66;
            // 
            // frmCadastroDeManutencoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.lblCodVeiculo);
            this.Controls.Add(this.txtBxCodVeiculo);
            this.Controls.Add(this.lblCodComponente);
            this.Controls.Add(this.txtBxCodComponente);
            this.Controls.Add(this.lblCodTipoManutencao);
            this.Controls.Add(this.txtBxCodTpManutencao);
            this.Controls.Add(this.lblCodFabricante);
            this.Controls.Add(this.txtBxCodFabricante);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.txtBxValor);
            this.Controls.Add(this.lblKmProxTroca);
            this.Controls.Add(this.txtBxKmProxTroca);
            this.Controls.Add(this.lblDataManutencao);
            this.Controls.Add(this.txtBxDataManutencao);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblKm);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtBxKm);
            this.Controls.Add(this.txtBxCodigo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dtGrdVwCadTipoManutencao);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnNovo);
            this.Name = "frmCadastroDeManutencoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Histórico de Manutenções";
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwCadTipoManutencao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblKmProxTroca;
        private System.Windows.Forms.TextBox txtBxKmProxTroca;
        private System.Windows.Forms.Label lblDataManutencao;
        private System.Windows.Forms.TextBox txtBxDataManutencao;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblKm;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtBxKm;
        private System.Windows.Forms.TextBox txtBxCodigo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dtGrdVwCadTipoManutencao;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtBxValor;
        private System.Windows.Forms.Label lblCodTipoManutencao;
        private System.Windows.Forms.TextBox txtBxCodTpManutencao;
        private System.Windows.Forms.Label lblCodFabricante;
        private System.Windows.Forms.TextBox txtBxCodFabricante;
        private System.Windows.Forms.Label lblCodVeiculo;
        private System.Windows.Forms.TextBox txtBxCodVeiculo;
        private System.Windows.Forms.Label lblCodComponente;
        private System.Windows.Forms.TextBox txtBxCodComponente;
    }
}