using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Vivify_Ideas_QA_Test.Driver;

namespace Vivify_Ideas_QA_Test.Object
{
    public class SearchPage
    {
        private IWebDriver driver = WebDriver.Instance;

        private IWebElement searchInpout => driver.FindElement(By.ClassName("form-control"));
        private IWebElement galleryApp => driver.FindElement(By.LinkText("Gallery App"));
        private IWebElement allGallery => driver.FindElement(By.XPath("/html/body/div/div[1]/nav/div/ul[1]/li[1]/a"));
        private IWebElement clickButton => driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[1]/div/div/button"));
       




        public void SearchInpout(string term)
        {
            searchInpout.SendKeys(term);
            
        }
        public void ClickButton()
        {
            clickButton.Click();
        }

        public void GalleryAppt()
        {
            galleryApp.Click();
        }
        public void AllGallery()
        {
            allGallery.Click();
        }
        public void Close()
        {
            driver.Close();
        }

       
    }
}
