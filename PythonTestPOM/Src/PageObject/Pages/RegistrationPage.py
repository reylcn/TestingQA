__author__ = 'Marko Naumovic'

from selenium.webdriver.common.by import By
from selenium.webdriver.support.select import Select
from Src.PageObject.Locators import Locator


class Register(object):

    def __init__(self, driver):
        self.driver = driver

        # registration page locators defining , you can directly call the WebElement from here
        self.regis_txt = driver.find_element(By.XPATH, Locator.regis_txt)
        self.firstName = driver.find_element(By.XPATH, Locator.firstName)
        self.lastName = driver.find_element(By.XPATH, Locator.lastName)
        self.phone = driver.find_element(By.XPATH, Locator.phone)
        self.email = driver.find_element(By.XPATH, Locator.email)
        self.address = driver.find_element(By.XPATH, Locator.address)
        self.city = driver.find_element(By.XPATH, Locator.city)
        self.postalCode = driver.find_element(By.XPATH, Locator.postalCode)
        self.country = driver.find_element(By.XPATH, Locator.country)
        self.userName = driver.find_element(By.XPATH, Locator.userName)
        self.password = driver.find_element(By.XPATH, Locator.password)
        self.confirmPassword = driver.find_element(By.XPATH, Locator.confirmPassword)
        self.submit = driver.find_element(By.XPATH, Locator.submit)

    # you can return WebElement from method and call it also, and useful method with parameter you define here
    def getRegis_txt(self):
        return self.regis_txt

    def setFirstName(self, Name):
        self.firstName.clear()
        self.firstName.send_keys(Name)

    def setLastName(self, Name):
        self.lastName.clear()
        self.lastName.send_keys(Name)

    def setPhone(self, phone):
        self.phone.clear()
        self.phone.send_keys(phone)

    def setEmail(self, email):
        self.email.clear()
        self.email.send_keys(email)

    def setAddress(self, address):
        self.address.clear()
        self.address.send_keys(address)

    def setCity(self, city):
        self.city.clear()
        self.city.send_keys(city)

    def setPostaCode(self, postalCode):
        self.postalCode.clear()
        self.postalCode.send_keys(postalCode)

    def setCountry(self, country):
        select = Select(self.country)
        select.select_by_visible_text(country)

    def setUserName(self, userName):
        self.userName.clear()
        self.userName.send_keys(userName)

    def setPassword(self, password):
        self.password.clear()
        self.password.send_keys(password)

    def setConfirmPassword(self, confirmPassword):
        self.confirmPassword.clear()
        self.confirmPassword.send_keys(confirmPassword)

    def submitRegistration(self):
        self.submit.click()
