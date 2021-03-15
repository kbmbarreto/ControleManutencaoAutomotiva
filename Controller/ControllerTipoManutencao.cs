using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Model;

namespace Controller
{
    public class ControllerTipoManutencao
    {
        #region Método Inserir
        public static string Inserir(string tipomanutencao)
        {
            ModelTipoManutencao Obj = new Model.ModelTipoManutencao();

            Obj.TipoManutencao = tipomanutencao;
            return Obj.Inserir(Obj);
        }
        #endregion
        #region Método Editar
        public static string Editar(int idtipomanutencao, string tipomanutencao)
        {
            ModelTipoManutencao Obj = new Model.ModelTipoManutencao();

            Obj.IDTipoManutencao = idtipomanutencao;
            Obj.TipoManutencao = tipomanutencao;
            return Obj.Editar(Obj);
        }
        #endregion
        #region Método Excluir
        public static string Excluir(int idtipomanutencao)
        {
            ModelTipoManutencao Obj = new Model.ModelTipoManutencao();

            Obj.IDTipoManutencao = idtipomanutencao;
            return Obj.Excluir(Obj);
        }
        #endregion
        #region Método Exibir
        public static DataTable Exibir()
        {
            return new ModelTipoManutencao().Exibir();
        }
        #endregion
        #region Método Pesquisar
        public static DataTable PesquisarTipoManutencao(string pesquisar)
        {
            ModelTipoManutencao Obj = new ModelTipoManutencao();
            Obj.Pesquisar = pesquisar;
            return Obj.PesquisarTipoManutencao(Obj);
        }
        #endregion
    }
}
