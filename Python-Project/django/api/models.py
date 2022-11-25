from django.db import models
from tastypie.resources import ModelResource
from movies.models import Movie   # v


# Create your models here.
class MovieResource(ModelResource):
    class Meta:     # tastypie looks for
        queryset = Movie.objects.all()       # query
        resource_name = 'movies'    # api/movies
        excludes = ['date_created']


