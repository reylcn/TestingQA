using coretest.pageobjects;
using dotnetcoreselenium.Helpers;
using NUnit.Framework;

namespace coretest.Tests
{
    [TestFixture]
    public class GoogleCheeseTest : Base
    {
        
        [Test]
        public void CountCheese()
        {

            var googlePage = new GooglePage();
            googlePage.OpenGooglePage();
            googlePage.SearchOnGoogle("cheese");
            var cheeseAmount = googlePage.GetSearchResultNumber();
            Assert.AreEqual(777, cheeseAmount, "There is too much cheese on the internet");
            googlePage.Close();
            

        }
          
    }

          //Test must fall
}
