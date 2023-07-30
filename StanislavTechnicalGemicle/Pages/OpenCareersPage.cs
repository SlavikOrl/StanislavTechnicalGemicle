using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalTaskGemicle.Pages
{
    public class OpenCareersPage : BasePage
    {
        public OpenCareersPage(IWebDriver webDriver) : base(webDriver)
        {
        }
        private static string _filterOfficesButtonXpath = "//div[contains(@class,'selectric')]/*[contains(@class,'button')]";
        private static string _ukrfilterOfficesButtonXpath = "//li[contains(text(), 'UKR')]";
        public OpenCareersPage ClickfilterOfficesButton(TimeSpan timeToWait = default)
        {
            var officeFilterButton = WaitForElementToBeClickable(WaitForElementToBeVisible(_filterOfficesButtonXpath, timeToWait));
            ScrollToElement(-150);
            officeFilterButton.Click();
            return new OpenCareersPage(driver);
        }
        public OpenCareersPage ClickUkrfilterOfficesButton(TimeSpan timeToWait = default)
        {
            ScrollToElement(100);
            var ukrfilterOfficesButton = WaitForElementToBeVisible(_ukrfilterOfficesButtonXpath, timeToWait);
            ukrfilterOfficesButton.Click();
            return new OpenCareersPage(driver);
        }
        public bool IsVacancyExists(string vacancyName)
        {
            return AvailabilitOfElementsOnThePage($"//div[contains(@class, 'job-card__title')]/*[contains(text(), '{vacancyName}')]");
        }
    }
}

