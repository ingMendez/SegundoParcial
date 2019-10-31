using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace BLL.Tests
{
    [TestClass()]
    public class RepositorioBaseTests
    {

        [TestMethod]
        public void Guardar()
        {
            RepositorioBase<Cliente> repositorio = new RepositorioBase<Cliente>();
            Cliente cliente = new Cliente();
            bool paso = false;

            cliente.ClienteId = 3;
            cliente.Nombre = "Jose";
            cliente.Balance = 500;

            paso = repositorio.Guardar(cliente);
            Assert.AreEqual(true, paso);
        }

       
   
        
    }
}