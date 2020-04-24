using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    public static class SeleniumSetMethod
    {
        //Enter Text
        //Extrended method for entering text in the controle
        //<param name="element"></param>
        //<param name="value"></param>
        public static void EnterText(this IWebElement element, string value)
        {
            element.SendKeys(value);
        }

       
        //Click into a button,ChekcBox, option etc
        //<param name="element"></param>
        public static void Click(this IWebElement element)
        {
            element.Click();
        }

        //Selecting a drop down control
        //<param name="element"></param>
        //<param name="value"></param>
        public static void SelectDropDown(this IWebElement element, string value)
        {
         new SelectElement(element).SelectByText(value);
        }
    }
}
