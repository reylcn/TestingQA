from telnetlib import EC

import pytest
from selenium.webdriver.common.by import By
from selenium.webdriver.support.wait import WebDriverWait

from PageObject.BasePage import BasePage

class AboutScreen(BasePage):
    def __init__(self,driver):
        self.driver=driver

    def __init__(self, driver):
        self.driver = driver
        self.about_me_header = WebDriverWait(self.driver.instance, 10).until(
            EC.visibility_of_element_located((
                By.XPATH, "//h1[contains(text(), 'About Me')]")))
        self.about_me_post = WebDriverWait(self.driver.instance, 10).until(
            EC.visibility_of_element_located((
                By.CLASS_NAME, "entry-content")))
    #@pytest.allure.setp("Validation About Me Header")
    def validate_about_me_header(self):
        assert self.about_me_header.is_displayed()

    #@pytest.allure.setp("Validation About Me Drscription")
    def validate_about_me_post(self):
        assert self.about_me_post.is_displayed()