import pytest
from selenium.webdriver.common.by import By
from selenium.webdriver.support.wait import WebDriverWait
from selenium.webdriver.support import expected_conditions as EC

from PageObject.BasePage import BasePage


class HomeScreen(BasePage):
    def __init__(self,driver):
        self.driver=driver
        self.title=WebDriverWait(self.driver.instance,10).until(
            EC.invisibility_of_element_located((By.CLASS_NAME,"site-title")))
        self.icon=WebDriverWait(self.driver.instance,10).until(
            EC.invisibility_of_element_located((By.CLASS_NAME,"custum-logo")))
        self.top_menu = WebDriverWait(self.driver.instance, 10).until(
            EC.visibility_of_element_located((
                By.ID, "top-menu")))
        self.post_list = WebDriverWait(self.driver.instance, 10).until(
            EC.presence_of_all_elements_located((
                By.TAG_NAME, "article")))
        self.twitter_button = WebDriverWait(self.driver.instance, 10).until(
            EC.visibility_of_element_located((
                By.XPATH, "//span[contains(text(), 'Twitter')]")))
        self.linkedin_button = WebDriverWait(self.driver.instance, 10).until(
            EC.visibility_of_element_located((
                By.XPATH, "//span[contains(text(), 'LinkedIn')]")))
        self.first_post = WebDriverWait(self.driver.instance, 10).until(
            EC.visibility_of_element_located((
                By.XPATH, "//article[1]//h3/a")))


    def validate_title_is_present(self):
        assert self.title.is_displayed()

    def click_on_deal(self):
        self.deal.click()

    def validate_icon_is_present(self):
        assert self.icon.is_displayed()

    def validate_menu_options_are_present(self):
        assert self.top_menu.is_displayed()

    def validate_posts_are_visible(self):
        assert len(self.post_list) > 0

    def validate_social_media_links(self):
        assert self.twitter_button.is_displayed()
        assert self.linkedin_button.is_displayed()

   # @pytest.allure.step("Click Blog's first post")
    def click_first_post(self):
            self.first_post.click()