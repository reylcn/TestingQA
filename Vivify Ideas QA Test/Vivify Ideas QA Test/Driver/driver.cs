using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Vivify_Ideas_QA_Test.Driver
{
    public static class WebDriver
    {
        public static IWebDriver Instance { get; set; }

        public static void Initialize()
        {
            Instance = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            Instance.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
            Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            try
            {
                Instance.Manage().Window.Maximize();
            }
            catch (Exception e)
            {

            }
        }
        public static void Cleanup()
        {
            Instance?.Quit();
        }
    }
}
