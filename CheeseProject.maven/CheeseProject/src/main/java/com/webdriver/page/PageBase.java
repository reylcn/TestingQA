package com.webdriver.page;

import com.webdriver.generickHook.GeneralHook;
import org.openqa.selenium.WebDriver;
import org.testng.annotations.AfterTest;
import org.testng.annotations.BeforeTest;

public class PageBase {

    protected WebDriver driver;

    @BeforeTest
    public void launchBrowser(){
        driver = GeneralHook.startApplication(driver, "Chrome", "https://www.google.com/?hl=en");
    }

    @AfterTest
    public void tearDown(){
        GeneralHook.quitBrowser(driver);
    }

}
