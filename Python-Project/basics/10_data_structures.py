
from array import array
from collections import deque

print("combining lists")

list1 = [1, 2, 3]
list2 = [10, 20, 30]

zip_obj = zip("ABC", list1, list2)
zipList = list(zip_obj)
print(zipList)


# stack LIFO
browsing_session = []
browsing_session.append(1)
browsing_session.append(2)
browsing_session.append(3)
last = browsing_session.pop()
print(last)
print(browsing_session)
if not browsing_session:
    print("last session", browsing_session[-1])
# falsy values 0 "" [] false


# queue FIFO
#from collections import deque
queue = deque([])  # ok
queue.append(1)
queue.append(2)
queue.append(3)
queue.popleft()
print("queue", queue)
if not queue:
    print("queue empty")


# tuple

point1 = 1, 2,
point = (1, 2) + (3, 4) * 2
print(type(point))
print("tuple", point)

point2 = tuple([1, 2])
point3 = 1, 2,

print(point3)
x, y = point3
if 10 in point3:
    print("10 exist")

# cant point3[0] = 20, tuple is fixed


# swapping
X = 10
Y = 11
X, Y = Y, X
print(X)


# array for big data amount
#from array import array
# type /code   https://docs.python.org/3/library/array.html

numbers = array("i", [1, 2, 3])  # integer
numbers.append(4)
numbers.insert(0, -1)
numbers.remove(4)
numbers.pop()
numbers[0] = -2
# numbers[0] = 1.2 #cant
