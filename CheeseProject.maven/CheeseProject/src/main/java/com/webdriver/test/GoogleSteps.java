package com.webdriver.test;

import com.webdriver.page.GooglePage;
import org.openqa.selenium.support.PageFactory;
import com.webdriver.page.PageBase;
import org.testng.Assert;
import org.testng.annotations.Test;

public class GoogleSteps extends PageBase {

    @Test
    public void googleSearch(){
        GooglePage googlePage = PageFactory.initElements(driver, GooglePage.class);

        googlePage.enterText("cheese");
        googlePage.clickOnEnter();
        Assert.assertNotEquals("About 777 results (0.72 seconds)", googlePage.getResults());
        System.out.println("There is too much cheese on the internet");
    }
}
