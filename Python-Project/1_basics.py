print("Hello World")
print("something" * 10)

x1: int = 1000
x2 = 4.99
isx : bool = False
x3 : str = "Python"
x4 : str = """
line
line
line
"""
x3 = 555
x5, x6 = 1, 2
x7 = x8 = 1
print(" ")
print(type(x3))





x = 1
print(id(x)) #stored type
x = x + 1
#previous type will deleted
print(id(x)) #stored type (another address!)

y = [1, 2, 3]
print(id(y)) #stored type

y.append(4)

print(id(y))  #stored type not change cause it immutable

strng = "afsbcbfb"
print(len(strng))
print(strng[0]) #a
print(strng[-1]) #b #1 from the end
print(strng[0:3]) # start to one before 3
print(strng[:3]) #same
print(strng[0:]) # from
print(strng[:]) #same
# all of them will alocate
print(id(strng))
print(id(strng[0])) #different


strng2 = 'afsb"cbfb'

strng3 = "afsb\"cbfb"
strng4 = "afsb\\cbfb"
strng5 = "afsb \n cbfb"
strng6 = """hfgh
fghfgh
fgh
gf
hgf
hgf"""


# format string

full = strng2 + " " + strng3
print(full)
full2 = f"{strng2} {strng3}"
print(full2)

print(full2.upper())
print(full2.lower())
print(full2.title()) #Each First Letter Big
print(full2.find("hfg")) #find index
print(full2.replace("f", "-")) #replace all
print("hfg" in full2) #contains bool
print("hfg" not in full2) #not contains bool


x = 0b10
print(bin(x)) #0b10
x = 0x10 # hexadecimal
print(hex(x))

x = 1 + 2j #complex number
print(x)

# + - * / // % **
print(10/3) #3.33333
print(10//3) #3
print(10**3) # 10^3 = 1000
x += 1
x = x + 1
# no x++ no x--


PI = 3.14
print(round(PI))
print(abs(PI))


import math #search python3 math module
print(math.floor(PI)) #3

x=1
#x = input("x: ")   #strong type!
#not works with internal compiller

#cant y = x +1 #wrong
print(int(x))
print(float(x))
print(bool(x)) #Falsy values: "" 0 [] None, else will be true

age = 22
if age >= 18: #!= >< <= >= and or not
    print("Ok") #4 spaces as standard or tab
    print("Ok2")
elif age >= 13:
    print("Teen")
else:
    print("Child")
print("end")

if x > 1: 
    pass # empty block
else:
    print("afdgsd")

name = " Arthur"
if not name.strip():
    print("name is empty")

if age >= 18 and age < 65:
    print("ok")

if 18 <= age < 65:
    print("ok")

#tonerry
print ("OK" if 18 <= age < 65 else "NO" )

#loops

for x in "Python":
    print(x)

for x in ['a', 'b', 'c']:
    print(x)

for x in range(5):      #this not a list
    print(x) # 0 1 2 3 4
for x in range(2, 5):
    print(x) # 2 3 4
for x in range(0, 10, 2):
    print(x) # 0 2 4 6 8

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

#while answer != guess:
#    guess = int(input("Guess: "))
#else:   #complete successfully without a break
#    print("you guess right")






#functions:


def increment(number: int, by: int=1) -> tuple: #default value
    return (number, number + by)
#
# must 2 breaks after a function!

print( increment(5, by=2) ) #return tuple (2, 7) # cant modify a tuple

def multiple(*list) :
    total = 1
    for number in list: 
        total *= number
    return total


print( multiple(2, 3, 4, 5) ) #120



def save_user(**user):
    print(user) #return dictionary
    print(user["id"])
    print(user["name"])


save_user(id=1, name="Arthur")

def greet():
    if True:
        message2 = "a"   #no block level scope
    print(message2)



message4 = "fdgdfgfd" 
message3 = "b" 


def greet2():
    #global message3 
    message3 = "c"   #no global variable = its local!5
    print(message3)

greet2() #"c"
print(message3) #"b" cause it globel




def fizz_buzz(input):
    if input % 3 == 0 and input % 5 == 0:
        return "FizzBuzz"
    if input % 3 == 0:
        return "Fizz"
    if input % 5 == 0:
        return "Buzz"
    return input


print(fizz_buzz(3))