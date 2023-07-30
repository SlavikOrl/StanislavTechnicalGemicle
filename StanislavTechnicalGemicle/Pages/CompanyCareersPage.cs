using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalTaskGemicle.Pages
{
    public class CompanyCareersPage : BasePage
    {
        public CompanyCareersPage(IWebDriver driver) : base(driver)
        {
        }
        private static string _openPositionsButtonXpath = "//li[contains(@class, 'buttons-collection-item')]";

        public OpenCareersPage ClickExploreOpenPositionButton(TimeSpan timeToWait = default)
        {
            ScrollToElement(200);
            var openCareerButton = WaitForElementToBeVisible(_openPositionsButtonXpath, timeToWait);
            openCareerButton.Click();
            return new OpenCareersPage(driver);
        }
    }
}
