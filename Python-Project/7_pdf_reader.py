import PyPDF2
#pdf
# pipenv install pypdf2
with open("first.pdf", "rb") as file: # read binary
    reader = PyPDF2.PdfFileReader(file)
    print(f"{reader.numPages=}")
    page = reader.getPage(0)
    #page.rotate()
    #page.scale()
    page.rotateClockwise(90)
    writer = PyPDF2.PdfFileWriter()
    writer.addPage(page)    #insertPage #insertBlankPage
    with open("1stRotated.pdf", "wb") as output:  # write binary
        writer.write(output)

merger = PyPDF2.PdfMerger()
file_names = ["first.pdf", "second.pdf"]
for file_name in file_names:
    merger.append(file_name)
merger.write("1st2ndCombined.pdf")