using KupujemProdajemCyrillic.Driver;
using OpenQA.Selenium;

namespace KupujemProdajemCyrillic.PageObject
{
    public class OpenKp
    {
        private readonly IWebDriver driver = WebDriver.Instance;

        public void OpenKP()
        {
            driver.Navigate().GoToUrl("https://novi.kupujemprodajem.com/");
        }
    }
   
}
