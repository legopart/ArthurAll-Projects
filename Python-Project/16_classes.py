
class TagCloud:  # container type
    def __init__(self) -> None:
        self.__tags: dict = {}

    def add(self, tag: str):
        self.__tags[tag.lower()] = self.__tags.get(tag.lower(), 0) + 1

    def __getitem__(self, key):
        return self.__tags.get(key.lower(), 0)

    def __setitem__(self, key, value):
        self.__tags[key.lower()] = value

    def __len__(self):
        return len(self.__tags)

    def __iter__(self):
        return iter(self.__tags)


cloud = TagCloud()  # object

cloud.add("Python")
cloud.add("python")
cloud.add("python")
cloud.add("java")
cloud["python"] = 10

# print(cloud.__tags) #__tags is a private
print("python", cloud["python"])

# print("python", cloud.tags["PYTHON"]) #fail

# len(cloud)  # number of items ,size
# cloud["python"] = 10  # get item by its key, set
for tag in cloud:  # iterator
    print(tag)


print("class dictionary", cloud.__dict__)
print("class dictionary", cloud._TagCloud__tags)  # access to private members
