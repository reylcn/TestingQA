from telnetlib import EC
from selenium.webdriver.common.by import By
from selenium.webdriver.support.wait import WebDriverWait

class BasePage():
    def validate_title_is_present(self):
        title=WebDriverWait(self.driver.instance,10).until(
            EC.visibility_of_element_located((
                By.CLASS_NAME,"site-title")))
        assert title.is_dipalyed()
    def validation_is_present(self):
        icon=WebDriverWait(self.driver.instance,10).until(
            EC.visibility_of_element_located((
                By.ID,"top-menu")))

    def validate_social_media_links(self):
        twitter_button = WebDriverWait(self.driver.instance, 10).until(
            EC.visibility_of_element_located((
                By.XPATH, "//span[contains(text(), 'Twitter')]")))
        linkedin_button = WebDriverWait(self.driver.instance, 10).until(
            EC.visibility_of_element_located((
                By.XPATH, "//span[contains(text(), 'LinkedIn')]")))
        assert twitter_button.is_displayed()
        assert linkedin_button.is_displayed()

    def click_about_me_link(self):
        about_me_link = WebDriverWait(self.driver.instance, 10).until(
            EC.visibility_of_element_located((
                By.LINK_TEXT, "About Me")))
        about_me_link.click()