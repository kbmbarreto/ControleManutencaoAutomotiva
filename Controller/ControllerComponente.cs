using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Controller
{
    public class ControllerComponente
    {
        #region Método Inserir
        public static string Inserir(string componente)
        {
            ModelComponente Obj = new Model.ModelComponente();

            Obj.Componente = componente;
            return Obj.Inserir(Obj);
        }
        #endregion
        #region Método Editar
        public static string Editar(int idcomponente, string componente)
        {
            ModelComponente Obj = new Model.ModelComponente();

            Obj.IDComponente = idcomponente;
            Obj.Componente = componente;
            return Obj.Editar(Obj);
        }
        #endregion
        #region Método Excluir
        public static string Excluir(int idcomponente)
        {
            ModelComponente Obj = new Model.ModelComponente();

            Obj.IDComponente = idcomponente;
            return Obj.Excluir(Obj);
        }
        #endregion
        #region Método Exibir
        public static DataTable Exibir()
        {
            return new ModelComponente().Exibir();
        }

        public static object PesquisarComponente(TextBox txtBxComponente)
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Método Pesquisar
        public static DataTable PesquisarComponente(string pesquisar)
        {
            ModelComponente Obj = new ModelComponente();
            Obj.Pesquisar = pesquisar;
            return Obj.PesquisarComponente(Obj);
        }
        #endregion
    }
}
