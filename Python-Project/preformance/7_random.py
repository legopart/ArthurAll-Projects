import random
import string

print("random():", random.random())
print("randint:", random.randint(1, 10))
print("choice([1, 5, 7, 10]):", random.choice([1, 5, 7, 10]))
print("choices([1, 5, 7, 10], k=2):", random.choices([1, 5, 7, 10], k=2))
print(" \"\".join choices(\"abcdefg\", k=4):", "".join(random.choices("abcdefg", k=4)))
print(string.ascii_letters) #abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ
print(string.ascii_lowercase)   #abcdefghijklmnopqrstuvwxyz
print(string.digits)    #0123456789
print(" \"\".join choices(string.ascii_letters + string.digits, k=8):", "".join(random.choices(string.ascii_letters + string.digits, k=8)))

numbers = [1, 2, 3, 4]
random.shuffle(numbers)
print(numbers)  #example [3, 4, 2, 1]