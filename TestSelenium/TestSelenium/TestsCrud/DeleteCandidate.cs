using System;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace TestSelenium.TestsCrud
{
    class DeleteCandidate
    {
        IWebDriver driver = new ChromeDriver(@"C:\CRUD\Project\TestSelenium\TestSelenium\drivers");
        [Test]
        public void TestDeleteCandidate()
        {
            driver.Navigate().GoToUrl("http://localhost:4200/list");
            driver.FindElement(By.XPath(".//*[@id='dark_master@gmail.com' and @name='delete']")).Click();
        }
    }
}
