import time

from selenium import webdriver
from selenium.webdriver.common.by import By
from selenium.webdriver.support.wait import WebDriverWait
from selenium.webdriver.support import expected_conditions as EC

# automated testing
# pipenv install selenium
# drivers -> chrome:
# https://pypi.org/project/selenium/
    # download right version of chrome
    #   https://chromedriver.chromium.org/downloads
    #   run chromedriver.ex

options = webdriver. ChromeOptions()
options.add_experimental_option("detach", True)
executable_path = r"chromedriver.exe"
username = "legopart"
password = "odlo01oo"
username_approve = "legopart"

browser = webdriver.Chrome(options=options)
browser.get("http://www.github.com")
browser.implicitly_wait(1)
try:
    signin_link = browser.find_element(By.LINK_TEXT, "Sign in")
    signin_link.click()
    browser.implicitly_wait(1)
    username_input = browser.find_element(By.ID, "login_field")
    username_input.send_keys(username)
    password_input = browser.find_element(By.ID, "password")
    password_input.send_keys(password)
    password_input.submit()
    browser.implicitly_wait(1)
    browser.find_element(By.CSS_SELECTOR, ".avatar-small").click()
    browser.implicitly_wait(1)
    profile_link = browser.find_element(By.CSS_SELECTOR, ".user-profile-link")
    link_label = profile_link.get_attribute("innerHTML")
    assert username_approve in link_label
    print("ok")
except Exception as ex:
    print("fail " + ex)
finally:
    browser.quit()
# browser.close()
# with webdriver.Chrome() as driver:
#    driver.get("http://www.python.org")


# https://selenium-python.readthedocs.io/
# check Wait, Page Objects