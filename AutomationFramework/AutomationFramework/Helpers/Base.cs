using AutomationFramework.Driver;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.Helpers
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
