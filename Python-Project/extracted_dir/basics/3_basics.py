
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
X5 += 1
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

Age = 22
if (Age >= 18):  # != >< <= >= and or not
    print("Ok")  # 4 spaces as standard or tab
    print("Ok2")
elif Age >= 13:
    print("Teen")
else:
    print("Child")
print("end")

if X > 1:
    pass  # empty block
else:
    print("afdgsd")

Name = " Arthur"
if not Name.strip():
    print("name is empty")

if Age >= 18 and Age < 65:
    print("ok")

if 18 <= Age < 65:
    print("ok")

# LOGICAL:  and      or      not







# tonerry

Message = "OK" if 18 <= Age < 65 else "NO"
print(Message)



