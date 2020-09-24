using CucumberrSpecflow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace TestProject
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        public Calculator cucumberr = new Calculator();
        public int result;
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int number)
        {
            cucumberr.operator1 = number;
        }
        
        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheCalculator(int number)
        {
            cucumberr.operator2 = number;
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            result = cucumberr.Suma();
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Assert.AreEqual(result,p0);
;        }
    }
}
