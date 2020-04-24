package com.webdriver.generickHook;

import org.openqa.selenium.WebDriver;
import org.openqa.selenium.chrome.ChromeDriver;
import java.util.concurrent.TimeUnit;

public class GeneralHook {

    public static WebDriver startApplication(WebDriver driver, String browserName, String appUrl){
        if(browserName.equals("Chrome")){
            System.setProperty("webdriver.chrome.driver", "src/test/java/driver/chromedriver");
            driver = new ChromeDriver();
        }
        else{
            System.out.println("We don't support this browser");
        }
        driver.manage().timeouts().pageLoadTimeout(30, TimeUnit.SECONDS);
        driver.manage().window().maximize();
        driver.get(appUrl);
        return driver;
    }

    public static void quitBrowser(WebDriver driver){
        driver.quit();
    }
}

