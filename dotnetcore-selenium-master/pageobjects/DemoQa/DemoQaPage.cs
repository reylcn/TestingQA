using dotnetcoreselenium.driver;
using OpenQA.Selenium;

namespace coretest.pageobjects.DemoQa
{
    public class DemoQaPage
    {
        private IWebDriver driver = WebDriver.Instance;

        private IWebElement DroppableLink => driver.FindElement(By.LinkText("Droppable"));

        private IWebElement TooltipLink => driver.FindElement(By.LinkText("Tooltip"));

        public void OpenDroppable()
        {
            DroppableLink.Click();
        }

        public void OpenTooltip()
        {
            TooltipLink.Click();
        }
    }
}
