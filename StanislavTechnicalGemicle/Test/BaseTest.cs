using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalTaskGemicle.Test
{
    public class BaseTest
    {
        protected IWebDriver driver;

        [SetUp]
        public virtual void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.optimove.com/careers");
        }

        [TearDown]
        public virtual void TearDown()
        {
            driver.Quit();
        }
    }
}
