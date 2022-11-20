import shutil
from time import ctime
from pathlib import Path
# Path class


# absolute path
Path(r"C:\1")  # Path("/usr/local/bin")
Path()  # current folder
Path("ectomere/__init__.py")  # relative
path2 = Path() / Path("ectomere")  # combine
path = Path() / "ectomere" / "__init__.py"  # combine

path.exists()
path.is_file()
path.is_dir()
print(path.name)  # print only __init__.py
print(path.stem)  # print only __init__
print(path.suffix)  # print only py
print(path.parent)  # print only ectomere
new_path = path.with_name("file.txt")
new_path = new_path.with_suffix(".png")
print(new_path.absolute())
# C:\Users\pc1\Desktop\Multi-Language-All-Projects\Python-Project\ectomere\file.txt


# actions, with directories
path = Path("basics")
# path.exists()
# path.mkdir()
# path.rmdir()
# path.rename("ecommerce2")
print(path.iterdir())  # generator object

if (path.exists()):
    for p in path.iterdir():  # files and directories
        if (not p.is_dir()):
            print(p)

# list comprehension expression
paths = [p for p in path.iterdir() if p.is_dir()]
print(paths)  # WindowsPath, PasixPath on mac or linux

py_files = [p for p in path.glob("*.py")]  # find only .py files
# find only .py files with childres also path.glob("**/*.py")
py_files_recursively = [p for p in path.rglob("*.py")]


#from time import ctime
path = Path("ecommerce/__init__.py")
print(ctime(path.stat().st_ctime))  # creation time
path.read_bytes()  # content as bytes
path.read_text()  # content content
# better then
with open("ecommerce/__init__.py", "r") as file:
    pass

path.write_text("hello world")
# path.write_bytes()


source = Path("ecommerce/__init__.py")
target = Path() / "__init__.py"
# target.write_text(source.read_text())

#import shutil
shutil.copy(source, target)
