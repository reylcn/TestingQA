using KupujemProdajemCyrillic.Driver;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KupujemProdajemCyrillic.PageObject
{
    public class KupujemProdajem
    {

        const int euroValue = 118; 

        private readonly IWebDriver driver = WebDriver.Instance;

        private IWebElement search => driver.FindElement(By.Id("searchKeywordsInput"));

        private IWebElement searchbox => driver.FindElement(By.ClassName("kpACListItemLabel"));

        private IWebElement closeBtn => driver.FindElement(By.ClassName("kpBoxCloseButton"));

        private IWebElement cookieBtn => driver.FindElement(By.Name("i-understand"));
    
        private IEnumerable<IWebElement> items => driver.FindElements(By.ClassName("nameSec"));

        private IEnumerable<IWebElement> itemsPrice => driver.FindElements(By.CssSelector("span.adPrice"));

        private IWebElement sort => driver.FindElement(By.CssSelector("#orderSecondSelection > div > div.choiceLabelHolder > div.choiceLabel"));

        private IWebElement highPrice => driver.FindElement(By.CssSelector("div.uiMenuItem[data-text='Skuplje']"));

        private IWebElement lowPrice => driver.FindElement(By.CssSelector("div.uiMenuItem[data-text='Jeftinije']"));

        private IWebElement SearchBtn => driver.FindElements(By.CssSelector("input[name='submit[search]']"))[1];


        public void CloseLoginModal()
        {
            closeBtn.Click();
        }

        public void SearchOnKP(string term)
        {
            search.Clear();
            search.SendKeys(term);
        }

        public void ClickOnSuggestion()
        {
            searchbox.Click();
        }

        public void OpenSort()
        {
            sort.Click();
        }

        public void HightPriceClick()
        {
            highPrice.Click();
        }
        public void LowPriceClick()
        {
            lowPrice.Click();
        }

        public void SearchBtnClick()
        {
            SearchBtn.Click();
        }

        public void PrintTopFiveResults()
        {
            var mostExpensive = items.Take(5);
            foreach (var item in mostExpensive)
            {
                Console.WriteLine(item.FindElement(By.ClassName("fixedHeight")).Text);
            }
        }

        public void AssertPriceIsHigherThen1000e()
        {
            var mostExpensive = itemsPrice.Take(5); 
            foreach (var item in mostExpensive)
            {
                if (item.Text.Contains("din"))
                {
                    string price = item.Text.Substring(0, item.Text.IndexOf(" "));
                    var totalPrice = int.Parse(price.Replace(".", ""));
                    Assert.IsTrue(totalPrice > 1000 * euroValue, "Cena je veca od 1000e");
                }
                else
                {
                    string price = item.Text.Substring(0, item.Text.IndexOf(" "));
                    var price2 = price.Substring(0, price.IndexOf(","));
                    var totalPrice = int.Parse(price2.Replace(".", ""));
                    Assert.IsTrue(totalPrice > 1000, "Cena je manja od 1000e");
                }
            }
        }

        public void AssertPriceIsLowThen1180d()
        {
            var mostChipest = itemsPrice.Take(5);
            foreach (var item in mostChipest)
            {
                if (item.Text.Contains("din"))
                {
                    string price = item.Text.Substring(0, item.Text.IndexOf(" "));
                    price.Substring(0, price.IndexOf(""));
                    var totalPrice = int.Parse(price.Replace(".", ""));
                    Assert.IsTrue(totalPrice > 1000, "Cena je veca od 1180d");
                }
                else
                {
                    string price = item.Text.Substring(0, item.Text.IndexOf(" "));
                    var totalPrice = int.Parse(price.Replace(",", ""));
                    Assert.IsTrue(totalPrice > 1000 / euroValue, "Cena je manja od 1180d");
                }
            }

        }

        public void CookiesAccept()
        {
            cookieBtn.Click();
        }

    }
}
