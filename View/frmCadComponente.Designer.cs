namespace View
{
    partial class frmCadComponente
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadComponente));
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dtGrdVwCadComponentes = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtBxCodigo = new System.Windows.Forms.TextBox();
            this.txtBxComponente = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblComponente = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblTotalRegistros = new System.Windows.Forms.Label();
            this.chkBxExcluir = new System.Windows.Forms.CheckBox();
            this.Deletar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.erprvdr = new System.Windows.Forms.ErrorProvider(this.components);
            this.tlTp = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwCadComponentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erprvdr)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(567, 97);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(648, 55);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 1;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(567, 55);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(648, 97);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(445, 97);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dtGrdVwCadComponentes
            // 
            this.dtGrdVwCadComponentes.AllowUserToAddRows = false;
            this.dtGrdVwCadComponentes.AllowUserToDeleteRows = false;
            this.dtGrdVwCadComponentes.AllowUserToOrderColumns = true;
            this.dtGrdVwCadComponentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVwCadComponentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Deletar});
            this.dtGrdVwCadComponentes.Location = new System.Drawing.Point(37, 155);
            this.dtGrdVwCadComponentes.Name = "dtGrdVwCadComponentes";
            this.dtGrdVwCadComponentes.ReadOnly = true;
            this.dtGrdVwCadComponentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrdVwCadComponentes.Size = new System.Drawing.Size(707, 272);
            this.dtGrdVwCadComponentes.TabIndex = 5;
            this.dtGrdVwCadComponentes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrdVwCadComponentes_CellContentClick);
            this.dtGrdVwCadComponentes.DoubleClick += new System.EventHandler(this.dtGrdVwCadComponentes_DoubleClick);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(350, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(132, 13);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Cadastro de Componentes";
            // 
            // txtBxCodigo
            // 
            this.txtBxCodigo.Location = new System.Drawing.Point(116, 52);
            this.txtBxCodigo.Name = "txtBxCodigo";
            this.txtBxCodigo.ReadOnly = true;
            this.txtBxCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtBxCodigo.TabIndex = 7;
            // 
            // txtBxComponente
            // 
            this.txtBxComponente.Location = new System.Drawing.Point(116, 99);
            this.txtBxComponente.Name = "txtBxComponente";
            this.txtBxComponente.Size = new System.Drawing.Size(314, 20);
            this.txtBxComponente.TabIndex = 8;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(34, 55);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 9;
            this.lblCodigo.Text = "Código";
            // 
            // lblComponente
            // 
            this.lblComponente.AutoSize = true;
            this.lblComponente.Location = new System.Drawing.Point(34, 102);
            this.lblComponente.Name = "lblComponente";
            this.lblComponente.Size = new System.Drawing.Size(67, 13);
            this.lblComponente.TabIndex = 10;
            this.lblComponente.Text = "Componente";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(733, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(39, 23);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "X";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblTotalRegistros
            // 
            this.lblTotalRegistros.AutoSize = true;
            this.lblTotalRegistros.Location = new System.Drawing.Point(612, 439);
            this.lblTotalRegistros.Name = "lblTotalRegistros";
            this.lblTotalRegistros.Size = new System.Drawing.Size(96, 13);
            this.lblTotalRegistros.TabIndex = 12;
            this.lblTotalRegistros.Text = "Total de Registros:";
            // 
            // chkBxExcluir
            // 
            this.chkBxExcluir.AutoSize = true;
            this.chkBxExcluir.Location = new System.Drawing.Point(529, 438);
            this.chkBxExcluir.Name = "chkBxExcluir";
            this.chkBxExcluir.Size = new System.Drawing.Size(60, 17);
            this.chkBxExcluir.TabIndex = 13;
            this.chkBxExcluir.Text = "Deletar";
            this.chkBxExcluir.UseVisualStyleBackColor = true;
            this.chkBxExcluir.CheckedChanged += new System.EventHandler(this.chkBxExcluir_CheckedChanged);
            // 
            // Deletar
            // 
            this.Deletar.HeaderText = "Deletar";
            this.Deletar.Name = "Deletar";
            this.Deletar.ReadOnly = true;
            // 
            // erprvdr
            // 
            this.erprvdr.ContainerControl = this;
            // 
            // tlTp
            // 
            this.tlTp.IsBalloon = true;
            // 
            // frmCadComponente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.chkBxExcluir);
            this.Controls.Add(this.lblTotalRegistros);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblComponente);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtBxComponente);
            this.Controls.Add(this.txtBxCodigo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dtGrdVwCadComponentes);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnNovo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadComponente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Componentes";
            this.Load += new System.EventHandler(this.frmCadComponente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwCadComponentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erprvdr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dtGrdVwCadComponentes;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtBxCodigo;
        private System.Windows.Forms.TextBox txtBxComponente;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblComponente;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblTotalRegistros;
        private System.Windows.Forms.CheckBox chkBxExcluir;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Deletar;
        private System.Windows.Forms.ErrorProvider erprvdr;
        private System.Windows.Forms.ToolTip tlTp;
    }
}