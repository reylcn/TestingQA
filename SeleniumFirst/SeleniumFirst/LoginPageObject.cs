using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    class LoginPageObject
    {

        public LoginPageObject()
        {
            PageFactory.InitElements(PropertyCollection.driver, this);
        }

        [FindsBy(How =How.Name,Using ="UserName")]
        public IWebElement TxtUserName { get; set; }

        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement TxtPassword { get; set; }

        [FindsBy(How = How.Name, Using = "Login")]
        public IWebElement BtnLogin { get; set; }

        public EAPageObject Login(string userName, string password)
        {
            //User Name
            TxtUserName.EnterText(userName);
            //Password
            TxtPassword.EnterText(password);
            //Click button
            BtnLogin.Click();

            //Return the page object
            return new EAPageObject();
        }
    }
}
