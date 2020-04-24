using coretest.pageobjects;
using coretest.pageobjects.DemoQa;
using dotnetcoreselenium.driver;
using dotnetcoreselenium.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;

namespace coretest.Tests
{
    [TestFixture]
    public class DemoQaTest : Base
    {
        [Test]
        public void DragAndTooltipTest()
        {
             DemoQaPage demoQaPage = new DemoQaPage();
             DroppablePage droppablePage = new DroppablePage();
             TooltipPage tooltipPage = new TooltipPage();
             GooglePage googlePage = new GooglePage();

            googlePage.OpenGooglePage();
            googlePage.SearchOnGoogle("demoqa.com");
            googlePage.OpenDemoQa();

            demoQaPage.OpenDroppable();

            droppablePage.DragObjectToBox();

            demoQaPage.OpenTooltip();

            tooltipPage.PrintAgeTip();

        }
    }
}
