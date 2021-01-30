using KupujemProdajemCyrillic.Helpers;
using KupujemProdajemCyrillic.PageObject;
using NUnit.Framework;


namespace KupujemProdajemCyrillic
{
    [TestFixture]
    public class HiPriceTest : Base
    {
        [Test]
        public void FindRobotHiPrice()
        {
            KupujemProdajem kppage = new KupujemProdajem();
            OpenKp open = new OpenKp();

            open.OpenKP();
            kppage.CloseLoginModal();
            kppage.CookiesAccept();
            kppage.SearchOnKP("Robot usisivac");
            kppage.ClickOnSuggestion();
            kppage.OpenSort();
            kppage.HightPriceClick(); 
            kppage.SearchBtnClick();
            kppage.PrintTopFiveResults();
            kppage.AssertPriceIsHigherThen1000e();
        }
    }
}
