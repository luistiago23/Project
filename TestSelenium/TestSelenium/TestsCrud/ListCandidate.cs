using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace TestSelenium.TestsCrud
{
    [TestFixture]
    class ListCandidate
    {
        IWebDriver driver = new ChromeDriver(@"C:\Project\TestSelenium\TestSelenium\drivers");
        [Test]
        public void ChekcListCandidate()
        {
            driver.Navigate().GoToUrl("http://localhost:4200/list");
            bool foundName = driver.PageSource.Contains("Luís Tiago Pinho");
            bool foundEmail = driver.PageSource.Contains("luistiago.snow@gmail.com");

            Assert.IsTrue(foundName);
            Assert.IsTrue(foundEmail);

            driver.Close();
        }
    }
}
