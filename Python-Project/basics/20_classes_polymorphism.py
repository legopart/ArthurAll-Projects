# polymorphism

from abc import ABC, abstractmethod


class UIControl(ABC):
    @abstractmethod
    def draw(self):
        pass


class TextBox(UIControl):
    def draw(self):
        print("Text Box")


class DropDownList(UIControl):
    def draw(self):
        print("Drop Down List")


def draw(controls: list[UIControl]):  # polymorphism
    print("type", type(controls))
    for control in controls:
        control.draw()


ddl = DropDownList()
textbox = TextBox()
draw([ddl, textbox])  # Drop Down List


print(isinstance(ddl, UIControl))  # True
