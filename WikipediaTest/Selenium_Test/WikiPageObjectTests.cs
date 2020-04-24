using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Selenium_Test.PageObjects;

namespace Selenium_Test
{
    [TestClass]
    public class WikiPageObjectTests
    {
        WikiMainPage mainPage;

        [TestInitialize]
        public void TestInitilize()
        {
            mainPage = new WikiMainPage();
            mainPage.LoadPage();
        }


        [TestMethod]
        public void ShouldLoadHomePageWhenClickOnLogo()
        {

            Assert.IsTrue(mainPage.IsPageLoaded());
        }

        [TestMethod]
        public void ClickInLink()
        {

            mainPage.InData();
        
        }
        
        [TestCleanup]
        public void TestCleanup()
        {
            mainPage.Close();
        }
    }
}
