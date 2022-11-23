from django.db import models
from django.utils import timezone

# all the functionality from model databases
# django will create models for us in database
# this is created a migration


# Create your models here.

class Genre(models.Model):
    name = models.CharField(max_length=255)


class Movie(models.Model):
    title = models.CharField(max_length=255)
    release_year = models.IntegerField(null=True)
    number_in_stock = models.IntegerField(null=True)
    daily_rate = models.FloatField(null=True, default=0.0)
    genre = models.ForeignKey(Genre, null=True, on_delete=models.CASCADE)
    date_created = models.DateTimeField(default=timezone.now) # set only ref! datetime.datetime.now()
