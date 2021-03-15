using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Model
{
    public class ModelEstabelecimento
    {
        public int IDEstabelecimento { get; set; }
        public string Estabelecimento { get; set; }
        public string Pesquisar { get; set; }

        #region Construtor Vazio
        public ModelEstabelecimento()
        { }
        #endregion

        #region Construtor
        public ModelEstabelecimento(int idestabelecimento, string estabelecimento, string pesquisar)
        {
            this.IDEstabelecimento = idestabelecimento;
            this.Estabelecimento = estabelecimento;
            this.Pesquisar = pesquisar;
        }
        #endregion

        #region Método Inserir
        public string Inserir(ModelEstabelecimento Estabelecimento)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Dbstring.Cnx;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "ProcCadastrarEstabelecimento";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIDEstabelecimento = new SqlParameter();
                ParIDEstabelecimento.ParameterName = "@IDEstabelecimento";
                ParIDEstabelecimento.SqlDbType = SqlDbType.Int;
                ParIDEstabelecimento.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIDEstabelecimento);

                SqlParameter ParEstabelecimento = new SqlParameter();
                ParEstabelecimento.ParameterName = "@Estabelecimento";
                ParEstabelecimento.SqlDbType = SqlDbType.VarChar;
                ParEstabelecimento.Size = 75;
                ParEstabelecimento.Value = Estabelecimento.Estabelecimento;
                SqlCmd.Parameters.Add(ParEstabelecimento);

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
        public string Editar(ModelEstabelecimento Estabelecimento)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Dbstring.Cnx;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "ProcEditarEstabelecimento";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIDEstabelecimento = new SqlParameter();
                ParIDEstabelecimento.ParameterName = "@IDEstabelecimento";
                ParIDEstabelecimento.SqlDbType = SqlDbType.Int;
                ParIDEstabelecimento.Value = Estabelecimento.IDEstabelecimento;
                SqlCmd.Parameters.Add(ParIDEstabelecimento);

                SqlParameter ParEstabelecimento = new SqlParameter();
                ParEstabelecimento.ParameterName = "@Estabelecimento";
                ParEstabelecimento.SqlDbType = SqlDbType.VarChar;
                ParEstabelecimento.Size = 75;
                ParEstabelecimento.Value = Estabelecimento.Estabelecimento;
                SqlCmd.Parameters.Add(ParEstabelecimento);

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
            DataTable DtTbEstabelecimento = new DataTable("Estabelecimento");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Dbstring.Cnx;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "ProcExibirEstabelecimento";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtTbEstabelecimento);
            }
            catch (Exception ex)
            {
                DtTbEstabelecimento = null;
            }
            return DtTbEstabelecimento;
        }
        #endregion
        #region Método Excluir
        public string Excluir(ModelEstabelecimento Estabelecimento)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Dbstring.Cnx;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "ProcExcluirEstabelecimento";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIDEstabelecimento = new SqlParameter();
                ParIDEstabelecimento.ParameterName = "@IDEstabelecimento";
                ParIDEstabelecimento.SqlDbType = SqlDbType.Int;
                ParIDEstabelecimento.Value = Estabelecimento.IDEstabelecimento;
                SqlCmd.Parameters.Add(ParIDEstabelecimento);

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
        public DataTable PesquisarEstabelecimento(ModelEstabelecimento Estabelecimento)
        {
            DataTable DtTbEstabelecimento = new DataTable("Estabelecimento");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Dbstring.Cnx;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "ProcPesquisarEstabelecimento";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParPesquisar = new SqlParameter();
                ParPesquisar.ParameterName = "@PesquisarEstabelecimento";
                ParPesquisar.SqlDbType = SqlDbType.VarChar;
                ParPesquisar.Size = 75;
                ParPesquisar.Value = Estabelecimento.Pesquisar;
                SqlCmd.Parameters.Add(ParPesquisar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtTbEstabelecimento);
            }
            catch (Exception ex)
            {
                DtTbEstabelecimento = null;
            }
            return DtTbEstabelecimento;
        }
        #endregion
    }
}
