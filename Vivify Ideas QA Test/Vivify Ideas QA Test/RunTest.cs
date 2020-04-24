using NUnit.Framework;
using Vivify_Ideas_QA_Test.Helpers;
using Vivify_Ideas_QA_Test.Object;
using Vivify_Ideas_QA_Test.PageObject;

namespace Vivify_Ideas_QA_Test
{

    [TestFixture]
    public class Tests : Base
    {


        [Test]
        public void SearchTest()
        {
            SearchPage searchpage = new SearchPage();
            ImagePage imagePage = new ImagePage();
            NavigationPage navigationPage = new NavigationPage();

            navigationPage.NavigateToHomePage();



        
            searchpage.SearchInpout("Tamara");
            searchpage.ClickButton();
            searchpage.AllGallery();
            searchpage.GalleryAppt();
            searchpage.Close();

            
           
        }
        [Test]
        public void Image()
        {
            ImagePage imagePage = new ImagePage();
            NavigationPage navigationPage = new NavigationPage();
            navigationPage.NavigateToHomePage();
            imagePage.ClickTest04();
            imagePage.Image();
            imagePage.ClickCreateBy();

            Assert.AreNotEqual(imagePage.Image(), "");

        }
    }
}