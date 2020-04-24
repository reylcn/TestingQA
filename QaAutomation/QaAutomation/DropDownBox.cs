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
    public class DropDownBox
    {

        IWebDriver driver = new ChromeDriver();
        [TestMethod]
        public void DropDow()
        {
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(10);
            driver.Navigate().GoToUrl("https://demoqa.com/automation-practice-form/");
            driver.Manage().Window.Maximize();
            SelectElement oSelect = new SelectElement(driver.FindElement(By.Id("continents")));
            oSelect.SelectByText("Europe");
            oSelect.SelectByIndex(2);
            IList<IWebElement> Osize = oSelect.Options;
            int iListSize = Osize.Count;

            for (int i = 0; i < iListSize; i++)
            {
                String sValu = oSelect.Options.ElementAt(i).Text;
                Console.WriteLine("Value of the Select item is : " + sValu);
                if (sValu.Equals("Africa"))
                {
                    oSelect.SelectByIndex(i);
                    break;
                }
            }
            driver.Close();
        }
    }
}
