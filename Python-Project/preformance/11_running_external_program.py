#external program
# python 11_running_external_program.py
import subprocess

# subprocess.call()
# subprocess.check_call()
# subprocess.check_output()
# subprocess.Popen

# newer
completed = subprocess.run(["dir", "/a"], shell=True, capture_output=True, text=True, check=True)  # shell windows
print(type(completed)) # subprocess.CompletedProcess
print("args: ", completed.args) # the code ['dir', '/a']
print("return code: ", completed.returncode) # 0 success
print("stderr: ", completed.stderr)  # None, no error message
print("stdout: ", completed.stdout)  # no read output, output of another program
#set text=True


completed = subprocess.run(["python", "other.py"], shell=True, capture_output=True, text=True, check=True)  # shell windows
print("args: ", completed.args)
print("return code: ", completed.returncode) # 0 success
print("stderr: ", completed.stderr)
print("stdout: ", completed.stdout)

print("False::")
try:
    completed_false = subprocess.run(["false"], shell=True, capture_output=True, text=True, check=True)  # shell windows
    print("return code: ", completed_false.returncode) # 1 fail
    if completed_false.returncode != 0:
        print(completed_false.stderr)
except subprocess.CalledProcessError as ex:
    print("exception!: ", ex)
