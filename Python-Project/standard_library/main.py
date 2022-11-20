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
newpath = path.with_name("file.txt")
print(newpath)  # ectomere/file.txt
