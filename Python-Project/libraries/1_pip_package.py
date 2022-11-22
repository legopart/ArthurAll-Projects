import requests
        #https://www.jetbrains.com/help/pycharm/pipenv.html#pipenv-existing-project
# https://pypi.org/
# pip3 install requests
# pip list
# pip3 install requests==2.9.0
# pip3 install requests==2.9.* # pip3 install requests~=2.9.0
# pip3 uninstall requests
# pip3 install requests==2.*

#more info https://pypi.org/project/requests/

response = requests.get("http://google.com")
print(response) #<Response [200]>, success

# environment for specific project, isolated environment
# python -m venv env
# run activate.bat from bin or Scripts
# env/Scripts/activate.bat  # linux or cmd
# pip3 install requests==2.*
# deactivate ?in windows?


# pip env tool
# pip install pipenv
# pipenv install requests
# virtual path:
#   pipenv --venv
#   , not part of the project
#           pip uninstall requests
# activate:
#   pipenv shell
#   exit            deactivate

#env directory
#   pipenv --venv

# rewatch ep5 for pipenv, python settings for visual studio code, wit pyplint



# pipenv install
# pipenv install -ignore-pipfile