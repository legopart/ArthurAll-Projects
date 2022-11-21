# smtp
# template
from email.mime.multipart import MIMEMultipart
from email.mime.text import MIMEText
from email.mime.image import MIMEImage
import smtplib
from pathlib import Path
from string import Template

templates = Template(Path("templates.html").read_text())
body = templates.substitute({"name": "Arthur"})
#body = templates.substitute(name = "Arthur") #key=value arguments also

message = MIMEMultipart()
message["from"] = "Arthur"
message["to"] = "w3arthur@gmail.com"
message["subject"] = "This is a test title" #title
#message.attach(MIMEText("Body, some body", "plain"))    #"...", "html"
message.attach(MIMEText(body,  "html"))
message.attach(MIMEImage(Path("image.png").read_bytes()))

with smtplib.SMTP(host="smtp.gmail.com", port=587) as smtp:   #depend onu smtp server
    smtp.ehlo() #greating message
    smtp.starttls()
    smtp.login("geo.trivia.team@gmail.com", "vlxnelojjvmkfqgw")
    smtp.send_message(message)
    print("sent!")


#always use try exept
#smtp.close()