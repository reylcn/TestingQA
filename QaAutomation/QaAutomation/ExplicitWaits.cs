﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QaAutomation
{
    //[TestClass]
    //public class ExplicitWaits
    //{
    //    IWebDriver driver = new ChromeDriver();
    //    [TestMethod]
    //    public void Explicit()
    //    {
    //        driver.Url = "https://demoqa.com/automation-practice-switch-windows/";
    //        IWebElement element = driver.FindElement(By.Id("clock"));
    //        DefaultWait<IWebElement> wait = new DefaultWait<IWebElement>(element);
    //        wait.Timeout=TimeSpan.FromMinutes(2);
    //        wait.PollingInterval = TimeSpan.FromMilliseconds(250);
    //        Func<IWebElement, bool> waiter = new Func<IWebElement, bool>((IWebElement ele) =>
    //               {

    //                   string styleAttrib = element.Text;
    //                   if (styleAttrib.Contains("Buzz"))
    //                   {
    //                       return true;
    //                   }
    //                   Console.WriteLine("Current time is" + styleAttrib);
    //                   return false;
    //               });
    //        wait.Until(waiter);
    //    }
    //}
}
