from twilio.rest import Client
from config import Twilio
import config
# https://www.twilio.com/
# https://console.twilio.com/?frameUrl=%2Fconsole%3Fx-target-region%3Dus1
# pipenv install twilio
account_sid: str = Twilio.account_sid
auth_token: str = Twilio.auth_token
phone: str = Twilio.auth_token
client = Client(account_sid, auth_token)

client.messages.create(
    to = "+972528899664"
    , from_ = phone
    , body = "Hi, Arthur, this is a text message"
)