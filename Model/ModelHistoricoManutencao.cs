using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Model
{
    public class ModelHistoricoManutencao
    {
        public int IDHistoricoManutencao { get; set; }
        public decimal Km { get; set; }
        public DateTime DataManutencao { get; set; }
        public decimal KmProximaTroca { get; set; }
        public decimal Valor { get; set; }
        public int Pesquisar { get; set; }
        public int FKFabricante { get; set; }
        public int FKTipoManutencao { get; set; }
        public int FKComponente { get; set; }
        public int FKApelido { get; set; }

        #region Construtor Vazio
        public ModelHistoricoManutencao()
        { }
        #endregion

        #region Construtor
        public ModelHistoricoManutencao(int idhistoricomanutencao, decimal km, DateTime datamanutencao, decimal kmproximatroca, decimal valor, int pesquisar, int fkfabricante, int fktipomanutencao, int fkcomponente, int fkapelido)
        {
            this.IDHistoricoManutencao = idhistoricomanutencao;
            this.Km = km;
            this.DataManutencao = datamanutencao;
            this.KmProximaTroca = kmproximatroca;
            this.Valor = valor;
            this.Pesquisar = pesquisar;
            this.FKFabricante = fkfabricante;
            this.FKTipoManutencao = fktipomanutencao;
            this.FKComponente = fkcomponente;
            this.FKApelido = fkapelido;
        }
        #endregion

        #region Método Inserir
        public string Inserir(ModelHistoricoManutencao HistoricoManutencao)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Dbstring.Cnx;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "ProcCadastrarHistoricoManutencao";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIDHistoricoManutencao = new SqlParameter();
                ParIDHistoricoManutencao.ParameterName = "@IDHistoricoManutencao";
                ParIDHistoricoManutencao.SqlDbType = SqlDbType.Int;
                ParIDHistoricoManutencao.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIDHistoricoManutencao);

                SqlParameter ParKm = new SqlParameter();
                ParKm.ParameterName = "@Km";
                ParKm.SqlDbType = SqlDbType.Decimal;
                ParKm.Size = 75;
                ParKm.Value = HistoricoManutencao.Km;
                SqlCmd.Parameters.Add(ParKm);

                SqlParameter ParDataManutencao = new SqlParameter();
                ParDataManutencao.ParameterName = "@DataManutencao";
                ParDataManutencao.SqlDbType = SqlDbType.DateTime;
                ParDataManutencao.Size = 75;
                ParDataManutencao.Value = HistoricoManutencao.DataManutencao;
                SqlCmd.Parameters.Add(ParDataManutencao);

                SqlParameter ParKmProximaTroca = new SqlParameter();
                ParKmProximaTroca.ParameterName = "@KmProximaTroca";
                ParKmProximaTroca.SqlDbType = SqlDbType.Decimal;
                ParKmProximaTroca.Size = 75;
                ParKmProximaTroca.Value = HistoricoManutencao.KmProximaTroca;
                SqlCmd.Parameters.Add(ParKmProximaTroca);

                SqlParameter ParValor = new SqlParameter();
                ParValor.ParameterName = "@Valor";
                ParValor.SqlDbType = SqlDbType.Decimal;
                ParValor.Size = 75;
                ParValor.Value = HistoricoManutencao.Valor;
                SqlCmd.Parameters.Add(ParValor);

                SqlParameter ParFKFabricante = new SqlParameter();
                ParFKFabricante.ParameterName = "@FKFabricante";
                ParFKFabricante.SqlDbType = SqlDbType.Int;
                ParFKFabricante.Value = HistoricoManutencao.FKFabricante;
                SqlCmd.Parameters.Add(ParFKFabricante);

                SqlParameter ParFKTipoManutencao = new SqlParameter();
                ParFKTipoManutencao.ParameterName = "@FKTipoManutencao";
                ParFKTipoManutencao.SqlDbType = SqlDbType.Int;
                ParFKTipoManutencao.Value = HistoricoManutencao.FKTipoManutencao;
                SqlCmd.Parameters.Add(ParFKTipoManutencao);

                SqlParameter ParFKComponente = new SqlParameter();
                ParFKComponente.ParameterName = "@FKComponente";
                ParFKComponente.SqlDbType = SqlDbType.Int;
                ParFKComponente.Value = HistoricoManutencao.FKComponente;
                SqlCmd.Parameters.Add(ParFKComponente);

                SqlParameter ParFKApelido = new SqlParameter();
                ParFKApelido.ParameterName = "@FKApelido";
                ParFKApelido.SqlDbType = SqlDbType.Int;
                ParFKApelido.Value = HistoricoManutencao.FKApelido;
                SqlCmd.Parameters.Add(ParFKApelido);

                resp = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "Cadastro não realizado!";
            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return resp;
        }
        #endregion
        #region Método Editar
        public string Editar(ModelHistoricoManutencao HistoricoManutencao)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Dbstring.Cnx;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "ProcEditarHistoricoManutencao";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIDHistoricoManutencao = new SqlParameter();
                ParIDHistoricoManutencao.ParameterName = "@IDHistoricoManutencao";
                ParIDHistoricoManutencao.SqlDbType = SqlDbType.Int;
                ParIDHistoricoManutencao.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIDHistoricoManutencao);

                SqlParameter ParKm = new SqlParameter();
                ParKm.ParameterName = "@Km";
                ParKm.SqlDbType = SqlDbType.Decimal;
                ParKm.Size = 75;
                ParKm.Value = HistoricoManutencao.Km;
                SqlCmd.Parameters.Add(ParKm);

                SqlParameter ParDataManutencao = new SqlParameter();
                ParDataManutencao.ParameterName = "@DataManutencao";
                ParDataManutencao.SqlDbType = SqlDbType.DateTime;
                ParDataManutencao.Size = 75;
                ParDataManutencao.Value = HistoricoManutencao.DataManutencao;
                SqlCmd.Parameters.Add(ParDataManutencao);

                SqlParameter ParKmProximaTroca = new SqlParameter();
                ParKmProximaTroca.ParameterName = "@KmProximaTroca";
                ParKmProximaTroca.SqlDbType = SqlDbType.Decimal;
                ParKmProximaTroca.Size = 75;
                ParKmProximaTroca.Value = HistoricoManutencao.KmProximaTroca;
                SqlCmd.Parameters.Add(ParKmProximaTroca);

                SqlParameter ParValor = new SqlParameter();
                ParValor.ParameterName = "@Valor";
                ParValor.SqlDbType = SqlDbType.Decimal;
                ParValor.Size = 75;
                ParValor.Value = HistoricoManutencao.Valor;
                SqlCmd.Parameters.Add(ParValor);

                SqlParameter ParFKFabricante = new SqlParameter();
                ParFKFabricante.ParameterName = "@FKFabricante";
                ParFKFabricante.SqlDbType = SqlDbType.Int;
                ParFKFabricante.Value = HistoricoManutencao.FKFabricante;
                SqlCmd.Parameters.Add(ParFKFabricante);

                SqlParameter ParFKTipoManutencao = new SqlParameter();
                ParFKTipoManutencao.ParameterName = "@FKTipoManutencao";
                ParFKTipoManutencao.SqlDbType = SqlDbType.Int;
                ParFKTipoManutencao.Value = HistoricoManutencao.FKTipoManutencao;
                SqlCmd.Parameters.Add(ParFKTipoManutencao);

                SqlParameter ParFKComponente = new SqlParameter();
                ParFKComponente.ParameterName = "@FKComponente";
                ParFKComponente.SqlDbType = SqlDbType.Int;
                ParFKComponente.Value = HistoricoManutencao.FKComponente;
                SqlCmd.Parameters.Add(ParFKComponente);

                SqlParameter ParFKApelido = new SqlParameter();
                ParFKApelido.ParameterName = "@FKApelido";
                ParFKApelido.SqlDbType = SqlDbType.Int;
                ParFKApelido.Value = HistoricoManutencao.FKApelido;
                SqlCmd.Parameters.Add(ParFKApelido);

                resp = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "Cadastro não atualizado!";
            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return resp;
        }
        #endregion
        #region Método Exibir
        public DataTable Exibir()
        {
            DataTable DtTbHistoricoManutencao = new DataTable("HistoricoManutencao");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Dbstring.Cnx;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "ProcExibirHistoricoManutencao";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtTbHistoricoManutencao);
            }
            catch (Exception ex)
            {
                DtTbHistoricoManutencao = null;
            }
            return DtTbHistoricoManutencao;
        }
        #endregion
        #region Método Excluir
        public string Excluir(ModelHistoricoManutencao HistoricoManutencao)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Dbstring.Cnx;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "ProcExcluirHistoricoManutencao";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIDHistoricoManutencao = new SqlParameter();
                ParIDHistoricoManutencao.ParameterName = "@IDHistoricoManutencao";
                ParIDHistoricoManutencao.SqlDbType = SqlDbType.Int;
                ParIDHistoricoManutencao.Value = HistoricoManutencao.IDHistoricoManutencao;
                SqlCmd.Parameters.Add(ParIDHistoricoManutencao);

                resp = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "Cadastro não excluído!";
            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return resp;
        }
        #endregion
        #region Método Pesquisar
        public DataTable PesquisarHistoricoManutencao(ModelHistoricoManutencao HistoricoManutencao)
        {
            DataTable DtTbHistoricoManutencao = new DataTable("HistoricoManutencao");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Dbstring.Cnx;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "ProcPesquisarHistoricoManutencao";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParPesquisar = new SqlParameter();
                ParPesquisar.ParameterName = "@PesquisarHistoricoManutencao";
                ParPesquisar.SqlDbType = SqlDbType.VarChar;
                ParPesquisar.Size = 75;
                ParPesquisar.Value = HistoricoManutencao.Pesquisar;
                SqlCmd.Parameters.Add(ParPesquisar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtTbHistoricoManutencao);
            }
            catch (Exception ex)
            {
                DtTbHistoricoManutencao = null;
            }
            return DtTbHistoricoManutencao;
        }
        #endregion
    }
}