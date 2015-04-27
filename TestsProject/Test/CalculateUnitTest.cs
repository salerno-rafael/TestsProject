using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestsProject.Business;

namespace TestsProject {

    [TestClass]
    public class CalculateUnitTest {

        [TestMethod]
        public void IpiTest() {
            Assert.AreEqual(2, CalculateBusiness.Ipi(1, 1));
        }

        [TestMethod]
        public void icmsTest() {
            Assert.AreEqual(2, CalculateBusiness.Icms(1, 1));
        }
    }
}
