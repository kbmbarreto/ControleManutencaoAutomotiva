using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuComponentes_Click(object sender, EventArgs e)
        {
            frmCadComponente frmCadComponente;
            frmCadComponente = new frmCadComponente();
            frmCadComponente.Show();
            Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuEstabelecimentos_Click(object sender, EventArgs e)
        {
            frmCadEstabelecimento frmCadEstabelecimento;
            frmCadEstabelecimento = new frmCadEstabelecimento();
            frmCadEstabelecimento.Show();
            Hide();
        }

        private void menuFabricantes_Click(object sender, EventArgs e)
        {
            frmCadFabricante frmCadFabricante;
            frmCadFabricante = new frmCadFabricante();
            frmCadFabricante.Show();
            Hide();
        }

        private void menuTiposManutencao_Click(object sender, EventArgs e)
        {
            frmCadTiposManutencao frmCadTiposManutencao;
            frmCadTiposManutencao = new frmCadTiposManutencao();
            frmCadTiposManutencao.Show();
            Hide();
        }

        private void menuVeiculos_Click(object sender, EventArgs e)
        {
            frmCadVeiculos frmCadVeiculos;
            frmCadVeiculos = new frmCadVeiculos();
            frmCadVeiculos.Show();
            Hide();
        }

        private void menuManutencao_Click(object sender, EventArgs e)
        {
            frmCadastroDeManutencoes frmCadastroDeManutencoes;
            frmCadastroDeManutencoes = new frmCadastroDeManutencoes();
            frmCadastroDeManutencoes.Show();
            Hide();
        }

        private void menuManutencaoPlanejada_Click(object sender, EventArgs e)
        {
            frmCadPlanejadas frmCadPlanejadas;
            frmCadPlanejadas = new frmCadPlanejadas();
            frmCadPlanejadas.Show();
            Hide();
        }

        private void btnManutencoes_Click(object sender, EventArgs e)
        {
            frmCadastroDeManutencoes frmCadastroDeManutencoes;
            frmCadastroDeManutencoes = new frmCadastroDeManutencoes();
            frmCadastroDeManutencoes.Show();
            Hide();
        }

        private void btnVisitaPlanejada_Click(object sender, EventArgs e)
        {
            frmCadPlanejadas frmCadPlanejadas;
            frmCadPlanejadas = new frmCadPlanejadas();
            frmCadPlanejadas.Show();
            Hide();
        }

        private void menuListaDeCompras_Click(object sender, EventArgs e)
        {
            frmCadListaCompras frmCadListaCompras;
            frmCadListaCompras = new frmCadListaCompras();
            frmCadListaCompras.Show();
            Hide();
        }

        private void menuConsultarComponentes_Click(object sender, EventArgs e)
        {
            frmConsultarComponentes frmConsultarComponentes;
            frmConsultarComponentes = new frmConsultarComponentes();
            frmConsultarComponentes.Show();
            Hide();
        }

        private void menuConsultarEstabelecimentos_Click(object sender, EventArgs e)
        {
            frmConsultarEstabelecimento frmConsultarEstabelecimento;
            frmConsultarEstabelecimento = new frmConsultarEstabelecimento();
            frmConsultarEstabelecimento.Show();
            Hide();
        }

        private void menuConsultarFabricantes_Click(object sender, EventArgs e)
        {
            frmConsultarFabricantes frmConsultarFabricantes;
            frmConsultarFabricantes = new frmConsultarFabricantes();
            frmConsultarFabricantes.Show();
            Hide();
        }

        private void menuConsultarHistoricoManutencao_Click(object sender, EventArgs e)
        {
            frmConsultarManutencoes frmConsultarManutencoes;
            frmConsultarManutencoes = new frmConsultarManutencoes();
            frmConsultarManutencoes.Show();
            Hide();
        }

        private void menuConsultarListaCompras_Click(object sender, EventArgs e)
        {
            frmConsultarListaCompras frmConsultarListaCompras;
            frmConsultarListaCompras = new frmConsultarListaCompras();
            frmConsultarListaCompras.Show();
            Hide();
        }

        private void btnListaCompras_Click(object sender, EventArgs e)
        {
            frmCadListaCompras frmCadListaCompras;
            frmCadListaCompras = new frmCadListaCompras();
            frmCadListaCompras.Show();
            Hide();
        }

        private void menuConsultarManutencoesPlanejadas_Click(object sender, EventArgs e)
        {
            frmConsultarPlanejadas frmConsultarPlanejadas;
            frmConsultarPlanejadas = new frmConsultarPlanejadas();
            frmConsultarPlanejadas.Show();
            Hide();
        }

        private void menuConsultarVeiculosCadastrados_Click(object sender, EventArgs e)
        {
            frmConsultarVeiculos frmConsultarVeiculos;
            frmConsultarVeiculos = new frmConsultarVeiculos();
            frmConsultarVeiculos.Show();
            Hide();
        }
    }
}
