using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestsProject.Business;
using TestsProject.Dao;
using TestsProject.Model;

namespace TestsProject.Test {

    [TestClass]
    public class ContractTest {

        [TestMethod]
        public void InvoiceTotalTest() {
            Assert.AreEqual(258, new InvoiceBusiness(MockDao().Object).TotalInvoice("123"));
        }

        private Mock<InvoiceDao> MockDao() {
            var mockDao = new Mock<InvoiceDao>();
            mockDao.Setup(m => m.GetInvoiceValue()).Returns(new Invoice("123", 200, 22, 33));
            return mockDao;
        }
    }
}
