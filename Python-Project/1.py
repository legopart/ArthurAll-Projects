class Guitar:
    __cost = 50

    def __init__(self, n_strings=6):
        self.n_strings = n_strings
        print(self.play(), self.__cost)

    @staticmethod
    def play():
        return "pam pam pam"

    def __secret():
        pass


class AAA:
    pass


class BBB(Guitar, AAA):
    def __init__(self):
        super().__init__()


my_guitar = BBB()
# print(Guitar.play())
