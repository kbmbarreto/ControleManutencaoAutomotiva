using System;
using System.Data;
using Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class ControllerListaCompras
    {
        #region Método Inserir
        public static string Inserir(string descricao, int fkcomponente, int quantidade, int executado)
        {
            ModelListaCompras Obj = new Model.ModelListaCompras();

            Obj.Descricao = descricao;
            Obj.FKComponente = fkcomponente;
            Obj.Quantidade = quantidade;
            Obj.Executado = executado;
            return Obj.Inserir(Obj);
        }
        #endregion
        #region Método Editar
        public static string Editar(int idcompras, string descricao, int fkcomponente, int quantidade, int executado)
        {
            ModelListaCompras Obj = new Model.ModelListaCompras();

            Obj.IDCompras = idcompras;
            Obj.Descricao = descricao;
            Obj.FKComponente = fkcomponente;
            Obj.Quantidade = quantidade;
            Obj.Executado = executado;
            return Obj.Editar(Obj);
        }
        #endregion
        #region Método Excluir
        public static string Excluir(int idcompras)
        {
            ModelListaCompras Obj = new Model.ModelListaCompras();

            Obj.IDCompras = idcompras;
            return Obj.Excluir(Obj);
        }
        #endregion
        #region Método Exibir
        public static DataTable Exibir()
        {
            return new ModelListaCompras().Exibir();
        }
        #endregion
        #region Método Pesquisar
        public static DataTable PesquisarCompras(string pesquisar)
        {
            ModelListaCompras Obj = new ModelListaCompras();
            Obj.Pesquisar = pesquisar;
            return Obj.PesquisarListaCompras(Obj);
        }
        #endregion
    }
}