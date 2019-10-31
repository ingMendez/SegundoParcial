using System;
using BLL;
using Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SegundoParcialAplicada2.Tests
{
    [TestClass]
    public class TransacionesTest
    {
        [TestMethod]
        public void Guardar()
        {
            RepositorioBase<Transacciones> repositorio = new RepositorioBase<Transacciones>();
            Transacciones transaccion = new Transacciones();
            bool paso = false;
            bool pasoC = false;

            transaccion.TransacionId = 1;
            transaccion.ClienteId = 1;
            transaccion.Fecha = DateTime.Now;
            transaccion.Tipo = "Tipo";
            transaccion.Monto = 1000;

            paso = repositorio.Guardar(transaccion);
            Assert.AreEqual(true, paso);
        }

        [TestMethod]
        public void Modificar()
        {
            int id = 1;
            RepositorioBase<Transacciones> repositorio = new RepositorioBase<Transacciones>();
            Transacciones transaccion = new Transacciones();
            transaccion = repositorio.Buscar(id);

            bool paso = false;
            transaccion.Monto = 1500;
            paso = repositorio.Modificar(transaccion);
            Assert.AreEqual(true, paso);
        }

        [TestMethod]
        public void Buscar()
        {
            int id = 1;
            RepositorioBase<Transacciones> repositorio = new RepositorioBase<Transacciones>();
            Transacciones transaccion = new Transacciones();
            transaccion = repositorio.Buscar(id);

            Assert.IsNotNull(transaccion);
        }

        [TestMethod]
        public void Eliminar()
        {
            RepositorioBase<Transacciones> repositorio = new RepositorioBase<Transacciones>();
            int id = 1;
            bool paso = false;
            paso = repositorio.Eliminar(id);
            Assert.AreEqual(true, paso);
        }

    }
}
