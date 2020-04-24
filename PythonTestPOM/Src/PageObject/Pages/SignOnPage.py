__author__ = 'Marko Naumovic'

from selenium.webdriver.common.by import By
from Src.PageObject.Locators import Locator


class SignOn(object):

    def __init__(self, driver):
        self.driver = driver

# home page locators defining
        self.userName = driver.find_element(By.XPATH, Locator.signOn_userName)
        self.password = driver.find_element(By.XPATH, Locator.signOn_password)
        self.login = driver.find_element(By.XPATH, Locator.signOn_login)
        self.welcomeText = driver.find_element(By.XPATH, Locator.signOn_txt)
        self.registrationLink = driver.find_element(By.XPATH,Locator.signOn_registerLink)



