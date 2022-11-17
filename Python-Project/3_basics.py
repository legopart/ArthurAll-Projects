
import math  # search python3 math module
X1 = 0b10
print(bin(X1))  # 0b10
X2 = 0x10  # hexadecimal
print(hex(X2))  # HEX

X3 = 1 + 2j  # complex number
print(X3)

# + - * / // % **
print(10/3)  # 3.33333
print(10//3)  # 3
print(10**3)  # 10^3 = 1000

X5: int = 0
X5 +=+ 1
X5 = X5 + 1
# no x++ no x--


PI = 3.14
print(round(PI))
print(abs(PI)) #| |


print(math.floor(PI))  # 3

X = 1
# x = input("x: ")   #strong type!
# not works with internal compiller

# cant y = x +1 #wrong
print(int(X))
print(float(X))
print(bool(X))  # Falsy values: "" 0 [] None, else will be true

age = 22
if age >= 18:  # != >< <= >= and or not
    print("Ok")  # 4 spaces as standard or tab
    print("Ok2")
elif age >= 13:
    print("Teen")
else:
    print("Child")
print("end")

if x > 1:
    pass  # empty block
else:
    print("afdgsd")

name = " Arthur"
if not name.strip():
    print("name is empty")

if age >= 18 and age < 65:
    print("ok")

if 18 <= age < 65:
    print("ok")

# tonerry
print("OK" if 18 <= age < 65 else "NO")

# loops

for x in "Python":
    print(x)

for x in ['a', 'b', 'c']:
    print(x)

for x in range(5):  # this not a list
    print(x)  # 0 1 2 3 4
for x in range(2, 5):
    print(x)  # 2 3 4
for x in range(0, 10, 2):
    print(x)  # 0 2 4 6 8

type(range(0, 5))

names = ["John", "Mary"]
for name in names:
    if name.startswith("J"):
        print("found")
        break
else:
    print("not found")

guess = 0
answer = 5

# while answer != guess:
#    guess = int(input("Guess: "))
# else:   #complete successfully without a break
#    print("you guess right")


# functions:


def increment(number: int, by: int = 1) -> tuple:  # default value
    return (number, number + by)
#
# must 2 breaks after a function!


print(increment(5, by=2))  # return tuple (2, 7) # cant modify a tuple


def multiple(*list):
    total = 1
    for number in list:
        total *= number
    return total


print(multiple(2, 3, 4, 5))  # 120


def save_user(**user):
    print(user)  # return dictionary
    print(user["id"])
    print(user["name"])


save_user(id=1, name="Arthur")


def greet():
    if True:
        message2 = "a"  # no block level scope
    print(message2)


message4 = "fdgdfgfd"
message3 = "b"


def greet2():
    #global message3
    message3 = "c"  # no global variable = its local!5
    print(message3)


greet2()  # "c"
print(message3)  # "b" cause it globel


def fizz_buzz(input):
    if input % 3 == 0 and input % 5 == 0:
        return "FizzBuzz"
    if input % 3 == 0:
        return "Fizz"
    if input % 5 == 0:
        return "Buzz"
    return input


print(fizz_buzz(3))
