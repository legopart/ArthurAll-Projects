
class Text(str):
    def duplicate(self):
        return self + self  # 2 str


class TrackableList(list):
    def append(self, object):
        print("Append called")
        return super().append(object)  # extending the basic append


text = Text("Python")
print("duplicate: ", text.duplicate())
print("to lower: ", text.lower())

list1 = TrackableList()
list1.append("1")
