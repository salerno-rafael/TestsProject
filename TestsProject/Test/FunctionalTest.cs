using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;

namespace TestsProject {

    [TestClass]

    public class FunctionalTest {

        [TestMethod]
        public void HomePageTest() {
            using (var drive = new ChromeDriver()) {
                drive.Navigate().GoToUrl("https://www.google.com.br/");
                Assert.IsTrue(drive.PageSource.Contains("Brasil"));
            }
        }
    }
}
