using Microsoft.VisualBasic;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalTaskGemicle.DescriptionsPages;

namespace TechnicalTaskGemicle.Test
{
    public class TestOpenPosition : BaseTest
    {
        [Test]
        public void TestOpenPositionQA()
        {
            CompanyCareersPage careersPage = new CompanyCareersPage(driver);

            var openCarrersPage = careersPage.ClickExploreOpenPositionButton();
            var filterOfficeSection = openCarrersPage.ClickfilterOfficesButton();
            var ukrOfficePosition = filterOfficeSection.ClickUkrfilterOfficesButton();

            ukrOfficePosition.AvailabilitOpenCareersQAEngineer();
        }
    }
}
