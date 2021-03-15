using System;
using Model;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class ControllerPlanejadas
    {
        #region Método Inserir
        public static string Inserir(DateTime agendamento, string descricao, int executado, int fkapelido, int fkestabelecimento)
        {
            ModelPlanejadas Obj = new Model.ModelPlanejadas();

            Obj.Agendamento = agendamento;
            Obj.Descricao = descricao;
            Obj.Executado = executado;
            Obj.FKApelido = fkapelido;
            Obj.FKEstabelecimento = fkestabelecimento;
            return Obj.Inserir(Obj);
        }
        #endregion
        #region Método Editar
        public static string Editar(int idplanejadas, DateTime agendamento, string descricao, int executado, int fkapelido, int fkestabelecimento)
        {
            ModelPlanejadas Obj = new Model.ModelPlanejadas();

            Obj.IDPlanejadas = idplanejadas;
            Obj.Agendamento = agendamento;
            Obj.Descricao = descricao;
            Obj.Executado = executado;
            Obj.FKApelido = fkapelido;
            Obj.FKEstabelecimento = fkestabelecimento;
            return Obj.Editar(Obj);
        }
        #endregion
        #region Método Excluir
        public static string Excluir(int idplanejadas)
        {
            ModelPlanejadas Obj = new Model.ModelPlanejadas();

            Obj.IDPlanejadas = idplanejadas;
            return Obj.Excluir(Obj);
        }
        #endregion
        #region Método Exibir
        public static DataTable Exibir()
        {
            return new ModelPlanejadas().Exibir();
        }
        #endregion
        #region Método Pesquisar
        public static DataTable PesquisarPlanejadas(int pesquisar)
        {
            ModelPlanejadas Obj = new ModelPlanejadas();
            Obj.Pesquisar = pesquisar;
            return Obj.PesquisarPlanejadas(Obj);
        }
        #endregion
    }
}