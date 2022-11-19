# classes
# all in python is classes

# Class blueprint for creating new object
# Object: instance of a class
#Class: Human
# Objects : John, Mary, Jack,


class Point:
    default_color = "red"

    def __init__(self, x, y) -> None:  # constructor
        self.x = x
        self.y = y
        pass

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


print(type(point))

print(isinstance(point, Point))  # True
print(isinstance(point, int))  # False

# להמשיך שיעור 5
