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
    public partial class frmConsultarListaCompras : Form
    {
        public frmConsultarListaCompras()
        {
            InitializeComponent();
        }

        //Exibir no DataGrid
        private void Exibir()
        {
            this.dtGrdVwListaCompras.DataSource = ControllerListaCompras.Exibir();
            lblTotalRegistros.Text = "Total de registros: " + Convert.ToString(dtGrdVwListaCompras.Rows.Count);
        }

        //Pesquisar no DataGrid
        private void PesquisarCompras()
        {
            this.dtGrdVwListaCompras.DataSource = ControllerListaCompras.PesquisarCompras(txtBxDescricao.Text);
            lblTotalRegistros.Text = "Total de registros: " + Convert.ToString(dtGrdVwListaCompras.Rows.Count);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPrincipal;
            frmPrincipal = new frmPrincipal();
            frmPrincipal.Show();
            Close();
        }

        private void frmConsultarListaCompras_Load(object sender, EventArgs e)
        {
            this.Exibir();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            this.PesquisarCompras();
        }
    }
}
