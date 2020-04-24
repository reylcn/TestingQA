using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    class Program
    {
       
       

        static void Main(string[] args)
        {
        }

        [SetUp]
        public void Initialize()
        {
            PropertyCollection.driver = new ChromeDriver();
            //Navigate to Google page
            PropertyCollection.driver.Navigate().GoToUrl("http://www.executeautomation.com/demosite/Login.html");
            Console.WriteLine("Open Browser");
        }

        [Test]
        public void ExecuteTest()
        {
            ExelLib.PopulateInCollection(@"C:\Users\Marko\Desktop\Excel.xlsx");
            //Login to App
            LoginPageObject loginPage = new LoginPageObject();
            EAPageObject pageEa = loginPage.Login(ExelLib.ReadData(1,"UserName"),ExelLib.ReadData(1,"Password"));


            pageEa.FillUserForm(ExelLib.ReadData(1,"Initial"),ExelLib.ReadData(1,"MiddelName"),ExelLib.ReadData(1,"FisrtName"));

            //Inicialez the page by calling refernce

            //EAPageObject page = new EAPageObject();
            //page.txtInitial.SendKeys("executeautomation");
            //page.btnSave.Click();


            ////Titel
            //SeleniumSetMethod.SelectDropDown("TitleId", "Mr.", PropertyType.Id);
            ////Initcial
            //SeleniumSetMethod.EnterText("Initial", "executeautomation",PropertyType.Name);

            //Console.WriteLine("The value from my Title is:" + SeleniumGetMethod.GetText("TitleId",PropertyType.Id));

            //Console.WriteLine("The value my Initial is: " + SeleniumGetMethod.GetText("Initial", PropertyType.Name));
            ////Click
            //SeleniumSetMethod.Click("Save", PropertyType.Name);
        }
       
        [TearDown]
        public void CleanUp()
        {

            PropertyCollection.driver.Close();
            Console.WriteLine("Close Test");
        }
    }
}
 