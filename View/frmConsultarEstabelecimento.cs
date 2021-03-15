using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;

namespace View
{
    public partial class frmConsultarEstabelecimento : Form
    {
        public frmConsultarEstabelecimento()
        {
            InitializeComponent();
        }

        //Exibir no DataGrid
        private void Exibir()
        {
            this.dtGrdVwEstabelecimento.DataSource = ControllerEstabelecimento.Exibir();
            lblTotalRegistros.Text = "Total de registros: " + Convert.ToString(dtGrdVwEstabelecimento.Rows.Count);
        }

        //Pesquisar no DataGrid
        private void PesquisarEstabelecimento()
        {
            this.dtGrdVwEstabelecimento.DataSource = ControllerEstabelecimento.PesquisarEstabelecimento(txtBxEstabelecimento.Text);
            lblTotalRegistros.Text = "Total de registros: " + Convert.ToString(dtGrdVwEstabelecimento.Rows.Count);
        }


        private void btnSair_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPrincipal;
            frmPrincipal = new frmPrincipal();
            frmPrincipal.Show();
            Close();
        }

        private void frmConsultarEstabelecimento_Load(object sender, EventArgs e)
        {
            this.Exibir();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            this.PesquisarEstabelecimento();
        }
    }
}
