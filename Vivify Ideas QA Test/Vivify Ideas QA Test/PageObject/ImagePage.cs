using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using Vivify_Ideas_QA_Test.Driver;

namespace Vivify_Ideas_QA_Test.Object
{
    public class ImagePage
    {
        private IWebDriver driver = WebDriver.Instance;


        private IWebElement clickTest04 => driver.FindElement(By.LinkText("Test04"));
        private IWebElement image => driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[1]/div/div/div/a/div/img"));
        private IWebElement clickCreateBy => driver.FindElement(By.XPath("/html/body/div/div[2]/div/h5/a"));

        public void NavigateToHomePage()
        {
            driver.Navigate().GoToUrl("https://gallery-app.vivifyideas.com/");
        }

        public void ClickTest04()
        {
            clickTest04.Click();

        }
        public string Image()
        {
            return image.GetAttribute("src");
            
         
        }
        public void ClickCreateBy()
        {
            clickCreateBy.Click();
        }
    }
}
