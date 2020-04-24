using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Vivify_Ideas_QA_Test.Driver;

namespace Vivify_Ideas_QA_Test.Helpers
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
           
            WebDriver.Cleanup();
        }
    }
}
