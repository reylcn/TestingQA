using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    public  class EAPageObject
    {

        public  EAPageObject()
        {
            PageFactory.InitElements(PropertyCollection.driver, this);
        }


        [FindsBy(How = How.Id,Using ="TitleId")]
        public IWebElement TitleID { get; set; }
       
        [FindsBy(How = How.Name, Using = "Initial")]
        public IWebElement TxtInitial { get; set; }

        [FindsBy(How = How.Name, Using = "FirstName")]
        public IWebElement TxtFirstName { get; set; }

        [FindsBy(How = How.Name, Using = "MiddleName")]
        public IWebElement TxtMiddleName { get; set; }

        [FindsBy(How = How.Name, Using = "Save")]
        public IWebElement btnSave { get; set; }

        public void FillUserForm(string initail,string middleName,string firstName)
        {
            TxtInitial.EnterText(initail);
            TxtFirstName.EnterText(middleName);
            TxtMiddleName.EnterText(firstName);
            btnSave.Click();
        }
    }
}
