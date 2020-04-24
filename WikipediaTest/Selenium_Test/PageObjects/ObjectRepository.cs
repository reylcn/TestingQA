using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Test.PageObjects
{
    internal class ObjectRepository
    {
        public class MainPage
        {
            public const string WelcomeText = "Welcome to Wikipedia,";
            public const string CheckText = "Serbia";
            public static By WelcomTextId = By.Id("main-page-welcome");
            public static By DaneWiki = By.PartialLinkText("Talk");
            public static By DaneSearch = By.Id("searchInput");
            public static By searchButton = By.Id("searchButton");
            public static string MainPageUrl = "https://en.wikipedia.org/wiki/Main_Page";
        }
    }
}
