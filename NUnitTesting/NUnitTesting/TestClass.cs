using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnitTesting.BaseClass;
using OpenQA.Selenium.Support.UI;

namespace NUnitTesting
{
    [TestFixture]
    public class TestClass :BaseTest
    {
        [Test,Category("Smoke testing")]
        public void TestMethod1()
        {
            
            IWebElement emailTextFild=driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextFild.SendKeys("Selenim C#");
            IWebElement mountDropDownList=driver.FindElement(By.Id("month"));
            SelectElement element = new SelectElement(mountDropDownList);
            element.SelectByIndex(1);//Select by index
            element.SelectByText("Mar");//Selecy by text
            element.SelectByValue("6");//Select by value
        }
        [Test,Category("Regression Testing")]
        public void TestMethod2()
        {

            IWebElement emailTextFild = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextFild.SendKeys("Selenim C#");

        }
        [Test,Category("Smoke Testing")]
        public void TestMethod3()
        {

            IWebElement emailTextFild = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextFild.SendKeys("Selenim C#");

        }


    }
}
