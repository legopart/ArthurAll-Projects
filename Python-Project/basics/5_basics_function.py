
# functions:


def increment(number: int, by: int = 1) -> tuple:  # default value
    return (number, number + by)
#
# must 2 breaks after a function!


print(increment(5, by=2))  # return tuple (2, 7) # cant modify a tuple
(number, sum) = increment(5, by=2)
print(number)


def multiple(*list):  # tuple  (2, 3, 4, 5)
    total = 1
    for number in list:
        total *= number
    return total


print(multiple(2, 3, 4, 5))  # 120


def save_user(**user):      # key=value, key=value, key=value
    print(user)  # return dictionary    {'id': 1, 'name': 'Arthur'}
    print(user["id"])  # 1
    print(user["name"])  # Arthur


save_user(id=1, name="Arthur")

message2 = "a"


def greet():
    #global message2
    if True:
        message2 = "b"  # no block level scope
    print(message2)


message4 = "fdgdfgfd"
message3 = "b"


def greet2():
    # global message3
    message3 = "c"  # no global variable = its local!5
    print(message3)


greet2()  # "c"
print(message3)  # "b" cause it globel
