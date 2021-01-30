using KupujemProdajemCyrillic.Helpers;
using KupujemProdajemCyrillic.PageObject;
using NUnit.Framework;

namespace KupujemProdajemCyrillic
{
    [TestFixture]
    public class LowPriceTest : Base
    {
        [Test]
        public void FindRobotLowPrice()
        {
            KupujemProdajem kppage = new KupujemProdajem();
            OpenKp open = new OpenKp();

            open.OpenKP();
            kppage.CloseLoginModal();
            kppage.CookiesAccept();
            kppage.SearchOnKP("Robot usisivac");
            kppage.ClickOnSuggestion();
            kppage.OpenSort();
            kppage.LowPriceClick();
            kppage.SearchBtnClick();
            kppage.PrintTopFiveResults();
            kppage.AssertPriceIsLowThen1180d();
        }
    }
}
