# pipenv install django
# use:
# pipenv install django==3.2

# == 2.1
# activate virtual environments
# pipenv shell
# cd django
# django-admin startproject vidly .
# on manage.py, change python interpreter variables
# python manage.py runserver 8000
# ctrl c
# start app:
# python manage.py startapp movies
#
# python manage.py runserver 8000
#
# all the functionality from model databases
# all the functionality from model databases
# django will create models for us in database
# this is created a migration

# python manage.py makemigrations
# python manage.py runserver        #You have 22 unapplied migration(s).
# python manage.py migrate      #... OK
# never delete migration files
#
# python manage.py makemigrations
# python manage.py migrate
#
# get info about queries
# python manage.py sqlmigrate movies 0001
# python manage.py runserver
#
# create a super user:
# pipenv shell
# cd django
# python manage.py createsuperuser
#
# admin
# 123
#
# code checker:
# pipenv install pylint
# pipenv install pylint-django
#
#
# https://getbootstrap.com/
#
# pipenv shell
# cd django
# python manage.py runserver
