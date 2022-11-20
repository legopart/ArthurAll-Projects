
print("letters")
letters = ["a", "b", "c"]
for letter in letters:
    print(letter)

for letter2 in enumerate(letters):  # tuple (0 , 'a')
    print(letter2[0], letter2[1])

for index, letter in enumerate(letters):  # tuple (0 , 'a')
    print(index, letter)

letters.append("d")  # ["a", "b", "c", "d"]
letters.insert(0, "0")  # ["0", "a", "b", "c", "d"]

letters.pop()  # ["0", "a", "b", "c"]
letters.pop(0)  # ["a", "b", "c"]
letters.remove("b")  # ["a", "c"] #only one
del letters[0:1]        # []
letters.clear()         # []


letters = ["a", "b", "c"]
# print(letters.index("d")) #error
if "d" in letters:
    print(letters.index("d"))


# sorting
numbers: list[int] = [3, 51, 2, 8, 6]
numbers.sort()
numbers.sort(reverse=True)
newNumbers = sorted(numbers)
newNumbers = sorted(numbers, reverse=True)
print(numbers)
print(newNumbers)

# tuple sorting
items = [
    ("Product1", 10),
    ("Product2", 9),
    ("Product3", 12)
]


def sort_items(item):
    return item[1]  # return the price


items.sort(key=sort_items)
print(items)

items.sort(key=lambda item: item[1])
print(items)


prices = []
for item in items:
    prices.append(item[1])
print("prices", prices)

prices = list(map(lambda item: item[1], items))  # map iterate over items
print("prices", prices)

x = map(lambda item: item[1], items)
for item1 in x:
    print(item1)


# filter
items = [
    ("Product1", 10),
    ("Product2", 9),
    ("Product3", 12)
]

x1 = filter(lambda item: item[1] >= 10, items)
print(list(x1))


# list comprehension
# [expression for item in items]
prices = list(map(lambda item: item[1], items))
prices = [item[1] for item in items]  # better
print("list comprehensions", prices)

filter_example = list(filter(lambda item: item[1] >= 10, items))
filter_example = [item for item in items if item[1] >= 10]
print("list comprehensions filter", filter_example)
