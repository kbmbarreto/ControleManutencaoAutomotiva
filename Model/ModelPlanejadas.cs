using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Model
{
    public class ModelPlanejadas
    {
        public int IDPlanejadas { get; set; }
        public DateTime Agendamento { get; set; }
        public string Descricao { get; set; }
        public int Executado { get; set; }
        public int Pesquisar { get; set; }
        public int FKApelido { get; set; }
        public int FKEstabelecimento { get; set; }

        #region Construtor Vazio
        public ModelPlanejadas()
        { }
        #endregion

        #region Construtor
        public ModelPlanejadas(int idplanejadas, DateTime agendamento, string descricao, int executado, int pesquisar, int fkapelido, int fkestabelecimento)
        {
            this.IDPlanejadas = idplanejadas;
            this.Agendamento = agendamento;
            this.Descricao = descricao;
            this.Executado = executado;
            this.Pesquisar = pesquisar;
            this.FKApelido = fkapelido;
            this.FKEstabelecimento = fkestabelecimento;
        }
        #endregion

        #region Método Inserir
        public string Inserir(ModelPlanejadas Planejadas)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Dbstring.Cnx;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "ProcCadastrarPlanejadas";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIDPlanejadas = new SqlParameter();
                ParIDPlanejadas.ParameterName = "@IDPlanejadas";
                ParIDPlanejadas.SqlDbType = SqlDbType.Int;
                ParIDPlanejadas.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIDPlanejadas);

                SqlParameter ParAgendamento = new SqlParameter();
                ParAgendamento.ParameterName = "@Agendamento";
                ParAgendamento.SqlDbType = SqlDbType.VarChar;
                ParAgendamento.Size = 75;
                ParAgendamento.Value = Planejadas.Agendamento;
                SqlCmd.Parameters.Add(ParAgendamento);

                SqlParameter ParDescricao = new SqlParameter();
                ParDescricao.ParameterName = "@Descricao";
                ParDescricao.SqlDbType = SqlDbType.VarChar;
                ParDescricao.Size = 75;
                ParDescricao.Value = Planejadas.Descricao;
                SqlCmd.Parameters.Add(ParDescricao);

                SqlParameter ParExecutado = new SqlParameter();
                ParExecutado.ParameterName = "@Executado";
                ParExecutado.SqlDbType = SqlDbType.Int;
                ParExecutado.Value = Planejadas.Executado;
                SqlCmd.Parameters.Add(ParExecutado);

                SqlParameter ParFKApelido = new SqlParameter();
                ParFKApelido.ParameterName = "@FKApelido";
                ParFKApelido.SqlDbType = SqlDbType.Int;
                ParFKApelido.Value = Planejadas.FKApelido;
                SqlCmd.Parameters.Add(ParFKApelido);

                SqlParameter ParFKEstabelecimento = new SqlParameter();
                ParFKEstabelecimento.ParameterName = "@FKEstabelecimento";
                ParFKEstabelecimento.SqlDbType = SqlDbType.Int;
                ParFKEstabelecimento.Value = Planejadas.FKEstabelecimento;
                SqlCmd.Parameters.Add(ParFKEstabelecimento);

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
        public string Editar(ModelPlanejadas Planejadas)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Dbstring.Cnx;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "ProcEditarPlanejadas";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIDPlanejadas = new SqlParameter();
                ParIDPlanejadas.ParameterName = "@IDPlanejadas";
                ParIDPlanejadas.SqlDbType = SqlDbType.Int;
                ParIDPlanejadas.Value = Planejadas.IDPlanejadas;
                SqlCmd.Parameters.Add(ParIDPlanejadas);

                SqlParameter ParAgendamento = new SqlParameter();
                ParAgendamento.ParameterName = "@Agendamento";
                ParAgendamento.SqlDbType = SqlDbType.VarChar;
                ParAgendamento.Size = 75;
                ParAgendamento.Value = Planejadas.Agendamento;
                SqlCmd.Parameters.Add(ParAgendamento);

                SqlParameter ParDescricao = new SqlParameter();
                ParDescricao.ParameterName = "@Descricao";
                ParDescricao.SqlDbType = SqlDbType.VarChar;
                ParDescricao.Size = 75;
                ParDescricao.Value = Planejadas.Descricao;
                SqlCmd.Parameters.Add(ParDescricao);

                SqlParameter ParExecutado = new SqlParameter();
                ParExecutado.ParameterName = "@Executado";
                ParExecutado.SqlDbType = SqlDbType.Int;
                ParExecutado.Value = Planejadas.Executado;
                SqlCmd.Parameters.Add(ParExecutado);

                SqlParameter ParFKApelido = new SqlParameter();
                ParFKApelido.ParameterName = "@FKApelido";
                ParFKApelido.SqlDbType = SqlDbType.Int;
                ParFKApelido.Value = Planejadas.FKApelido;
                SqlCmd.Parameters.Add(ParFKApelido);

                SqlParameter ParFKEstabelecimento = new SqlParameter();
                ParFKEstabelecimento.ParameterName = "@FKEstabelecimento";
                ParFKEstabelecimento.SqlDbType = SqlDbType.Int;
                ParFKEstabelecimento.Value = Planejadas.FKEstabelecimento;
                SqlCmd.Parameters.Add(ParFKEstabelecimento);

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
            DataTable DtTbPlanejadas = new DataTable("Planejadas");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Dbstring.Cnx;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "ProcExibirPlanejadas";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtTbPlanejadas);
            }
            catch (Exception ex)
            {
                DtTbPlanejadas = null;
            }
            return DtTbPlanejadas;
        }
        #endregion
        #region Método Excluir
        public string Excluir(ModelPlanejadas Planejadas)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Dbstring.Cnx;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "ProcExcluirPlanejadas";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIDPlanejadas = new SqlParameter();
                ParIDPlanejadas.ParameterName = "@IDPlanejadas";
                ParIDPlanejadas.SqlDbType = SqlDbType.Int;
                ParIDPlanejadas.Value = Planejadas.IDPlanejadas;
                SqlCmd.Parameters.Add(ParIDPlanejadas);

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
        public DataTable PesquisarPlanejadas(ModelPlanejadas Planejadas)
        {
            DataTable DtTbPlanejadas = new DataTable("Planejadas");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Dbstring.Cnx;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "ProcPesquisarPlanejadas";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParPesquisar = new SqlParameter();
                ParPesquisar.ParameterName = "@PesquisarPlanejadas";
                ParPesquisar.SqlDbType = SqlDbType.VarChar;
                ParPesquisar.Size = 75;
                ParPesquisar.Value = Planejadas.Pesquisar;
                SqlCmd.Parameters.Add(ParPesquisar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtTbPlanejadas);
            }
            catch (Exception ex)
            {
                DtTbPlanejadas = null;
            }
            return DtTbPlanejadas;
        }
        #endregion
    }
}
