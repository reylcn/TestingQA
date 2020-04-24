using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QaAutomation
{
    [TestClass]
    public class WebTables
    {
        IWebDriver driver = new ChromeDriver();

        [TestMethod]
        public void Table()
        {
            driver.Url = "https://en.wikipedia.org/wiki/Programming_languages_used_in_most_popular_websites";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);

            var elemTable = driver.FindElement(By.XPath("//div[@id='mw-content-text']//table[1]"));
            List<IWebElement> listTrElem = new List<IWebElement>(elemTable.FindElements(By.TagName("tr")));
            String strRowDate = "";

            foreach (var elemTr in listTrElem)
            {
                List<IWebElement> listTdEleme = new List<IWebElement>(elemTr.FindElements(By.TagName("td")));
                if (listTrElem.Count>0)
                {
                    foreach (var elemTd in listTdEleme)
                    {
                        strRowDate = strRowDate + elemTd.Text + "\t\t";
                    }
                }
                else
                {
                    Console.WriteLine("This is Header Row");
                    Console.WriteLine(listTdEleme[0].Text.Replace("","\t\t"));
                }
                
            }
            Console.WriteLine(strRowDate);
            strRowDate = string.Empty;
            Console.WriteLine("");
            driver.Quit();
        }
    }
}
