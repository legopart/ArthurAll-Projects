
from ecommerce.customer import contact
# absolute path import
#from ..customer import contact
# relevant path import

print("sales initialize", __name__)

if __name__ == "__main__":
    pass  # run from this file


contact.contact_customer()


def calc_tax() -> None:
    contact.contact_customer()
    print("calc tax")


def calc_shipping() -> None:
    print("calc shipping")
