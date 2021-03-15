using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelTipoManutencao
    {
        public int IDTipoManutencao { get; set; }
        public string TipoManutencao { get; set; }
        public string Pesquisar { get; set; }

        #region Construtor Vazio
        public ModelTipoManutencao()
        { }
        #endregion

        #region Construtor
        public ModelTipoManutencao(int idtipomanutencao, string tipomanutencao, string pesquisar)
        {
            this.IDTipoManutencao = idtipomanutencao;
            this.TipoManutencao = tipomanutencao;
            this.Pesquisar = pesquisar;
        }
        #endregion

        #region Método Inserir
        public string Inserir(ModelTipoManutencao TipoManutencao)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Dbstring.Cnx;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "ProcCadastrarTipoManutencao";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIDTipoManutencao = new SqlParameter();
                ParIDTipoManutencao.ParameterName = "@IDTipoManutencao";
                ParIDTipoManutencao.SqlDbType = SqlDbType.Int;
                ParIDTipoManutencao.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIDTipoManutencao);

                SqlParameter ParTipoManutencao = new SqlParameter();
                ParTipoManutencao.ParameterName = "@TipoManutencao";
                ParTipoManutencao.SqlDbType = SqlDbType.VarChar;
                ParTipoManutencao.Size = 75;
                ParTipoManutencao.Value = TipoManutencao.TipoManutencao;
                SqlCmd.Parameters.Add(ParTipoManutencao);

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
        public string Editar(ModelTipoManutencao TipoManutencao)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Dbstring.Cnx;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "ProcEditarTipoManutencao";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIDTipoManutencao = new SqlParameter();
                ParIDTipoManutencao.ParameterName = "@IDTipoManutencao";
                ParIDTipoManutencao.SqlDbType = SqlDbType.Int;
                ParIDTipoManutencao.Value = TipoManutencao.IDTipoManutencao;
                SqlCmd.Parameters.Add(ParIDTipoManutencao);

                SqlParameter ParTipoManutencao = new SqlParameter();
                ParTipoManutencao.ParameterName = "@TipoManutencao";
                ParTipoManutencao.SqlDbType = SqlDbType.VarChar;
                ParTipoManutencao.Size = 75;
                ParTipoManutencao.Value = TipoManutencao.TipoManutencao;
                SqlCmd.Parameters.Add(ParTipoManutencao);

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
            DataTable DtTbTipoManutencao = new DataTable("TipoManutencao");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Dbstring.Cnx;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "ProcExibirTipoManutencao";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtTbTipoManutencao);
            }
            catch (Exception ex)
            {
                DtTbTipoManutencao = null;
            }
            return DtTbTipoManutencao;
        }
        #endregion
        #region Método Excluir
        public string Excluir(ModelTipoManutencao TipoManutencao)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Dbstring.Cnx;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "ProcExcluirTipoManutencao";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIDTipoManutencao = new SqlParameter();
                ParIDTipoManutencao.ParameterName = "@IDTipoManutencao";
                ParIDTipoManutencao.SqlDbType = SqlDbType.Int;
                ParIDTipoManutencao.Value = TipoManutencao.IDTipoManutencao;
                SqlCmd.Parameters.Add(ParIDTipoManutencao);

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
        public DataTable PesquisarTipoManutencao(ModelTipoManutencao TipoManutencao)
        {
            DataTable DtTbTipoManutencao = new DataTable("TipoManutencao");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Dbstring.Cnx;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "ProcPesquisarTipoManutencao";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParPesquisar = new SqlParameter();
                ParPesquisar.ParameterName = "@PesquisarTipoManutencao";
                ParPesquisar.SqlDbType = SqlDbType.VarChar;
                ParPesquisar.Size = 75;
                ParPesquisar.Value = TipoManutencao.Pesquisar;
                SqlCmd.Parameters.Add(ParPesquisar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtTbTipoManutencao);
            }
            catch (Exception ex)
            {
                DtTbTipoManutencao = null;
            }
            return DtTbTipoManutencao;
        }
        #endregion
    }
}
