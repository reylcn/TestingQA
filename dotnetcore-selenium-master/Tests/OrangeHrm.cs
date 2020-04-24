using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using coretest.pageobjects.OrangeHrm;
using dotnetcoreselenium.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace coretest.Tests
{
    [TestFixture]
    public class OrangeHrmTest : Base
    {
        [Test]
        
        public void OrangeHrmAddCandidateTest()
        {
            var orangeHrm = new LoginPage();
            var dashboard = new DashboardPage();
            var candidates = new CandidatesPage();

            orangeHrm.GoToMainPage();
            orangeHrm.LoginWithDefaultCredentions();

            dashboard.OpenRecruitmentPage();
            dashboard.OpenCandidatesFromMenu();

            candidates.OpenNewCandidatesModal();
            var currentNumberOfCandidates = candidates.GetNumberOfCandidates();
            Console.WriteLine(currentNumberOfCandidates);

           
            candidates.AddCandidate("QA", "Automation - " + DateTime.Today.ToShortDateString(), "test@test.com");
            

        }
    }
}
