using System;
using Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Controller
{
    public class ControllerVeiculo
    {
        #region Método Inserir
        public static string Inserir(string apelido, string montadora, string modelo, DateTime ano)
        {
            ModelVeiculo Obj = new Model.ModelVeiculo();

            Obj.Apelido = apelido;
            Obj.Montadora = montadora;
            Obj.Modelo = modelo;
            Obj.Ano = ano;
            return Obj.Inserir(Obj);
        }
        #endregion
        #region Método Editar
        public static string Editar(int idveiculo, string apelido, string montadora, string modelo, DateTime ano)
        {
            ModelVeiculo Obj = new Model.ModelVeiculo();

            Obj.IDVeiculo = idveiculo;
            Obj.Apelido = apelido;
            Obj.Montadora = montadora;
            Obj.Modelo = modelo;
            Obj.Ano = ano;
            return Obj.Editar(Obj);
        }
        #endregion
        #region Método Excluir
        public static string Excluir(int idveiculo)
        {
            ModelVeiculo Obj = new Model.ModelVeiculo();

            Obj.IDVeiculo = idveiculo;
            return Obj.Excluir(Obj);
        }
        #endregion
        #region Método Exibir
        public static DataTable Exibir()
        {
            return new ModelVeiculo().Exibir();
        }
        #endregion
        #region Método Pesquisar
        public static DataTable PesquisarVeiculo(string pesquisar)
        {
            ModelVeiculo Obj = new ModelVeiculo();
            Obj.Pesquisar = pesquisar;
            return Obj.PesquisarVeiculo(Obj);
        }
        #endregion
    }
}