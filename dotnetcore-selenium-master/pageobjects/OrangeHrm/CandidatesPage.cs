using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using dotnetcoreselenium.driver;
using OpenQA.Selenium;

namespace coretest.pageobjects.OrangeHrm
{
    public class CandidatesPage
    {
        private IWebDriver driver = WebDriver.Instance;

        private IWebElement NumberOfCandidates => driver.FindElement(By.Id("fromToOf")); 

        private IWebElement AddCandidatesBtn => driver.FindElement(By.Id("addItemBtn"));

        private IWebElement FirstNameInput => driver.FindElement(By.Id("addCandidate_firstName"));

        private IWebElement LastNameInput => driver.FindElement(By.Id("addCandidate_lastName"));

        private IWebElement EmailInput => driver.FindElement(By.Id("addCandidate_email"));

        private IWebElement SaveCandidateBtn => driver.FindElement(By.Id("saveCandidateButton")); 

        public int GetNumberOfCandidates()
        {
            var result = NumberOfCandidates.Text.Split(" ")[4];
            return int.Parse(result);
        }

        public void OpenNewCandidatesModal()
        {
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            driver.SwitchTo().Frame("noncoreIframe");
            var js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("document.getElementById('addItemBtn').click()");
            AddCandidatesBtn.Click();
        }

        public void AddCandidate(string firstName, string lastName, string email)
        {
            FirstNameInput.SendKeys(firstName);
            LastNameInput.SendKeys(lastName);
            EmailInput.SendKeys(email);
      
         
            
        }

        public void SaveCandidate()
        {
            SaveCandidateBtn.Click();
        }
      
    }
}
