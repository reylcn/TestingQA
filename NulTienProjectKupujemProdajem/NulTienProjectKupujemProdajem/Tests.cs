using NulTienProjectKupujemProdajem.Helpers;
using NulTienProjectKupujemProdajem.PageObject;
using NUnit.Framework;

namespace NulTienProjectKupujemProdajem
{
    [TestFixture]
    public class Tests : Base
    {
        [Test]
        public void FindSamsungMobile()
        {
            KupujemProdajem kppage = new KupujemProdajem();
            OpenKp open = new OpenKp();

            open.OpenKP();
            kppage.CloseLoginModal();
            kppage.SearchOnKP("Samsung");
            kppage.ClickOnSuggestion();
            kppage.CookiesAccept();
            kppage.VerifyCategory("Mobilni telefoni > Samsung");
            kppage.SortByPrice("Jeftinije");
        }
    }
}
