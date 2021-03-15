using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelVeiculo
    {
        public int IDVeiculo { get; set; }
        public string Apelido { get; set; }
        public string Montadora { get; set; }
        public string Modelo { get; set; }
        public DateTime Ano { get; set; }
        public string Pesquisar { get; set; }

        #region Construtor Vazio
        public ModelVeiculo()
        { }
        #endregion

        #region Construtor
        public ModelVeiculo(int idveiculo, string apelido, string montadora, string modelo, DateTime ano, string pesquisar)
        {
            this.IDVeiculo = idveiculo;
            this.Apelido = apelido;
            this.Montadora = montadora;
            this.Modelo = modelo;
            this.Ano = ano;
            this.Pesquisar = pesquisar;
        }
        #endregion

        #region Método Inserir
        public string Inserir(ModelVeiculo Veiculo)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Dbstring.Cnx;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "ProcCadastrarVeiculo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIDVeiculo = new SqlParameter();
                ParIDVeiculo.ParameterName = "@IDVeiculo";
                ParIDVeiculo.SqlDbType = SqlDbType.Int;
                ParIDVeiculo.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIDVeiculo);

                SqlParameter ParApelido = new SqlParameter();
                ParApelido.ParameterName = "@Apelido";
                ParApelido.SqlDbType = SqlDbType.VarChar;
                ParApelido.Size = 75;
                ParApelido.Value = Veiculo.Apelido;
                SqlCmd.Parameters.Add(ParApelido);

                SqlParameter ParMontadora = new SqlParameter();
                ParMontadora.ParameterName = "@Montadora";
                ParMontadora.SqlDbType = SqlDbType.VarChar;
                ParMontadora.Size = 75;
                ParMontadora.Value = Veiculo.Montadora;
                SqlCmd.Parameters.Add(ParMontadora);

                SqlParameter ParModelo = new SqlParameter();
                ParModelo.ParameterName = "@Modelo";
                ParModelo.SqlDbType = SqlDbType.VarChar;
                ParModelo.Size = 75;
                ParModelo.Value = Veiculo.Modelo;
                SqlCmd.Parameters.Add(ParModelo);

                SqlParameter ParAno = new SqlParameter();
                ParAno.ParameterName = "@Ano";
                ParAno.SqlDbType = SqlDbType.Date;
                ParAno.Size = 75;
                ParAno.Value = Veiculo.Ano;
                SqlCmd.Parameters.Add(ParAno);

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
        public string Editar(ModelVeiculo Veiculo)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Dbstring.Cnx;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "ProcEditarVeiculo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIDVeiculo = new SqlParameter();
                ParIDVeiculo.ParameterName = "@IDVeiculo";
                ParIDVeiculo.SqlDbType = SqlDbType.Int;
                ParIDVeiculo.Value = Veiculo.IDVeiculo;
                SqlCmd.Parameters.Add(ParIDVeiculo);

                SqlParameter ParApelido = new SqlParameter();
                ParApelido.ParameterName = "@Apelido";
                ParApelido.SqlDbType = SqlDbType.VarChar;
                ParApelido.Size = 75;
                ParApelido.Value = Veiculo.Apelido;
                SqlCmd.Parameters.Add(ParApelido);

                SqlParameter ParMontadora = new SqlParameter();
                ParMontadora.ParameterName = "@Montadora";
                ParMontadora.SqlDbType = SqlDbType.VarChar;
                ParMontadora.Size = 75;
                ParMontadora.Value = Veiculo.Montadora;
                SqlCmd.Parameters.Add(ParMontadora);

                SqlParameter ParModelo = new SqlParameter();
                ParModelo.ParameterName = "@Modelo";
                ParModelo.SqlDbType = SqlDbType.VarChar;
                ParModelo.Size = 75;
                ParModelo.Value = Veiculo.Modelo;
                SqlCmd.Parameters.Add(ParModelo);

                SqlParameter ParAno = new SqlParameter();
                ParAno.ParameterName = "@Ano";
                ParAno.SqlDbType = SqlDbType.Date;
                ParAno.Size = 75;
                ParAno.Value = Veiculo.Ano;
                SqlCmd.Parameters.Add(ParAno);

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
            DataTable DtTbVeiculo = new DataTable("Veiculo");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Dbstring.Cnx;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "ProcExibirVeiculo";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtTbVeiculo);
            }
            catch (Exception ex)
            {
                DtTbVeiculo = null;
            }
            return DtTbVeiculo;
        }
        #endregion
        #region Método Excluir
        public string Excluir(ModelVeiculo Veiculo)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Dbstring.Cnx;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "ProcExcluirVeiculo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIDVeiculo = new SqlParameter();
                ParIDVeiculo.ParameterName = "@IDVeiculo";
                ParIDVeiculo.SqlDbType = SqlDbType.Int;
                ParIDVeiculo.Value = Veiculo.IDVeiculo;
                SqlCmd.Parameters.Add(ParIDVeiculo);

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
        public DataTable PesquisarVeiculo(ModelVeiculo Veiculo)
        {
            DataTable DtTbVeiculo = new DataTable("Veiculo");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Dbstring.Cnx;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "ProcPesquisarVeiculo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParPesquisar = new SqlParameter();
                ParPesquisar.ParameterName = "@PesquisarVeiculo";
                ParPesquisar.SqlDbType = SqlDbType.VarChar;
                ParPesquisar.Size = 75;
                ParPesquisar.Value = Veiculo.Pesquisar;
                SqlCmd.Parameters.Add(ParPesquisar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtTbVeiculo);
            }
            catch (Exception ex)
            {
                DtTbVeiculo = null;
            }
            return DtTbVeiculo;
        }
        #endregion
    }
}
