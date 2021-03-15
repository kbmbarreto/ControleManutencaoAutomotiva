using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Model
{
    public class ModelFabricante
    {
        public int IDFabricante { get; set; }
        public string Fabricante { get; set; }
        public string Pesquisar { get; set; }

        #region Construtor Vazio
        public ModelFabricante()
        { }
        #endregion

        #region Construtor
        public ModelFabricante(int idfabricante, string fabricante, string pesquisar)
        {
            this.IDFabricante = idfabricante;
            this.Fabricante = fabricante;
            this.Pesquisar = pesquisar;
        }
        #endregion

        #region Método Inserir
        public string Inserir(ModelFabricante Fabricante)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Dbstring.Cnx;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "ProcCadastrarFabricante";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIDFabricante = new SqlParameter();
                ParIDFabricante.ParameterName = "@IDFabricante";
                ParIDFabricante.SqlDbType = SqlDbType.Int;
                ParIDFabricante.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIDFabricante);

                SqlParameter ParFabricante = new SqlParameter();
                ParFabricante.ParameterName = "@Fabricante";
                ParFabricante.SqlDbType = SqlDbType.VarChar;
                ParFabricante.Size = 75;
                ParFabricante.Value = Fabricante.Fabricante;
                SqlCmd.Parameters.Add(ParFabricante);

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
        public string Editar(ModelFabricante Fabricante)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Dbstring.Cnx;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "ProcEditarFabricante";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIDFabricante = new SqlParameter();
                ParIDFabricante.ParameterName = "@IDFabricante";
                ParIDFabricante.SqlDbType = SqlDbType.Int;
                ParIDFabricante.Value = Fabricante.IDFabricante;
                SqlCmd.Parameters.Add(ParIDFabricante);

                SqlParameter ParFabricante = new SqlParameter();
                ParFabricante.ParameterName = "@Fabricante";
                ParFabricante.SqlDbType = SqlDbType.VarChar;
                ParFabricante.Size = 75;
                ParFabricante.Value = Fabricante.Fabricante;
                SqlCmd.Parameters.Add(ParFabricante);

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
            DataTable DtTbFabricante = new DataTable("Fabricante");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Dbstring.Cnx;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "ProcExibirFabricante";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtTbFabricante);
            }
            catch (Exception ex)
            {
                DtTbFabricante = null;
            }
            return DtTbFabricante;
        }
        #endregion
        #region Método Excluir
        public string Excluir(ModelFabricante Fabricante)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Dbstring.Cnx;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "ProcExcluirFabricante";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIDFabricante = new SqlParameter();
                ParIDFabricante.ParameterName = "@IDFabricante";
                ParIDFabricante.SqlDbType = SqlDbType.Int;
                ParIDFabricante.Value = Fabricante.IDFabricante;
                SqlCmd.Parameters.Add(ParIDFabricante);

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
        public DataTable PesquisarFabricante(ModelFabricante Fabricante)
        {
            DataTable DtTbFabricante = new DataTable("Fabricante");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Dbstring.Cnx;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "ProcPesquisarFabricante";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParPesquisar = new SqlParameter();
                ParPesquisar.ParameterName = "@PesquisarFabricante";
                ParPesquisar.SqlDbType = SqlDbType.VarChar;
                ParPesquisar.Size = 75;
                ParPesquisar.Value = Fabricante.Pesquisar;
                SqlCmd.Parameters.Add(ParPesquisar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtTbFabricante);
            }
            catch (Exception ex)
            {
                DtTbFabricante = null;
            }
            return DtTbFabricante;
        }
        #endregion
    }
}
