# unpacking operator
numbers = [1, 2, 3]
print(*numbers)  # unpack   other programs ...numbers
print(1, 2, 3)

first = [6, 7]
second = [9]
values = list(range(5))
values = [*range(5), *"Hello", *first, 8, *second]
print("list unpack", values)

# dictionary unpack
first2 = {"x": 1}
second2 = {"x": 10, "y": 2}
combined = {**first2, **second2, "z": 11}
print("dictionary unpack", combined)
