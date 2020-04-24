package com.webdriver.page;

import org.openqa.selenium.Keys;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.support.FindBy;
import org.openqa.selenium.support.ui.ExpectedConditions;
import org.openqa.selenium.support.ui.WebDriverWait;

public class GooglePage {

    WebDriver driver;

    public GooglePage(WebDriver ldriver){
        this.driver = ldriver;
    }

    @FindBy(xpath = "//input[contains(@name,'q')]")
    private WebElement searchInput;

    @FindBy(xpath = "//div[contains(@id,'resultStats')]")
    private WebElement resultText;

    public void enterText(String text){
        WebDriverWait wait = new WebDriverWait(driver,30);
        wait.until(ExpectedConditions.elementToBeClickable(searchInput));
        searchInput.sendKeys(text);
    }

    public void clickOnEnter(){
        searchInput.sendKeys(Keys.ENTER);
    }

    public String getResults(){
        WebDriverWait wait = new WebDriverWait(driver,10);
        wait.until(ExpectedConditions.elementToBeClickable(resultText));
        return resultText.getText();
    }
}


