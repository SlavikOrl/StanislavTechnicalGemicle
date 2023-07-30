using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalTaskGemicle.Pages
{
    public class BasePage
    {
        private readonly TimeSpan _defaultTimeToWait = TimeSpan.FromSeconds(30);
        protected IWebDriver driver;

        public BasePage(IWebDriver webDriver)
        {
            driver = webDriver;
        }
        public void ScrollDownToElement(IWebElement element)
        {
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;

            jsExecutor.ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }
        public void ScrollToElement(int pixelsToScroll)
        {
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;

            jsExecutor.ExecuteScript($"window.scrollBy(0, {pixelsToScroll});");
        }
        public IWebElement? WaitForElementToBeVisible(string xpath, TimeSpan timeToWait = default)
        {
            var wait = new WebDriverWait(driver, timeToWait == default ? _defaultTimeToWait : timeToWait);
            try
            {
                return wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(xpath)));
            }
            catch (Exception)
            {
                return null;
            }
        }
        public IWebElement? WaitForElementToBeClickable(IWebElement element, TimeSpan timeToWait = default)
        {
            var wait = new WebDriverWait(driver, timeToWait == default ? _defaultTimeToWait : timeToWait);
            try
            {
                ScrollDownToElement(element);
                return wait.Until(ExpectedConditions.ElementToBeClickable(element));
            }
            catch (Exception)
            {
                return null;
            }
        }
        public bool AvailabilitOfElementsOnThePage(string xPath)
        {
            var elements = driver.FindElements(By.XPath(xPath));
            if (elements.Count > 0)
                return true;
            else
                return false;
        }
    }
}
