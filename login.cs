
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gmail
{
    [TestFixture]
    public class TestClass
    {
        IWebDriver driver;
        [SetUp]
        public void StartBrowser()
        {
           driver = new ChromeDriver();
           driver.Url="http://www.google.co.in";

            driver.Url = "https://accounts.google.com/AccountChooser/identifier?service=mail&continue=https%3A%2F%2Fmail.google.com%2Fmail%2F&flowName=GlifWebSignIn&flowEntry=AddSession";
            driver.Manage().Window.Maximize();

        }

        [Test]
        public void Testlogin()
        {
            IWebElement username = driver.FindElement(By.Name("identifier"));
            username.SendKeys("madhup285@gmail.com");
            IWebElement next = driver.FindElement(By.Id("identifierNext"));
            next.Click();
            Boolean status = next.Displayed;
        }
      [TearDown]
       public void Close()
        {
           driver.Close();
        }
    }
}
