import string
import unittest

from PageObject.AboutScreen import AboutScreen
from PageObject.HomeScreen import HomeScreen
from PageObject.PostScreen import PostScreen
from PageObject.SearchScreen import SearchScreen
from PageObject.SideBar import SideBar
from WebDrivers import Driver
from values import get


class TestQaBoy(unittest.TestCase):
    def setUp(self):
        self.driver = Driver()
        self.string.base_url = "http://qaboy.com/"
        self.driver.navigate(string.base_url)

    def test_home_screen_components(self):
        home_screen = HomeScreen(self.driver)
        home_screen.validate_title_is_present()
        home_screen.validate_icon_is_present()
        home_screen.validate_menu_options_are_present()
        home_screen.validate_posts_are_visible()
        home_screen.validate_social_media_links()

    def test_about_screen_components(self):
        home_screen = HomeScreen(self.driver)
        home_screen.click_about_me_link()

        about_screen = AboutScreen(self.driver)
        about_screen.validate_title_is_present()
        about_screen.validate_icon_is_present()
        about_screen.validate_menu_options_are_present()
        about_screen.validate_social_media_links()
        about_screen.validate_about_me_header()
        about_screen.validate_about_me_post()

    def test_post_screen_components(self):
        home_screen = HomeScreen(self.driver)
        home_screen.click_first_post()

        post_screen = PostScreen(self.driver)
        post_screen.validate_title_is_present()
        post_screen.validate_icon_is_present()
        post_screen.validate_menu_options_are_present()
        post_screen.validate_social_media_links()
        post_screen.validate_featured_image()
        post_screen.validate_published_date()
        post_screen.validate_share_buttons()
        post_screen.validate_categories_and_tags()
        post_screen.validate_comment_section()

    def test_search_for_article(self):
        sidebar = SideBar(self.driver)
        sidebar.search_for_article(string.article_title)

        search_screen = SearchScreen(self.driver)
        search_screen.click_article(string.article_title)

        post_screen = PostScreen(self.driver)
        post_screen.validate_article_title(string.article_title)

    def tearDown(self):
        self.driver.instance.quit()

    if __name__ == '__main__':
        unittest.main()
