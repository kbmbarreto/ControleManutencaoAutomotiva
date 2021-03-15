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
    public partial class frmConsultarComponentes : Form
    {
        public frmConsultarComponentes()
        {
            InitializeComponent();
        }

        //Exibir no DataGrid
        private void Exibir()
        {
            this.dtGrdVwComponentes.DataSource = ControllerComponente.Exibir();
            lblTotalRegistros.Text = "Total de registros: " + Convert.ToString(dtGrdVwComponentes.Rows.Count);
        }

        //Pesquisar no DataGrid
        private void PesquisarComponente()
        {
            this.dtGrdVwComponentes.DataSource = ControllerComponente.PesquisarComponente(txtBxComponente.Text);
            lblTotalRegistros.Text = "Total de registros: " + Convert.ToString(dtGrdVwComponentes.Rows.Count);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPrincipal;
            frmPrincipal = new frmPrincipal();
            frmPrincipal.Show();
            Close();
        }

        private void frmConsultarComponentes_Load(object sender, EventArgs e)
        {
            this.Exibir();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            this.PesquisarComponente();
        }

        private void txtBxComponente_TextChanged(object sender, EventArgs e)
        {
            this.PesquisarComponente();
        }

        private void chkBxExcluir_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
