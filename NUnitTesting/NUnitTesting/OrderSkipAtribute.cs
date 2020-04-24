using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting
{
    [TestFixture]
    public class OrderSkipAtribute
    {
        

        [Test,Order(2),Category("OrederSkipAttribute")]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://wwww.facebook.com";
            IWebElement emailTextFild = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextFild.SendKeys("Selenim C#");
            driver.Close();
        }
        [Test,Order(1),Category("OrederSkipAttribute")]
        public void TestMethod2()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://wwww.facebook.com";
            IWebElement emailTextFild = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextFild.SendKeys("Selenim C#");
            driver.Close();
        }
        [Test,Order(0), Category("OrederSkipAttribute")]
        public void TestMethod3()
        {
            IWebDriver driver = new EdgeDriver();
            driver.Url = "http://wwww.facebook.com";
            IWebElement emailTextFild = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextFild.SendKeys("Selenim C#");
            driver.Close();
        }
    }
}
