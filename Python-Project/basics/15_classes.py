# classes
# all in python is classes

# Class blueprint for creating new object
# Object: instance of a class
# Class: Human
# Objects : John, Mary, Jack,

# https://rszalski.github.io/magicmethods/

class Point:
    default_color = "red"

    def __init__(self, x, y) -> None:  # constructor
        self.x = x
        self.y = y
        pass

    def __str__(self) -> str:
        return f"string {self.x} {self.y}"

    def __eq__(self, other):
        return self.x == other.x and self.y == other.y

    def __gt__(self, other):
        return self.x > other.x and self.y > other.y

    def __add__(self, other):
        return Point(self.x + other.x, self.y + other.y)

    @classmethod  # decorator
    def zero(cls):
        return cls(0, 0)
        #cls.x = 0
        #cls.y = 0
        # return cls

    def draw(self):
        print(f"draw Point ({self.x}, {self.y})")


point = Point(1, 2)
point.draw()

another = Point(3, 4)
another.draw()
point.default_color = "yellow"
print(point.default_color)  # yellow
print(Point.default_color)  # red
print(another.default_color)   # red

Point.default_color = "green"
print(point.default_color)  # yellow
print(Point.default_color)  # green
print(another.default_color)   # green

print(point.x)

p1 = Point.zero()
p2 = Point(0, 0)


print(type(point))

print(isinstance(point, Point))  # True
print(isinstance(point, int))  # False

# להמשיך שיעור 5


print(point)  # string 1 2
print(str(point))

point = Point(10, 20)
other = Point(1, 2)
print("equality", point == other)  # False
print("equality qt", point > other)   # True
print("equality qt", point < other)  # False
print("add method", point + other)  # string 11 22
