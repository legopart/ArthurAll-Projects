
x = 1
print(id(x)) #stored type
x = x + 1
#previous type will deleted
print(id(x)) #stored type (another address!)

y = [1, 2, 3]
print(id(y)) #stored type

y.append(4)

print(id(y))  #stored type not change cause it immutable

# format string
strng = "afsbcbfb"
print(len(strng)) #length
print(strng[0]) #a
print(strng[-1]) #b #1 from the end
print(strng[0:3]) # start to one before 3
print(strng[:3]) #same
print(strng[0:]) # from
print(strng[:]) #same
# all of them will alocate
print(id(strng))
print(id(strng[0])) #different


strng2 = 'aa"bb'

strng3 = "cc\"dd"

full = strng2 + " " + strng3
print(full)
full2 = f"{strng2} {strng3}"
print(full2)
print(full2.strip()) #no white spaces
print(full2.upper())
print(full2.lower())
print(full2.title()) #Each First Letter Big
print(full2.find("hfg")) #find index
print(full2.replace("f", "-")) #replace all
print("hfg" in full2) #contains bool
print("hfg" not in full2) #not contains bool
