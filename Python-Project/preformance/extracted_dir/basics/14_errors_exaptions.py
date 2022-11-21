# https://docs.python.org/3/library/exceptions.html
from timeit import timeit


try:
    with open("app.py") as file, open("another_file.txt") as another_file:
        print("file opened")
        # file.__enter__  file.__exit__        = with as
    age1 = int('a')
    age2 = 5 / 0
    # file.close()
except ValueError as ex:
    print("~you didn't enter valid age")
    print("message", ex)
    print(type(ex))
except (FileNotFoundError, NameError, ZeroDivisionError):
    print("file \ age cannot be 0")
else:
    print("v no exertions thrown")
finally:
    # file.close()
    print("finally")

print("Execution continue")


# with as
# with open("app.py") as file, open("another_file.txt") as another_file:
#    print("file opened")


# rising exeption
def calculate_x_factor(age):
    if age <= 0:
        raise ValueError("age cannot be 0 or less")  # Exception
    return 10 / age


try:
    calculate_x_factor(-1)
except ValueError as error:
    print(error)


code1 = """
def calculate_x_factor(age):
    if age <= 0:
        raise ValueError("age cannot be 0 or less")  # Exception
    return 10 / age


try:
    calculate_x_factor(-1)
except ValueError as error:
    print(error)
"""

code2 = """
def calculate_x_factor(age):
    if age <= 0:
        raise ValueError("age cannot be 0 or less")  # Exception
    return 10 / age


try:
    calculate_x_factor(-1)
except ValueError as error:
    pass
"""

code3 = """
def calculate_x_factor(age):
    if age <= 0:
        return None
    return 10 / age


x_factor = calculate_x_factor(-1)
if x_factor == None:
    pass
"""


# better performance
# from timeit import timeit
print("1st code timing = ", timeit(code1, number=10000))
print("2nd code timing = ", timeit(code2, number=10000))
print("3rd code timing = ", timeit(code3, number=10000))
# better without exertions
# python app.py
