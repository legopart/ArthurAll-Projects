
# sets


numbers2 = [1, 1, 2, 3, 4]
uniques = set(numbers2)
print("set ", uniques)

uniques2 = {1, 4}
uniques2.add(5)
uniques2.remove(5)
print("set size ", len(uniques2))

first_set = {1, 2, 3, 4}
second_set = {1, 5}
print("union ", first_set | second_set)  # union {1, 2, 3, 4, 5}
print("intersect ", first_set & second_set)  # intersect  {1}
print("decrees ", first_set - second_set)  # decrees  {2, 3, 4}
# symmetric difference  {2, 3, 4, 5} (not in both)
print("symmetric difference ", first_set ^ second_set)
# no indexing on set, first_set[]
if 1 in first_set:
    print("yes, 1 is in first_set")


# dictionary
# dict()

point1 = {"x": 1, "y": 2}
point = dict(x=1, y=2)  # key=value, argument

point["x"] = 5  # key
# point[0]  cant use enumarate
point["z"] = 20
print(point)

if "a" in point:
    print(point["a"])

print(point.get("a"))  # None
print(point.get("a", 0))  # 0

del point["x"]

print(point)

print("x in point: ")

for key in point:
    print(key, point[key])

for x in point.items():  # tuple
    print(x)

for key, value in point.items():  # tuple
    print(key, value)


# comparison dictionary
values1 = []  # set
for x1 in range(5):
    values1.append(x1 * 2)

values2 = {}  # dictionary
for x2 in range(5):
    values2[x] = x2 * 2


# comprehension set {expression for item in items}
values = {key: key * 2 for key in range(5)}  # no [] as set
print(values)  # {0: 0, 1: 2, 2: 4, 3: 6, 4: 8}


# generator object
generator_object = (x * 2 for x in range(5))
