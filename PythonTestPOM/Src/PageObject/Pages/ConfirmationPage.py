__author__ = 'Marko Naumovic'

from selenium.webdriver.common.by import By
from Src.PageObject.Locators import Locator


class Confirmation(object):

    def __init__(self, driver):
        self.driver = driver

#defining the post registration page object here
        self.thankYou = driver.find_element(By.XPATH, Locator.thank_you)
        self.UserID = driver.find_element(By.XPATH, Locator.post_user)