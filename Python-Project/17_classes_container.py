
class Product:
    def __init__(self, price) -> None:
        self.price = price
       # pass

    def __del__(self):
        print("destructor ")

    @property
    def price(self):  # get_price(self):
        return self.__price

    @price.setter
    def price(self, value):  # set_price(self, value):
        if value < 0:
            raise ValueError("Price cannot be negative")
        self.__price = value

    # price = property(get_price, set_price)


product = Product(10)
print(product.price)

product.price = -5  # ValueError
# product = Product(-5)
