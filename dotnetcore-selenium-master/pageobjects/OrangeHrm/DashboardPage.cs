using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dotnetcoreselenium.driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace coretest.pageobjects.OrangeHrm
{
    public class DashboardPage
    {
        private IWebDriver driver = WebDriver.Instance;

        private IWebElement RecruitmentBtn => driver.FindElement(By.Id("menu_recruitment_viewRecruitmentModule"));

        private IWebElement SideMenu => driver.FindElement(By.CssSelector("#content > div.navbar-fixed > nav > div > a.button-collapse.show-on-large"));

        private IWebElement CandidatesLink => driver.FindElement(By.LinkText("Candidates"));



        public void OpenRecruitmentPage()
        {
            RecruitmentBtn.Click();
        }

        public void OpenCandidatesFromMenu()
        {
            driver.SwitchTo().Frame("noncoreIframe");
            SideMenu.Click();
            CandidatesLink.Click();
        }


    }
}
