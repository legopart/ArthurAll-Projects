import requests
from bs4 import BeautifulSoup

# web scraping
# web crawler, web spider

# pipenv install beautifulsoup4


response = requests.get("https://stackoverflow.com/questions")
soup = BeautifulSoup(response.text, "html.parser")

questions = soup.select(".s-post-summary")  # css
print(questions[0].get("id", 0))
print(type(questions[0]))
print(questions[0].select_one(".s-link"))   # better then list
print(questions[0].select_one(".s-link").getText())   # question title

for question in questions:
    print(
        "- " + question.select_one(".s-link").getText()
        + " (votes: " + question.select_one(".s-post-summary--stats-item-number").getText() + ")"
    )

# also can learn the pagination and read any page
