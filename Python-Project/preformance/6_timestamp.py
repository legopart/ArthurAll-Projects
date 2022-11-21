#time stamp
import time
from datetime import datetime, timedelta
print(time.time())

def send_emails():
    for i in range(100000):
        pass

start = time.time()
send_emails()
end = time.time()
duration = end - start
print(duration)


dt1= datetime(2018, 1, 1)
dt = datetime.now()
dt2 = datetime.strptime("2018/01/01", "%Y/%m/%d")# also has for hours
#https://www.w3schools.com/python/python_datetime.asp
dt = datetime.fromtimestamp(time.time())
print(f"{dt.year} {dt.month}")
print(dt.strftime("%Y/%m/%d"))   #to string

print(dt1 == dt2)



dt1 = datetime(2018, 1, 1) + timedelta(days=1, seconds=1000)
dt2 = datetime.now()
duration = dt2 - dt1
print("duration: ", duration)
print("duration days: ", duration.days)
print("duration seconds (only for time): ", duration.seconds)
print("duration total_seconds() (for days too): ", duration.total_seconds())

