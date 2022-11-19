
class Animal(object):
    def __init__(self) -> None:
        self.age = 1

    def eat(self):
        print("eat")


class Mammal(Animal):
    def __init__(self) -> None:
        super().__init__()  # inhibited class
        self.weight = 1

    def walk(self):
        print("walk")


class Fish(Animal):
    def swim(self):
        print("swim")


m = Mammal()
m.eat()

print(isinstance(m, Mammal))  # True
print(isinstance(m, Animal))  # True
print(isinstance(m, object))  # True
print(isinstance(Mammal, Fish))  # False
print("age", m.age)
print("weight", m.weight)
