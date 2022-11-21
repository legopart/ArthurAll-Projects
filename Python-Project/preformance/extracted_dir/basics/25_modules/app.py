import ecommerce.shopping.sales
from ecommerce.shopping.sales import calc_tax
from ecommerce.shopping import sales

ecommerce.shopping.sales.calc_shipping()
calc_tax()
sales.calc_shipping()


print("dir(sales)", dir(sales))
print("sales.__name__", sales.__name__)
print("sales.__package__", sales.__package__)
print("sales.__file__", sales.__file__)
