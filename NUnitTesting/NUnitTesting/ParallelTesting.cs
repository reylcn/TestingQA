using NUnit.Framework;
using NUnitTesting.BaseClass;
using NUnitTesting.Utilites;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting
{
    
        [TestFixture]
        public class ParallelTesting : BaseTest
        {
         IWebDriver driver;

            [Test, Category("UAT Testing"),Category("Module1")]
            public void TestMethod1()
            {
                var Driver= new Browser().Init(driver);
                IWebElement emailTextFild = driver.FindElement(By.XPath(".//*[@id='email']"));
                emailTextFild.SendKeys("Selenim C#");
                Driver.Close();
                
            }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod2()
        {
            var Driver = new Browser().Init(driver);
            IWebElement emailTextFild = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextFild.SendKeys("Selenim C#");
            Driver.Close();

        }
        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod3()
        {
            var Driver = new Browser().Init(driver);
            IWebElement emailTextFild = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextFild.SendKeys("Selenim C#");
            Driver.Close();

        }
        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod4()
        {
            var Driver = new Browser().Init(driver);
            IWebElement emailTextFild = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextFild.SendKeys("Selenim C#");
            Driver.Close();

        }



    }
    
}
