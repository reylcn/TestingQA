using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dotnetcoreselenium.driver;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace coretest.pageobjects
{
    public class GooglePage
    {
        private readonly IWebDriver driver = WebDriver.Instance;

        private IWebElement SearchField => driver.FindElement(By.Name("q"));

        private IWebElement GoogleSearchBtn => driver.FindElement(By.Name("btnK"));

        private IWebElement DemoQaLink => driver.FindElement(By.CssSelector("#search a"));

        private IWebElement SearchResultNumber => driver.FindElement(By.Id("result-stats"));

        public void OpenGooglePage()
        {
            driver.Navigate().GoToUrl("http://google.com/");
        }

        public void SearchOnGoogle(string term)
        {
            SearchField.Clear();
            SearchField.SendKeys(term);
            GoogleSearchBtn.Click();
            
        }

        public void OpenDemoQa()
        {
            DemoQaLink.Click();
        }

        public int GetSearchResultNumber()
        {
            var result = SearchResultNumber.Text.Split(" ")[1].Replace(".", "");
            return int.Parse(result);
        }

    
        public void Close()
        {
            driver.Close();
          
        }
    }
}
