using AutomationFramework.Helpers;
using AutomationFramework.PageObject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.TestCase
{
    [TestFixture]
    public class TestLoginPage:Base
    {

        [Test]
        public void TestLogin()
        {
            var openStore = new StorePage();
            openStore.OpenStore();
            var storLogin = new LoginPageObject();
            var mainPage = new MainPageObject();

            mainPage.Dismiss();
            mainPage.Account();

            storLogin.LoginWeb();
            storLogin.LoginWithCredentions();

            
            
            
            
               
            
        }  
        
    }
}
