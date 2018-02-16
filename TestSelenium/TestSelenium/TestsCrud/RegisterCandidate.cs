﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSelenium.TestsCrud
{
    [TestFixture]
    class RegisterCandidate
    {
        IWebDriver driver = new ChromeDriver(@"C:\Project\TestSelenium\TestSelenium\drivers");
        [Test]
        public void TestRegisterCandidate()
        {
            driver.Navigate().GoToUrl("http://localhost:4200/register");

            IWebElement inputEmail = driver.FindElement(By.Id("Email"));
            IWebElement inputSkype = driver.FindElement(By.Id("Skype"));
            IWebElement inputPhone = driver.FindElement(By.Id("Phone"));
            IWebElement inputLinkedin = driver.FindElement(By.Id("Linkedin"));
            IWebElement inputCity = driver.FindElement(By.Id("City"));
            IWebElement inputState = driver.FindElement(By.Id("State"));
            IWebElement inputPortfolio = driver.FindElement(By.Id("Portfolio"));
            IWebElement inputSalaryRequirement = driver.FindElement(By.Id("SalaryRequirement"));
            IWebElement inputBankInformation = driver.FindElement(By.Id("BankInformation"));

            inputEmail.SendKeys("luistiago.snow@gmail.com");
            inputSkype.SendKeys("luistiago.snow@gmail.com");
            inputPhone.SendKeys("32929962");
            inputLinkedin.SendKeys("Pinho Tiago");
            inputCity.SendKeys("Rio de Janeiro");
            inputState.SendKeys("Rio de Janeiro");
            inputPortfolio.SendKeys("Pinho Luis");
            //driver.FindElement(By.Id("UpToFourHoursClick")).Click();
            //driver.FindElement(By.Id("FourToSixClick")).Click();
            //driver.FindElement(By.Id("SixToEightClick")).Click();
            driver.FindElement(By.Id("UpToEightClick")).Click();
            driver.FindElement(By.Id("OnlyWeekendsClick")).Click();
            inputSalaryRequirement.SendKeys("17");
            inputBankInformation.SendKeys("Central Bank Arkhan");
            //driver.FindElement(By.Id("MorningCheck")).Click();
            //driver.FindElement(By.Id("AfternoonCheck")).Click();
            driver.FindElement(By.Id("NightCheck")).Click();
            driver.FindElement(By.Id("DawnCheck")).Click();
            //driver.FindElement(By.Id("BusinessCheck")).Click();
            driver.FindElement(By.Id("NextOne")).Click();

            //Part 2
            IWebElement inputName = driver.FindElement(By.Id("Name"));
            IWebElement inputCpf = driver.FindElement(By.Id("Cpf"));
            IWebElement inputBank = driver.FindElement(By.Id("Bank"));
            IWebElement inputAgency = driver.FindElement(By.Id("Agency"));
            IWebElement inputAccountNumber = driver.FindElement(By.Id("AccountNumber"));
            
            inputName.SendKeys("Luís Tiago Pinho");
            inputCpf.SendKeys("14989625732");
            inputBank.SendKeys("Itaú");
            inputAgency.SendKeys("1643");
            //driver.FindElement(By.Id("ChainClick")).Click();
            driver.FindElement(By.Id("SavingsClick")).Click();
            inputAccountNumber.SendKeys("337372323");
            driver.FindElement(By.Id("NextTwo")).Click();

            //Part 3
            IWebElement inputOtherTechnology = driver.FindElement(By.Id("OtherTechnology"));
            IWebElement inputLinkCrud = driver.FindElement(By.Id("LinkCrud"));

            driver.FindElement(By.XPath(".//*[@id='Ionic']/div/div[contains(.,'4')]")).Click();
            driver.FindElement(By.XPath(".//*[@id='Android']/div/div[contains(.,'3')]")).Click();
            driver.FindElement(By.XPath(".//*[@id='Ios']/div/div[contains(.,'2')]")).Click();
            driver.FindElement(By.XPath(".//*[@id='Html']/div/div[contains(.,'2')]")).Click();
            driver.FindElement(By.XPath(".//*[@id='Css']/div/div[contains(.,'5')]")).Click();
            driver.FindElement(By.XPath(".//*[@id='Bootstrap']/div/div[contains(.,'1')]")).Click();
            driver.FindElement(By.XPath(".//*[@id='Jquery']/div/div[contains(.,'4')]")).Click();
            driver.FindElement(By.XPath(".//*[@id='AngularJs']/div/div[contains(.,'5')]")).Click();
            driver.FindElement(By.XPath(".//*[@id='java']/div/div[contains(.,'1')]")).Click();
            driver.FindElement(By.XPath(".//*[@id='AspNet']/div/div[contains(.,'3')]")).Click();
            driver.FindElement(By.XPath(".//*[@id='C']/div/div[contains(.,'3')]")).Click();
            driver.FindElement(By.XPath(".//*[@id='CPlusPlus']/div/div[contains(.,'3')]")).Click();
            driver.FindElement(By.XPath(".//*[@id='Cake']/div/div[contains(.,'5')]")).Click();
            driver.FindElement(By.XPath(".//*[@id='DJango']/div/div[contains(.,'5')]")).Click();
            driver.FindElement(By.XPath(".//*[@id='Majento']/div/div[contains(.,'4')]")).Click();
            driver.FindElement(By.XPath(".//*[@id='Php']/div/div[contains(.,'3')]")).Click();
            driver.FindElement(By.XPath(".//*[@id='Wordpress']/div/div[contains(.,'2')]")).Click();
            driver.FindElement(By.XPath(".//*[@id='Phyton']/div/div[contains(.,'2')]")).Click();
            driver.FindElement(By.XPath(".//*[@id='Ruby']/div/div[contains(.,'5')]")).Click();
            driver.FindElement(By.XPath(".//*[@id='MySqlServer']/div/div[contains(.,'4')]")).Click();
            driver.FindElement(By.XPath(".//*[@id='MySql']/div/div[contains(.,'2')]")).Click();
            driver.FindElement(By.XPath(".//*[@id='SalesForce']/div/div[contains(.,'1')]")).Click();
            driver.FindElement(By.XPath(".//*[@id='Photoshop']/div/div[contains(.,'4')]")).Click();
            driver.FindElement(By.XPath(".//*[@id='Illustrator']/div/div[contains(.,'3')]")).Click();
            driver.FindElement(By.XPath(".//*[@id='Seo']/div/div[contains(.,'2')]")).Click();
            inputOtherTechnology.SendKeys("Asp.net, Angular 5");
            inputLinkCrud.SendKeys("http://localhost:4200/list");
            driver.FindElement(By.Id("submitForm")).Click();
        }
    }
}
