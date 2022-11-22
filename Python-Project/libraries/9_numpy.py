import numpy as np
# numpy
# pipenv install numpy
# multi dimension arrays

array = np.array([1, 2, 3])
print(f"{array=}")    # numpy array

array = np.array([[1, 2, 3], [4, 5, 6]])
print(f"{array=}")
print(f"{array.shape=}")  # (2, 3) tuple

array = np.zeros((3, 4), dtype=int)
print(f"{array=}")    # [[0 0 0 0]    [0 0 0 0]   [0 0 0 0]]

array = np.full((3, 4), 5, dtype=int)
print(f"{array=}")    # [[5 5 5 5]    [5 5 5 5]  [5 5 5 5]]

array = np.random.random((3, 4))
print(f"{array=}")
print(f"{array[0][0]=}")
print(f"{array[0, 0]=}")
print(f"{array > 0.2=}")            # bool result   [[ True,  True,  True,  True]   [ True, False,  True,  True]    [ True,  True,  True,  True]]
print(f"{array[array > 0.2]=}")     # single dimension array
print(f"{np.sum(array)=}")
print(f"{np.floor(array)=}")
print(f"{np.ceil(array)=}")
print(f"{np.round(array)=}")

first = np.array([1, 2, 3])
second = np.array([1, 2, 3])
print(f"{first + second=}")
print(f"{first + 2=}")

dimensions_inch = np.array([1, 2, 3])
dimensions_cm = dimensions_inch * 2.54
print(f"{dimensions_cm=}")

# regularly
dimensions_inch = [1, 2, 3]
dimensions_cm = [x * 2.54 for x in dimensions_inch]
print(f"{dimensions_cm=}")
