using NulTienProjectKupujemProdajem.Driver;
using NUnit.Framework;
using OpenQA.Selenium;

namespace NulTienProjectKupujemProdajem.PageObject
{
    public class KupujemProdajem
    {
        private readonly IWebDriver driver = WebDriver.Instance;

        private IWebElement search => driver.FindElement(By.Id("searchKeywordsInput"));

        private IWebElement searchbox => driver.FindElement(By.XPath("//*[@id='autocompleteHolder']/div/div[2]/ul/li[2]/span"));

        private IWebElement breadcramp => driver.FindElement(By.ClassName("ad-list-breadcrumbs"));

        private IWebElement closeBtn => driver.FindElement(By.ClassName("kpBoxCloseButton"));

        private IWebElement cookieBtn => driver.FindElement(By.Name("i-understand"));

        private IWebElement sortAdds => driver.FindElement(By.XPath("//*[@id='orderSecondSelection']/div/div[1]/div[1]/span[1]"));


        public void CloseLoginModal()
        {
            closeBtn.Click();
        }

        public void SearchOnKP(string term)
        {
            search.Clear();
            search.SendKeys(term);
            search.Click();
        }

        public void ClickOnSuggestion()
        {
            searchbox.Click();
        }

        public void CookiesAccept()
        {
            cookieBtn.Click();
        }

        public void VerifyCategory(string category)
        {
            Assert.IsTrue(breadcramp.Text.Contains(category));
        }

        public void SortByPrice(string sort)
        {
            sortAdds.Click();
            sortAdds.GetAttribute(sort);
            sortAdds.Click();

        }
    }
}
