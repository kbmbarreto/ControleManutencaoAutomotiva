using System;
using Model;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class ControllerHistoricoManutencao
    {
        #region Método Inserir
        public static string Inserir(decimal km, DateTime datamanutencao, decimal kmproximatroca, decimal valor, 
            int fkfabricante, int fktipomanutencao, int fkcomponente, int fkapelido)
        {
            ModelHistoricoManutencao Obj = new Model.ModelHistoricoManutencao();

            Obj.Km = km;
            Obj.DataManutencao = datamanutencao;
            Obj.KmProximaTroca = kmproximatroca;
            Obj.Valor = valor;
            Obj.FKFabricante = fkfabricante;
            Obj.FKTipoManutencao = fktipomanutencao;
            Obj.FKComponente = fkcomponente;
            Obj.FKApelido = fkapelido;
            return Obj.Inserir(Obj);
        }

        public static object PesquisarHistoricoManutencao(string text)
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Método Editar
        public static string Editar(int idhistoricomanutencao, decimal km, DateTime datamanutencao, decimal kmproximatroca, decimal valor, 
            int fkfabricante, int fktipomanutencao, int fkcomponente, int fkapelido)
        {
            ModelHistoricoManutencao Obj = new Model.ModelHistoricoManutencao();

            Obj.IDHistoricoManutencao = idhistoricomanutencao;
            Obj.Km = km;
            Obj.DataManutencao = datamanutencao;
            Obj.KmProximaTroca = kmproximatroca;
            Obj.Valor = valor;
            Obj.FKFabricante = fkfabricante;
            Obj.FKTipoManutencao = fktipomanutencao;
            Obj.FKComponente = fkcomponente;
            Obj.FKApelido = fkapelido;
            return Obj.Editar(Obj);
        }
        #endregion
        #region Método Excluir
        public static string Excluir(int idhistoricomanutencao)
        {
            ModelHistoricoManutencao Obj = new Model.ModelHistoricoManutencao();

            Obj.IDHistoricoManutencao = idhistoricomanutencao;
            return Obj.Excluir(Obj);
        }
        #endregion
        #region Método Exibir
        public static DataTable Exibir()
        {
            return new ModelHistoricoManutencao().Exibir();
        }
        #endregion
        #region Método Pesquisar
        public static DataTable PesquisarHistoricoManutencao(int pesquisar)
        {
            ModelHistoricoManutencao Obj = new ModelHistoricoManutencao();
            Obj.Pesquisar = pesquisar;
            return Obj.PesquisarHistoricoManutencao(Obj);
        }
        #endregion
    }
}