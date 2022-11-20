

# loops

for x in "Python":
    print(x)

for x in ['a', 'b', 'c']:
    print(x)

for y in range(5):  # this not a list   type() <class 'range'>
    print(y)  # 0 1 2 3 4
for y in range(2, 5):
    print(y)  # 2 3 4
for y in range(0, 10, 2):  # ,,Step of 2
    print(y)  # 0 2 4 6 8
print("\nrange type")
print(type(range(0, 5)))


Names = ["John", "Mary"]
for name in Names:
    if name.startswith("J"):
        print("found")
        break
else:
    print("not found")


Guess = 0
Answer = 5

while Answer != Guess:
    Guess = 5  # int(input("Guess: "))
else:
    print("you guess right")    # complete successfully without a break

