from pathlib import Path
from zipfile import  ZipFile

with ZipFile("files.zip", "w") as zip: #write
    for path in Path("basics").rglob("*.*"):
        zip.write(path)
#zip.close()

with ZipFile("files.zip") as zip:
    print(zip.namelist())   #list all the files
    info = zip.getinfo("basics/10_data_structures.py")
    print(info.file_size)
    print(info.compress_size)
    zip.extractall("extracted_dir")