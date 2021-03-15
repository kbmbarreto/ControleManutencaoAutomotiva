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
    public partial class frmCadastroDeManutencoes : Form
    {
        public frmCadastroDeManutencoes()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPrincipal;
            frmPrincipal = new frmPrincipal();
            frmPrincipal.Show();
            Close();
        }
    }
}
