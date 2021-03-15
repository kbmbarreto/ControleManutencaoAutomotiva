using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Model;

namespace Controller
{
    public class ControllerFabricante
    {
        #region Método Inserir
        public static string Inserir(string fabricante)
        {
            ModelFabricante Obj = new Model.ModelFabricante();

            Obj.Fabricante = fabricante;
            return Obj.Inserir(Obj);
        }
        #endregion
        #region Método Editar
        public static string Editar(int idfabricante, string fabricante)
        {
            ModelFabricante Obj = new Model.ModelFabricante();

            Obj.IDFabricante = idfabricante;
            Obj.Fabricante = fabricante;
            return Obj.Editar(Obj);
        }
        #endregion
        #region Método Excluir
        public static string Excluir(int idfabricante)
        {
            ModelFabricante Obj = new Model.ModelFabricante();

            Obj.IDFabricante = idfabricante;
            return Obj.Excluir(Obj);
        }
        #endregion
        #region Método Exibir
        public static DataTable Exibir()
        {
            return new ModelFabricante().Exibir();
        }
        #endregion
        #region Método Pesquisar
        public static DataTable PesquisarFabricante(string pesquisar)
        {
            ModelFabricante Obj = new ModelFabricante();
            Obj.Pesquisar = pesquisar;
            return Obj.PesquisarFabricante(Obj);
        }
        #endregion
    }
}
