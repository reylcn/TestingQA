from selenium import webdriver
import string


class Driver:

    def __init__(self):
        self.instance = webdriver.Chrome("C:/Users/Marko/PycharmProjects/QABoy/Helpers/chromedriver.exe")

    def navigate(self, url):
        if isinstance(url, str):
            self.instance.get(url)


        else:
            raise TypeError("URL must be a string.")
