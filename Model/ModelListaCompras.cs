using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Model
{
    public class ModelListaCompras
    {
        public int IDCompras { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public int Executado { get; set; }
        public string Pesquisar { get; set; }
        public int FKComponente { get; set; }


        #region Construtor Vazio
        public ModelListaCompras()
        { }
        #endregion

        #region Construtor
        public ModelListaCompras(int idcompras, string descricao, int quantidade, int executado, string pesquisar, int fkcomponente)
        {
            this.IDCompras = idcompras;
            this.Descricao = descricao;
            this.Quantidade = quantidade;
            this.Executado = executado;
            this.Pesquisar = pesquisar;
            this.FKComponente = fkcomponente;
        }
        #endregion

        #region Método Inserir
        public string Inserir(ModelListaCompras ListaCompras)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Dbstring.Cnx;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "ProcCadastrarCompras";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIDCompras = new SqlParameter();
                ParIDCompras.ParameterName = "@IDCompras";
                ParIDCompras.SqlDbType = SqlDbType.Int;
                ParIDCompras.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIDCompras);

                SqlParameter ParDescricao = new SqlParameter();
                ParDescricao.ParameterName = "@Descricao";
                ParDescricao.SqlDbType = SqlDbType.VarChar;
                ParDescricao.Size = 75;
                ParDescricao.Value = ListaCompras.Descricao;
                SqlCmd.Parameters.Add(ParDescricao);

                SqlParameter ParQuantidade = new SqlParameter();
                ParQuantidade.ParameterName = "@Quantidade";
                ParQuantidade.SqlDbType = SqlDbType.Int;
                ParQuantidade.Value = ListaCompras.Quantidade;
                SqlCmd.Parameters.Add(ParQuantidade);

                SqlParameter ParExecutado = new SqlParameter();
                ParExecutado.ParameterName = "@Executado";
                ParExecutado.SqlDbType = SqlDbType.Int;
                ParExecutado.Value = ListaCompras.Executado;
                SqlCmd.Parameters.Add(ParExecutado);

                SqlParameter ParFKComponente = new SqlParameter();
                ParFKComponente.ParameterName = "@FKComponente";
                ParFKComponente.SqlDbType = SqlDbType.Int;
                ParFKComponente.Value = ListaCompras.FKComponente;
                SqlCmd.Parameters.Add(ParFKComponente);

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
        public string Editar(ModelListaCompras ListaCompras)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Dbstring.Cnx;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "ProcEditarCompras";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIDCompras = new SqlParameter();
                ParIDCompras.ParameterName = "@IDCompras";
                ParIDCompras.SqlDbType = SqlDbType.Int;
                ParIDCompras.Value = ListaCompras.IDCompras;
                SqlCmd.Parameters.Add(ParIDCompras);

                SqlParameter ParDescricao = new SqlParameter();
                ParDescricao.ParameterName = "@Descricao";
                ParDescricao.SqlDbType = SqlDbType.VarChar;
                ParDescricao.Size = 75;
                ParDescricao.Value = ListaCompras.Descricao;
                SqlCmd.Parameters.Add(ParDescricao);

                SqlParameter ParQuantidade = new SqlParameter();
                ParQuantidade.ParameterName = "@Quantidade";
                ParQuantidade.SqlDbType = SqlDbType.Int;
                ParQuantidade.Value = ListaCompras.Quantidade;
                SqlCmd.Parameters.Add(ParQuantidade);

                SqlParameter ParExecutado = new SqlParameter();
                ParExecutado.ParameterName = "@Executado";
                ParExecutado.SqlDbType = SqlDbType.Int;
                ParExecutado.Value = ListaCompras.Executado;
                SqlCmd.Parameters.Add(ParExecutado);

                SqlParameter ParFKComponente = new SqlParameter();
                ParFKComponente.ParameterName = "@FKComponente";
                ParFKComponente.SqlDbType = SqlDbType.Int;
                ParFKComponente.Value = ListaCompras.FKComponente;
                SqlCmd.Parameters.Add(ParFKComponente);

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
            DataTable DtTbListaCompras = new DataTable("ListaCompras");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Dbstring.Cnx;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "ProcExibirCompras";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtTbListaCompras);
            }
            catch (Exception ex)
            {
                DtTbListaCompras = null;
            }
            return DtTbListaCompras;
        }
        #endregion
        #region Método Excluir
        public string Excluir(ModelListaCompras ListaCompras)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Dbstring.Cnx;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "ProcExcluirCompras";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIDCompras = new SqlParameter();
                ParIDCompras.ParameterName = "@IDCompras";
                ParIDCompras.SqlDbType = SqlDbType.Int;
                ParIDCompras.Value = ListaCompras.IDCompras;
                SqlCmd.Parameters.Add(ParIDCompras);

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
        public DataTable PesquisarListaCompras(ModelListaCompras ListaCompras)
        {
            DataTable DtTbListaCompras = new DataTable("ListaCompras");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Dbstring.Cnx;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "ProcPesquisarCompras";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParPesquisar = new SqlParameter();
                ParPesquisar.ParameterName = "@PesquisarCompras";
                ParPesquisar.SqlDbType = SqlDbType.VarChar;
                ParPesquisar.Size = 75;
                ParPesquisar.Value = ListaCompras.Pesquisar;
                SqlCmd.Parameters.Add(ParPesquisar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtTbListaCompras);
            }
            catch (Exception ex)
            {
                DtTbListaCompras = null;
            }
            return DtTbListaCompras;
        }
        #endregion
    }
}
