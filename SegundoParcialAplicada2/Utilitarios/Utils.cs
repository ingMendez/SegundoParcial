using BLL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace SegundoParcialAplicada2.Utilitarios
{
    public class Utils
    {
        public static int ToInt(string valor)
        {
            int retorno = 0;
            int.TryParse(valor, out retorno);

            return retorno;
        }


        public static int ToIntObjetos(object valor)
        {
            int retorno = 0;
            int.TryParse(valor.ToString(), out retorno);

            return retorno;
        }

        public static double ToDouble(string valor)
        {
            double retorno = 0;
            double.TryParse(valor, out retorno);

            return retorno;
        }

        public static double ToDoubleObjetos(object valor)
        {
            double retorno = 0;
            double.TryParse(valor.ToString(), out retorno);

            return Convert.ToDouble(retorno);
        }

        public static decimal ToDecimal(string valor)
        {
            decimal retorno = 0;
            decimal.TryParse(valor, out retorno);

            return retorno;
        }

        public static DateTime ToDateTime(string valor)
        {
            DateTime retorno = DateTime.Now;
            DateTime.TryParse(valor, out retorno);

            return retorno;
        }

        public static List<Transacciones> FiltrarTransacciones(int index, string criterio, DateTime desde, DateTime hasta)
        {
            Expression<Func<Transacciones, bool>> filtro = p => true;
            RepositorioBase<Transacciones> repositorio = new RepositorioBase<Transacciones>();
            List<Transacciones> list = new List<Transacciones>();

            int id = ToInt(criterio);
            switch (index)
            {
                case 0://Todo
                    break;

                case 1://Todo por fecha
                    filtro = p => p.Fecha >= desde && p.Fecha <= hasta;
                    break;

                case 2://FacturaId
                    filtro = p => p.TransacionId == id && p.Fecha >= desde && p.Fecha <= hasta;
                    break;

                case 3://ClienteId
                    filtro = p => p.ClienteId == id && p.Fecha >= desde && p.Fecha <= hasta;
                    break;
            }

            list = repositorio.GetList(filtro);

            return list;
        }

        public static List<Cliente> FiltrarClientes(int index, string criterio, DateTime desde, DateTime hasta)
        {
            Expression<Func<Cliente, bool>> filtro = p => true;
            RepositorioBase<Cliente> repositorio = new RepositorioBase<Cliente>();
            List<Cliente> list = new List<Cliente>();

            int id = ToInt(criterio);
            switch (index)
            {
                case 0://Todo
                    break;                    

                case 1://ClienteId
                    filtro = p => p.ClienteId == id;
                    break;

                case 2://ClienteId
                    filtro = p => p.Nombre.Contains(criterio);
                    break;
            }

            list = repositorio.GetList(filtro);

            return list;
        }

        public static List<Transacciones> FTransacciones()
        {
            Expression<Func<Transacciones, bool>> filtro = p => true;
            RepositorioBase<Transacciones> repositorio = new RepositorioBase<Transacciones>();
            List<Transacciones> list = new List<Transacciones>();

            list = repositorio.GetList(filtro);

            return list;
        }

        public static List<Cliente> FClientes()
        {
            Expression<Func<Cliente, bool>> filtro = p => true;
            RepositorioBase<Cliente> repositorio = new RepositorioBase<Cliente>();
            List<Cliente> list = new List<Cliente>();

            list = repositorio.GetList(filtro);

            return list;
        }
    }
}