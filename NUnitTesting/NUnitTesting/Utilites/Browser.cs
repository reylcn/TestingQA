using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting.Utilites
{
    public class Browser
    {
        public IWebDriver Init(IWebDriver driver)
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://wwww.facebook.com";
            return driver;
        }
    }    
}
