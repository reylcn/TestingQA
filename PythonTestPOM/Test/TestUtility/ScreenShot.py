__author__ = 'Marko Naumovic'


from selenium import webdriver
class SS(object):

    def __init__(self, driver):
        self.driver = driver

    def ScreenShot(self, path):
        directory = "C:/Users/Marko/Desktop/Python POM/Python POM/ScreenShots"
        self.driver.get_screenshot_as_file(directory+path)