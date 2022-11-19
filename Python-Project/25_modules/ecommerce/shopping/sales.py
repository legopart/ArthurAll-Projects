
# from ..customer import contact  # relevant path import
from ecommerce.customer import contact
# absolute path import

contact.contact_customer()


def calc_tax() -> None:
    contact.contact_customer()
    print("calc tax")


def calc_shipping() -> None:
    print("calc shipping")
