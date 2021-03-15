namespace View
{
    partial class frmCadPlanejadas
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
            this.lblCodVeiculo = new System.Windows.Forms.Label();
            this.txtBxCodVeiculo = new System.Windows.Forms.TextBox();
            this.lblCodComponente = new System.Windows.Forms.Label();
            this.txtBxCodComponente = new System.Windows.Forms.TextBox();
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
            this.dtGrdVwCadManutencoesPlanejadas = new System.Windows.Forms.DataGridView();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwCadManutencoesPlanejadas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodVeiculo
            // 
            this.lblCodVeiculo.AutoSize = true;
            this.lblCodVeiculo.Location = new System.Drawing.Point(288, 160);
            this.lblCodVeiculo.Name = "lblCodVeiculo";
            this.lblCodVeiculo.Size = new System.Drawing.Size(69, 13);
            this.lblCodVeiculo.TabIndex = 95;
            this.lblCodVeiculo.Text = "Cód. Veículo";
            // 
            // txtBxCodVeiculo
            // 
            this.txtBxCodVeiculo.Location = new System.Drawing.Point(399, 157);
            this.txtBxCodVeiculo.Name = "txtBxCodVeiculo";
            this.txtBxCodVeiculo.Size = new System.Drawing.Size(100, 20);
            this.txtBxCodVeiculo.TabIndex = 94;
            // 
            // lblCodComponente
            // 
            this.lblCodComponente.AutoSize = true;
            this.lblCodComponente.Location = new System.Drawing.Point(532, 160);
            this.lblCodComponente.Name = "lblCodComponente";
            this.lblCodComponente.Size = new System.Drawing.Size(110, 13);
            this.lblCodComponente.TabIndex = 93;
            this.lblCodComponente.Text = "Cód. Estabelecimento";
            // 
            // txtBxCodComponente
            // 
            this.txtBxCodComponente.Location = new System.Drawing.Point(643, 157);
            this.txtBxCodComponente.Name = "txtBxCodComponente";
            this.txtBxCodComponente.Size = new System.Drawing.Size(100, 20);
            this.txtBxCodComponente.TabIndex = 92;
            // 
            // lblKmProxTroca
            // 
            this.lblKmProxTroca.AutoSize = true;
            this.lblKmProxTroca.Location = new System.Drawing.Point(34, 160);
            this.lblKmProxTroca.Name = "lblKmProxTroca";
            this.lblKmProxTroca.Size = new System.Drawing.Size(58, 13);
            this.lblKmProxTroca.TabIndex = 85;
            this.lblKmProxTroca.Text = "Executado";
            // 
            // txtBxKmProxTroca
            // 
            this.txtBxKmProxTroca.Location = new System.Drawing.Point(145, 157);
            this.txtBxKmProxTroca.Name = "txtBxKmProxTroca";
            this.txtBxKmProxTroca.Size = new System.Drawing.Size(100, 20);
            this.txtBxKmProxTroca.TabIndex = 84;
            // 
            // lblDataManutencao
            // 
            this.lblDataManutencao.AutoSize = true;
            this.lblDataManutencao.Location = new System.Drawing.Point(34, 129);
            this.lblDataManutencao.Name = "lblDataManutencao";
            this.lblDataManutencao.Size = new System.Drawing.Size(55, 13);
            this.lblDataManutencao.TabIndex = 83;
            this.lblDataManutencao.Text = "Descrição";
            // 
            // txtBxDataManutencao
            // 
            this.txtBxDataManutencao.Location = new System.Drawing.Point(145, 126);
            this.txtBxDataManutencao.Name = "txtBxDataManutencao";
            this.txtBxDataManutencao.Size = new System.Drawing.Size(100, 20);
            this.txtBxDataManutencao.TabIndex = 82;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(733, 9);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(39, 23);
            this.btnSair.TabIndex = 81;
            this.btnSair.Text = "X";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblKm
            // 
            this.lblKm.AutoSize = true;
            this.lblKm.Location = new System.Drawing.Point(34, 99);
            this.lblKm.Name = "lblKm";
            this.lblKm.Size = new System.Drawing.Size(73, 13);
            this.lblKm.TabIndex = 80;
            this.lblKm.Text = "Agendamento";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(34, 64);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 79;
            this.lblCodigo.Text = "Código";
            // 
            // txtBxKm
            // 
            this.txtBxKm.Location = new System.Drawing.Point(145, 96);
            this.txtBxKm.Name = "txtBxKm";
            this.txtBxKm.Size = new System.Drawing.Size(100, 20);
            this.txtBxKm.TabIndex = 78;
            // 
            // txtBxCodigo
            // 
            this.txtBxCodigo.Location = new System.Drawing.Point(145, 61);
            this.txtBxCodigo.Name = "txtBxCodigo";
            this.txtBxCodigo.ReadOnly = true;
            this.txtBxCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtBxCodigo.TabIndex = 77;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(298, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(187, 13);
            this.lblTitulo.TabIndex = 76;
            this.lblTitulo.Text = "Cadastro de Manutenções Planejadas";
            // 
            // dtGrdVwCadManutencoesPlanejadas
            // 
            this.dtGrdVwCadManutencoesPlanejadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVwCadManutencoesPlanejadas.Location = new System.Drawing.Point(37, 200);
            this.dtGrdVwCadManutencoesPlanejadas.Name = "dtGrdVwCadManutencoesPlanejadas";
            this.dtGrdVwCadManutencoesPlanejadas.Size = new System.Drawing.Size(707, 228);
            this.dtGrdVwCadManutencoesPlanejadas.TabIndex = 75;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(445, 94);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 74;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(648, 94);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 73;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(567, 52);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 72;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(648, 52);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 71;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(567, 94);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 70;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // frmCadPlanejadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.lblCodVeiculo);
            this.Controls.Add(this.txtBxCodVeiculo);
            this.Controls.Add(this.lblCodComponente);
            this.Controls.Add(this.txtBxCodComponente);
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
            this.Controls.Add(this.dtGrdVwCadManutencoesPlanejadas);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnNovo);
            this.Name = "frmCadPlanejadas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Manutenções Planejadas";
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwCadManutencoesPlanejadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodVeiculo;
        private System.Windows.Forms.TextBox txtBxCodVeiculo;
        private System.Windows.Forms.Label lblCodComponente;
        private System.Windows.Forms.TextBox txtBxCodComponente;
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
        private System.Windows.Forms.DataGridView dtGrdVwCadManutencoesPlanejadas;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnNovo;
    }
}