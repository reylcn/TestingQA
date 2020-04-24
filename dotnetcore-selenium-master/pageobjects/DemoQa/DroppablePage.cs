using System;
using System.IO;
using dotnetcoreselenium.driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Extensions;

namespace coretest.pageobjects.DemoQa
{
    public class DroppablePage
    {
        private IWebDriver driver = WebDriver.Instance;

        private IWebElement DraggableObjectWebElement => driver.FindElement(By.Id("draggable")); 

        private IWebElement DroppableObjectWebElement => driver.FindElement(By.Id("droppable"));

        public void DragObjectToBox()
        {
            var actions = new Actions(driver);
            actions.DragAndDrop(DraggableObjectWebElement, DroppableObjectWebElement).Perform();
            //path is users/<your_user>/Local/Temp/<name_of_file> - change it how you like it
            driver.TakeScreenshot().SaveAsFile(Path.Combine($"{Path.GetTempPath()}", $"drag{DateTime.UtcNow:yyyyMMMdd}.png"));
        }
    }
}
