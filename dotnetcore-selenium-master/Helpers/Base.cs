using coretest.Helpers;
using dotnetcoreselenium.driver;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace dotnetcoreselenium.Helpers
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
                Utilities.SendScreenshotEmail(WebDriver.TakeScreenshot(TestContext.CurrentContext.Test.Name));
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
