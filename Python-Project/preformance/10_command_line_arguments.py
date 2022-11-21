import sys

print(sys.argv) #['C:\\Users\\pc1\\Desktop\\Multi-Language-All-Projects\\Python-Project\\10_command_line_arguments.py']
print(len(sys.argv))    #1 file name

if len(sys.argv) == 1:
    print("no args, please run")
    print("python 10_command_line_arguments.py <password>")
    print("python 10_command_line_arguments.py 12345aa")
else:
    password = sys.argv[1]
    print("the password is " + password)