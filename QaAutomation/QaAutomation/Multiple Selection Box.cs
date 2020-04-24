using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    [TestClass]
    public class Multiple_Selection_Box
    {
        IWebDriver driver = new ChromeDriver();
        [TestMethod]
        public void MultipleBox()
        {
            driver.Url = "https://demoqa.com/automation-practice-form/";
            driver.Manage().Window.Maximize();
            SelectElement selectElement = new SelectElement
                (driver.FindElement(By.Name("selenium_commands")));
            selectElement.SelectByIndex(0);
            selectElement.DeselectByIndex(0);
            selectElement.SelectByText("Navigation Commands");
            selectElement.DeselectByText("Navigation Commands");

            IList<IWebElement> webs = selectElement.Options;
            int iListSize = webs.Count;
            for (int i = 0; i < iListSize; i++)
            {
                String sValu = selectElement.Options.ElementAt(i).Text;
                Console.WriteLine("Value of the Select item is : " + sValu);
                selectElement.SelectByIndex(i);
                
            }
            selectElement.DeselectAll();
            driver.Close();
        }
        

    }
}
