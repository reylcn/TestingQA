using NUnit.Framework;
using NulTienProjectKupujemProdajem.Driver;
using NUnit.Framework.Interfaces;


namespace NulTienProjectKupujemProdajem.Helpers
{
    public class Base
    {
        [SetUp]
        public static void BeforeScenario()
        {
            WebDriver.Initialize();
        }

        [TearDown]
        public static void AfterScenario()
        {
            if (!TestCompletedWithoutErrors())
            {
                Utilities.SendScreenShotEmail(WebDriver.TakeScreenShot(TestContext.CurrentContext.Test.Name));
            }
            WebDriver.Cleanup();
        }

        public static bool TestCompletedWithoutErrors()
        {
            return TestContext.CurrentContext.Result.Outcome.Equals(ResultState.Inconclusive) ||
                   TestContext.CurrentContext.Result.Outcome.Equals(ResultState.Success);
        }
    }
}

