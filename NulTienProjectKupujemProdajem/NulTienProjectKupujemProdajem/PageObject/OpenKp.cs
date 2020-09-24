using NulTienProjectKupujemProdajem.Driver;
using OpenQA.Selenium;

namespace NulTienProjectKupujemProdajem.PageObject
{
    public class OpenKp
    {
        private readonly IWebDriver driver = WebDriver.Instance;

        public void OpenKP()
        {
            driver.Navigate().GoToUrl("https://www.kupujemprodajem.com/");
        }
    }
}
