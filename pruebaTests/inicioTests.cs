using Microsoft.VisualStudio.TestTools.UnitTesting;
using prueba;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prueba.Tests
{
    [TestClass()]
    public class inicioTests
    {
        [TestMethod()]
        public void loginTest()
        {
            string usuario = "kevin";
            string contra = "1234";
            inicio met = new inicio();
            Assert.AreEqual(true, met.login(usuario, contra));
        }
    }
}