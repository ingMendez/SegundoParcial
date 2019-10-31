using BLL;
using Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcialAplicada2.Tests
{
    [TestClass]
    public class ClientesTest
    {
        [TestMethod]
        public void Guardar()
        {
            RepositorioBase<Cliente> repositorio = new RepositorioBase<Cliente>();
            Cliente cliente = new Cliente();
            bool paso = false;

            cliente.ClienteId = 1;
            cliente.Nombre = "Jose";
            cliente.Balance = 0;

            paso = repositorio.Guardar(cliente);
            Assert.AreEqual(true, paso);
        }

        [TestMethod]
        public void Modificar()
        {
            int id = 1;
            RepositorioBase<Cliente> repositorio = new RepositorioBase<Cliente>();
            Cliente cliente = new Cliente();
            cliente = repositorio.Buscar(id);

            bool paso = false;
            cliente.Nombre = "Fernando";
            paso = repositorio.Modificar(cliente);
            Assert.AreEqual(true, paso);
        }

        [TestMethod]
        public void Buscar()
        {
            int id = 1;
            RepositorioBase<Cliente> repositorio = new RepositorioBase<Cliente>();
            Cliente cliente = new Cliente();
            cliente = repositorio.Buscar(id);

            Assert.IsNotNull(cliente);
        }

        [TestMethod]
        public void Eliminar()
        {
            RepositorioBase<Cliente> repositorio = new RepositorioBase<Cliente>();
            int id = 1;
            bool paso = false;
            paso = repositorio.Eliminar(id);
            Assert.AreEqual(true, paso);
        }
    }
}
