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
    public partial class frmCadComponente : Form
    {
        private bool eNovo = false;
        private bool eEditar = false;
        public frmCadComponente()
        {
            InitializeComponent();
            this.tlTp.SetToolTip(this.txtBxComponente, "Insira o nome do componente 'Peça'.");
        }

        //Mensagem de confirmação
        private void MensagemOk(string mensagem)
        {
            MessageBox.Show(mensagem, "Controle de Mautenção Automotiva", MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }

        //Mensagem de erro
        private void MensagemErro(string mensagem)
        {
            MessageBox.Show(mensagem, "Controle de Mautenção Automotiva", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        //Limpar campos
        private void Clean()
        {
            this.txtBxCodigo.Text = string.Empty;
            this.txtBxComponente.Text = string.Empty;
        }

        //Habilitar TextBox
        private void HabilitarTxtBx(bool valor)
        {
            this.txtBxCodigo.ReadOnly = !valor;
            this.txtBxComponente.ReadOnly = !valor;
        }

        //Habilitar Botões
        private void HabilitarBtn()
        {
            if(this.eNovo || this.eEditar)
            {
                this.HabilitarTxtBx(true);
                this.btnNovo.Enabled = false;
                this.btnSalvar.Enabled = true;
                this.btnEditar.Enabled = false;
                this.btnCancelar.Enabled = true;
            }
            else
            {
                this.HabilitarTxtBx(true);
                this.btnNovo.Enabled = true;
                this.btnSalvar.Enabled = false;
                this.btnEditar.Enabled = true;
                this.btnCancelar.Enabled = false;
            }
        }

        //Ocultar as colunas do Grid
        private void OcultarColunasGrid()
        {
            this.dtGrdVwCadComponentes.Columns[0].Visible = false;
            //this.dtGrdVwCadComponentes.Columns[1].Visible = false;
        }

        //Exibir no DataGrid
        private void Exibir()
        {
            this.dtGrdVwCadComponentes.DataSource = ControllerComponente.Exibir();
            this.OcultarColunasGrid();
            lblTotalRegistros.Text = "Total de registros: " + Convert.ToString(dtGrdVwCadComponentes.Rows.Count);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPrincipal;
            frmPrincipal = new frmPrincipal();
            frmPrincipal.Show();
            Close();
        }

        private void frmCadComponente_Load(object sender, EventArgs e)
        {
            this.Exibir();
            this.HabilitarTxtBx(false);
            this.HabilitarBtn();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.eNovo = true;
            this.eEditar = false;
            this.HabilitarBtn();
            this.Clean();
            this.HabilitarTxtBx(true);
            this.txtBxComponente.Focus();
            this.txtBxCodigo.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string resp = "";
                if(txtBxComponente.Text == string.Empty)
                {
                    MensagemErro("Preencha todos os campos");
                    //errorIcone.SetError(txtBxComponente, "Insira o componente 'peça'.");
                }
                else
                {
                    if (this.eNovo)
                    {
                        resp = ControllerComponente.Inserir(txtBxComponente.Text.Trim());
                    }
                    else
                    {
                        resp = ControllerComponente.Editar(Convert.ToInt32(this.txtBxCodigo.Text), txtBxComponente.Text.Trim());
                    }
                    if(resp.Equals("OK"))
                    {
                        if(this.eNovo)
                        {
                            this.MensagemOk("Registro salvo com sucesso!");
                        }
                        else
                        {
                            this.MensagemOk("Registro editado com sucesso!");
                        }
                    }
                    else
                    {
                        this.MensagemErro(resp);
                    }
                    this.eNovo = false;
                    this.eEditar = false;
                    this.HabilitarBtn();
                    this.Clean();
                    this.Exibir();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void dtGrdVwCadComponentes_DoubleClick(object sender, EventArgs e)
        {
            this.txtBxCodigo.Text = Convert.ToString(this.dtGrdVwCadComponentes.CurrentRow.Cells["IDComponente"].Value);
            this.txtBxComponente.Text = Convert.ToString(this.dtGrdVwCadComponentes.CurrentRow.Cells["Componente"].Value);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(this.txtBxCodigo.Text.Equals(""))
            {
                this.MensagemErro("Selecione um registro para editar!");
            }
            else
            {
                this.eEditar = true;
                this.HabilitarBtn();
                this.HabilitarTxtBx(true);

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.eNovo = false;
            this.eEditar = false;
            this.HabilitarBtn();
            this.HabilitarTxtBx(false);
            this.Clean();
        }

        private void chkBxExcluir_CheckedChanged(object sender, EventArgs e)
        {
            if(chkBxExcluir.Checked)
            {
                this.dtGrdVwCadComponentes.Columns[0].Visible = true;
            }
            else
            {
                this.dtGrdVwCadComponentes.Columns[0].Visible = false;
            }
        }

        private void dtGrdVwCadComponentes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == dtGrdVwCadComponentes.Columns["Deletar"].Index)
            {
                DataGridViewCheckBoxCell ChkDeletar = (DataGridViewCheckBoxCell)
                    dtGrdVwCadComponentes.Rows[e.RowIndex].Cells["Deletar"];
                ChkDeletar.Value = !Convert.ToBoolean(ChkDeletar.Value);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcao;
                Opcao = MessageBox.Show("Deseja realmente deletar os registros selecionados?",
                    "Controle de Manutenção Automotiva", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if(Opcao == DialogResult.OK)
                {
                    string Codigo;
                    string resp = "";

                    foreach(DataGridViewRow row in dtGrdVwCadComponentes.Rows)
                    {
                        if(Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            resp = ControllerComponente.Excluir(Convert.ToInt32(Codigo));

                            if(resp.Equals("OK"))
                            {
                                this.MensagemOk("Os registros selecionados foram excluídos!");
                            }
                            else
                            {
                                this.MensagemErro(resp);
                            }
                        }
                    }
                    this.Exibir();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
