# list, tuple, dictionary

letters: list[str] = ["a", "b", "c"]
matrix: list[list[int]] = [[0, 1], [2, 3]]
zeros: list = [0] * 10  # [0, 0, 0, 0, 0, 0, 0, 0, 0, 0]
print(type(matrix))
print(letters[0])
print(matrix[0][1])

numbers = list(range(20))
chars = list("Hello World")
print(chars)  # ['H', 'e', 'l', 'l', 'o', ' ', 'W', 'o', 'r', 'l', 'd']
print(len(chars))  # 11

print(chars[-1])  # d

chars[0] = 'h'

print(chars[:5])

chars[0] = 'H'

print(chars[:])

numbers2 = list(range(21))
numbers2.remove(0)

print(numbers2)
print(numbers2[::-1])  # reverse
print(numbers2[::-2])  # reverse each 2


unpack = [1, 2, 3, 4, 5]
first, second, third, *others = unpack
# first = 1 second = 2 third = 3 others = [4, 5]
print(first)  # 1
print(others)  # [4, 5]


first2, *others2, last = unpack
print(last)  # 5
