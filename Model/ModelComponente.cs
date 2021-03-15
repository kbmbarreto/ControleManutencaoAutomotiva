using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Model
{
    public class ModelComponente
    {
        public int IDComponente { get; set; }
        public string Componente { get; set; }
        public string Pesquisar { get; set; }

        #region Construtor Vazio
        public ModelComponente()
        { }
        #endregion

        #region Construtor
        public ModelComponente(int idComponente, string componente, string pesquisar)
        {
            this.IDComponente = idComponente;
            this.Componente = componente;
            this.Pesquisar = pesquisar;
        }
        #endregion

        #region Método Inserir
        public string Inserir(ModelComponente Componente)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Dbstring.Cnx;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "ProcCadastrarComponente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIDComponente = new SqlParameter();
                ParIDComponente.ParameterName = "@IDComponente";
                ParIDComponente.SqlDbType = SqlDbType.Int;
                ParIDComponente.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIDComponente);

                SqlParameter ParComponente = new SqlParameter();
                ParComponente.ParameterName = "@Componente";
                ParComponente.SqlDbType = SqlDbType.VarChar;
                ParComponente.Size = 75;
                ParComponente.Value = Componente.Componente;
                SqlCmd.Parameters.Add(ParComponente);

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
        public string Editar(ModelComponente Componente)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Dbstring.Cnx;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "ProcEditarComponente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIDComponente = new SqlParameter();
                ParIDComponente.ParameterName = "@IDComponente";
                ParIDComponente.SqlDbType = SqlDbType.Int;
                ParIDComponente.Value = Componente.IDComponente;
                SqlCmd.Parameters.Add(ParIDComponente);

                SqlParameter ParComponente = new SqlParameter();
                ParComponente.ParameterName = "@Componente";
                ParComponente.SqlDbType = SqlDbType.VarChar;
                ParComponente.Size = 75;
                ParComponente.Value = Componente.Componente;
                SqlCmd.Parameters.Add(ParComponente);

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
            DataTable DtTbComponente = new DataTable("Componente");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Dbstring.Cnx;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "ProcExibirComponente";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtTbComponente);
            }
            catch (Exception ex)
            {
                DtTbComponente = null;
            }
            return DtTbComponente;
        }
        #endregion
        #region Método Excluir
        public string Excluir(ModelComponente Componente)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Dbstring.Cnx;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "ProcExcluirComponente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIDComponente = new SqlParameter();
                ParIDComponente.ParameterName = "@IDComponente";
                ParIDComponente.SqlDbType = SqlDbType.Int;
                ParIDComponente.Value = Componente.IDComponente;
                SqlCmd.Parameters.Add(ParIDComponente);

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
        public DataTable PesquisarComponente(ModelComponente Componente)
        {
            DataTable DtTbComponente = new DataTable("Componente");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Dbstring.Cnx;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "ProcPesquisarComponente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParPesquisar = new SqlParameter();
                ParPesquisar.ParameterName = "@PesquisarComponente";
                ParPesquisar.SqlDbType = SqlDbType.VarChar;
                ParPesquisar.Size = 75;
                ParPesquisar.Value = Componente.Pesquisar;
                SqlCmd.Parameters.Add(ParPesquisar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtTbComponente);
            }
            catch (Exception ex)
            {
                DtTbComponente = null;
            }
            return DtTbComponente;
        }
        #endregion
    }
}
