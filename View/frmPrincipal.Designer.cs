namespace View
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.mnStrpPrincipal = new System.Windows.Forms.MenuStrip();
            this.menuCadastroBase = new System.Windows.Forms.ToolStripMenuItem();
            this.menuComponentes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEstabelecimentos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFabricantes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTiposManutencao = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVeiculos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRegistrar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuManutencao = new System.Windows.Forms.ToolStripMenuItem();
            this.menuManutencaoPlanejada = new System.Windows.Forms.ToolStripMenuItem();
            this.menuListaDeCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultarComponentes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultarEstabelecimentos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultarFabricantes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultarHistoricoManutencao = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultarListaCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultarManutencoesPlanejadas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultarVeiculosCadastrados = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRelatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.emImplementaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtTmPckrPrincipal = new System.Windows.Forms.DateTimePicker();
            this.btnManutencoes = new System.Windows.Forms.Button();
            this.btnListaCompras = new System.Windows.Forms.Button();
            this.btnVisitaPlanejada = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.mnStrpPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnStrpPrincipal
            // 
            this.mnStrpPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastroBase,
            this.menuRegistrar,
            this.menuConsultar,
            this.menuRelatorios});
            this.mnStrpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnStrpPrincipal.Name = "mnStrpPrincipal";
            this.mnStrpPrincipal.Size = new System.Drawing.Size(784, 24);
            this.mnStrpPrincipal.TabIndex = 0;
            this.mnStrpPrincipal.Text = "menuStrip1";
            // 
            // menuCadastroBase
            // 
            this.menuCadastroBase.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuComponentes,
            this.menuEstabelecimentos,
            this.menuFabricantes,
            this.menuTiposManutencao,
            this.menuVeiculos});
            this.menuCadastroBase.Name = "menuCadastroBase";
            this.menuCadastroBase.Size = new System.Drawing.Size(93, 20);
            this.menuCadastroBase.Text = "Cadastro Base";
            this.menuCadastroBase.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // menuComponentes
            // 
            this.menuComponentes.Name = "menuComponentes";
            this.menuComponentes.Size = new System.Drawing.Size(188, 22);
            this.menuComponentes.Text = "Componentes";
            this.menuComponentes.Click += new System.EventHandler(this.menuComponentes_Click);
            // 
            // menuEstabelecimentos
            // 
            this.menuEstabelecimentos.Name = "menuEstabelecimentos";
            this.menuEstabelecimentos.Size = new System.Drawing.Size(188, 22);
            this.menuEstabelecimentos.Text = "Estabelecimentos";
            this.menuEstabelecimentos.Click += new System.EventHandler(this.menuEstabelecimentos_Click);
            // 
            // menuFabricantes
            // 
            this.menuFabricantes.Name = "menuFabricantes";
            this.menuFabricantes.Size = new System.Drawing.Size(188, 22);
            this.menuFabricantes.Text = "Fabricantes";
            this.menuFabricantes.Click += new System.EventHandler(this.menuFabricantes_Click);
            // 
            // menuTiposManutencao
            // 
            this.menuTiposManutencao.Name = "menuTiposManutencao";
            this.menuTiposManutencao.Size = new System.Drawing.Size(188, 22);
            this.menuTiposManutencao.Text = "Tipos de Manutenção";
            this.menuTiposManutencao.Click += new System.EventHandler(this.menuTiposManutencao_Click);
            // 
            // menuVeiculos
            // 
            this.menuVeiculos.Name = "menuVeiculos";
            this.menuVeiculos.Size = new System.Drawing.Size(188, 22);
            this.menuVeiculos.Text = "Veículos";
            this.menuVeiculos.Click += new System.EventHandler(this.menuVeiculos_Click);
            // 
            // menuRegistrar
            // 
            this.menuRegistrar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuManutencao,
            this.menuManutencaoPlanejada,
            this.menuListaDeCompras});
            this.menuRegistrar.Name = "menuRegistrar";
            this.menuRegistrar.Size = new System.Drawing.Size(65, 20);
            this.menuRegistrar.Text = "Registrar";
            // 
            // menuManutencao
            // 
            this.menuManutencao.Name = "menuManutencao";
            this.menuManutencao.Size = new System.Drawing.Size(203, 22);
            this.menuManutencao.Text = "Manutenção";
            this.menuManutencao.Click += new System.EventHandler(this.menuManutencao_Click);
            // 
            // menuManutencaoPlanejada
            // 
            this.menuManutencaoPlanejada.Name = "menuManutencaoPlanejada";
            this.menuManutencaoPlanejada.Size = new System.Drawing.Size(203, 22);
            this.menuManutencaoPlanejada.Text = "Manutenção Planejada";
            this.menuManutencaoPlanejada.Click += new System.EventHandler(this.menuManutencaoPlanejada_Click);
            // 
            // menuListaDeCompras
            // 
            this.menuListaDeCompras.Name = "menuListaDeCompras";
            this.menuListaDeCompras.Size = new System.Drawing.Size(203, 22);
            this.menuListaDeCompras.Text = "Ítem da lista de compras";
            this.menuListaDeCompras.Click += new System.EventHandler(this.menuListaDeCompras_Click);
            // 
            // menuConsultar
            // 
            this.menuConsultar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuConsultarComponentes,
            this.menuConsultarEstabelecimentos,
            this.menuConsultarFabricantes,
            this.menuConsultarHistoricoManutencao,
            this.menuConsultarListaCompras,
            this.menuConsultarManutencoesPlanejadas,
            this.menuConsultarVeiculosCadastrados});
            this.menuConsultar.Name = "menuConsultar";
            this.menuConsultar.Size = new System.Drawing.Size(70, 20);
            this.menuConsultar.Text = "Consultar";
            // 
            // menuConsultarComponentes
            // 
            this.menuConsultarComponentes.Name = "menuConsultarComponentes";
            this.menuConsultarComponentes.Size = new System.Drawing.Size(208, 22);
            this.menuConsultarComponentes.Text = "Componentes";
            this.menuConsultarComponentes.Click += new System.EventHandler(this.menuConsultarComponentes_Click);
            // 
            // menuConsultarEstabelecimentos
            // 
            this.menuConsultarEstabelecimentos.Name = "menuConsultarEstabelecimentos";
            this.menuConsultarEstabelecimentos.Size = new System.Drawing.Size(208, 22);
            this.menuConsultarEstabelecimentos.Text = "Estabelecimentos";
            this.menuConsultarEstabelecimentos.Click += new System.EventHandler(this.menuConsultarEstabelecimentos_Click);
            // 
            // menuConsultarFabricantes
            // 
            this.menuConsultarFabricantes.Name = "menuConsultarFabricantes";
            this.menuConsultarFabricantes.Size = new System.Drawing.Size(208, 22);
            this.menuConsultarFabricantes.Text = "Fabricantes";
            this.menuConsultarFabricantes.Click += new System.EventHandler(this.menuConsultarFabricantes_Click);
            // 
            // menuConsultarHistoricoManutencao
            // 
            this.menuConsultarHistoricoManutencao.Name = "menuConsultarHistoricoManutencao";
            this.menuConsultarHistoricoManutencao.Size = new System.Drawing.Size(208, 22);
            this.menuConsultarHistoricoManutencao.Text = "Histórico de Manutenção";
            this.menuConsultarHistoricoManutencao.Click += new System.EventHandler(this.menuConsultarHistoricoManutencao_Click);
            // 
            // menuConsultarListaCompras
            // 
            this.menuConsultarListaCompras.Name = "menuConsultarListaCompras";
            this.menuConsultarListaCompras.Size = new System.Drawing.Size(208, 22);
            this.menuConsultarListaCompras.Text = "Lista de Compras";
            this.menuConsultarListaCompras.Click += new System.EventHandler(this.menuConsultarListaCompras_Click);
            // 
            // menuConsultarManutencoesPlanejadas
            // 
            this.menuConsultarManutencoesPlanejadas.Name = "menuConsultarManutencoesPlanejadas";
            this.menuConsultarManutencoesPlanejadas.Size = new System.Drawing.Size(208, 22);
            this.menuConsultarManutencoesPlanejadas.Text = "Manutenções Planejadas";
            this.menuConsultarManutencoesPlanejadas.Click += new System.EventHandler(this.menuConsultarManutencoesPlanejadas_Click);
            // 
            // menuConsultarVeiculosCadastrados
            // 
            this.menuConsultarVeiculosCadastrados.Name = "menuConsultarVeiculosCadastrados";
            this.menuConsultarVeiculosCadastrados.Size = new System.Drawing.Size(208, 22);
            this.menuConsultarVeiculosCadastrados.Text = "Veículos Cadastrados";
            this.menuConsultarVeiculosCadastrados.Click += new System.EventHandler(this.menuConsultarVeiculosCadastrados_Click);
            // 
            // menuRelatorios
            // 
            this.menuRelatorios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emImplementaçãoToolStripMenuItem});
            this.menuRelatorios.Name = "menuRelatorios";
            this.menuRelatorios.Size = new System.Drawing.Size(71, 20);
            this.menuRelatorios.Text = "Relatórios";
            // 
            // emImplementaçãoToolStripMenuItem
            // 
            this.emImplementaçãoToolStripMenuItem.Name = "emImplementaçãoToolStripMenuItem";
            this.emImplementaçãoToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.emImplementaçãoToolStripMenuItem.Text = "Visualização em Power BI";
            // 
            // dtTmPckrPrincipal
            // 
            this.dtTmPckrPrincipal.Location = new System.Drawing.Point(475, 429);
            this.dtTmPckrPrincipal.Name = "dtTmPckrPrincipal";
            this.dtTmPckrPrincipal.Size = new System.Drawing.Size(297, 20);
            this.dtTmPckrPrincipal.TabIndex = 1;
            // 
            // btnManutencoes
            // 
            this.btnManutencoes.Location = new System.Drawing.Point(368, 110);
            this.btnManutencoes.Name = "btnManutencoes";
            this.btnManutencoes.Size = new System.Drawing.Size(99, 23);
            this.btnManutencoes.TabIndex = 2;
            this.btnManutencoes.Text = "Manutenções";
            this.btnManutencoes.UseVisualStyleBackColor = true;
            this.btnManutencoes.Click += new System.EventHandler(this.btnManutencoes_Click);
            // 
            // btnListaCompras
            // 
            this.btnListaCompras.Location = new System.Drawing.Point(484, 110);
            this.btnListaCompras.Name = "btnListaCompras";
            this.btnListaCompras.Size = new System.Drawing.Size(112, 23);
            this.btnListaCompras.TabIndex = 3;
            this.btnListaCompras.Text = "Lista de Compras";
            this.btnListaCompras.UseVisualStyleBackColor = true;
            this.btnListaCompras.Click += new System.EventHandler(this.btnListaCompras_Click);
            // 
            // btnVisitaPlanejada
            // 
            this.btnVisitaPlanejada.Location = new System.Drawing.Point(611, 110);
            this.btnVisitaPlanejada.Name = "btnVisitaPlanejada";
            this.btnVisitaPlanejada.Size = new System.Drawing.Size(106, 23);
            this.btnVisitaPlanejada.TabIndex = 4;
            this.btnVisitaPlanejada.Text = "Visita Planejada";
            this.btnVisitaPlanejada.UseVisualStyleBackColor = true;
            this.btnVisitaPlanejada.Click += new System.EventHandler(this.btnVisitaPlanejada_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(733, 110);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(39, 23);
            this.btnSair.TabIndex = 12;
            this.btnSair.Text = "X";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnVisitaPlanejada);
            this.Controls.Add(this.btnListaCompras);
            this.Controls.Add(this.btnManutencoes);
            this.Controls.Add(this.dtTmPckrPrincipal);
            this.Controls.Add(this.mnStrpPrincipal);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnStrpPrincipal;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Manutenção Veicular";
            this.mnStrpPrincipal.ResumeLayout(false);
            this.mnStrpPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnStrpPrincipal;
        private System.Windows.Forms.ToolStripMenuItem menuCadastroBase;
        private System.Windows.Forms.DateTimePicker dtTmPckrPrincipal;
        private System.Windows.Forms.ToolStripMenuItem menuComponentes;
        private System.Windows.Forms.ToolStripMenuItem menuEstabelecimentos;
        private System.Windows.Forms.ToolStripMenuItem menuFabricantes;
        private System.Windows.Forms.ToolStripMenuItem menuTiposManutencao;
        private System.Windows.Forms.ToolStripMenuItem menuVeiculos;
        private System.Windows.Forms.ToolStripMenuItem menuRegistrar;
        private System.Windows.Forms.ToolStripMenuItem menuManutencao;
        private System.Windows.Forms.ToolStripMenuItem menuManutencaoPlanejada;
        private System.Windows.Forms.ToolStripMenuItem menuListaDeCompras;
        private System.Windows.Forms.ToolStripMenuItem menuConsultar;
        private System.Windows.Forms.ToolStripMenuItem menuConsultarComponentes;
        private System.Windows.Forms.ToolStripMenuItem menuConsultarEstabelecimentos;
        private System.Windows.Forms.ToolStripMenuItem menuConsultarFabricantes;
        private System.Windows.Forms.ToolStripMenuItem menuConsultarHistoricoManutencao;
        private System.Windows.Forms.ToolStripMenuItem menuConsultarListaCompras;
        private System.Windows.Forms.ToolStripMenuItem menuConsultarManutencoesPlanejadas;
        private System.Windows.Forms.ToolStripMenuItem menuConsultarVeiculosCadastrados;
        private System.Windows.Forms.ToolStripMenuItem menuRelatorios;
        private System.Windows.Forms.Button btnManutencoes;
        private System.Windows.Forms.Button btnListaCompras;
        private System.Windows.Forms.Button btnVisitaPlanejada;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ToolStripMenuItem emImplementaçãoToolStripMenuItem;
    }
}

