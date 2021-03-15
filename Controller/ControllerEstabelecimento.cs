using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Controller
{
    public class ControllerEstabelecimento
    {
        #region Método Inserir
        public static string Inserir(string estabelecimento)
        {
            Model.ModelEstabelecimento Obj = new Model.ModelEstabelecimento();

            Obj.Estabelecimento = estabelecimento;
            return Obj.Inserir(Obj);
        }
        #endregion
        #region Método Editar
        public static string Editar(int idestabelecimento, string estabelecimento)
        {
            Model.ModelEstabelecimento Obj = new Model.ModelEstabelecimento();

            Obj.IDEstabelecimento = idestabelecimento;
            Obj.Estabelecimento = estabelecimento;
            return Obj.Editar(Obj);
        }
        #endregion
        #region Método Excluir
        public static string Excluir(int idestabelecimento)
        {
            Model.ModelEstabelecimento Obj = new Model.ModelEstabelecimento();

            Obj.IDEstabelecimento = idestabelecimento;
            return Obj.Excluir(Obj);
        }
        #endregion
        #region Método Exibir
        public static DataTable Exibir()
        {
            return new Model.ModelEstabelecimento().Exibir();
        }
        #endregion
        #region Método Pesquisar
        public static DataTable PesquisarEstabelecimento(string pesquisar)
        {
            Model.ModelEstabelecimento Obj = new Model.ModelEstabelecimento();

            Obj.Pesquisar = pesquisar;
            return Obj.PesquisarEstabelecimento(Obj);
        }
        #endregion
    }
}
