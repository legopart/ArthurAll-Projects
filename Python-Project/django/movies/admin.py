from django.contrib import admin
from .models import Genre, Movie
# models we want to manage as administrative
# reload after add

# Register your models here.

class GenreAdmin(admin.ModelAdmin):     # for admin panel
    list_display = ('id', 'name')


class MovieAdmin(admin.ModelAdmin):     # for admin panel
    list_display = ('title', 'number_in_stock', 'daily_rate')
    exclude = ('date_created', )


admin.site.register(Genre, GenreAdmin)
admin.site.register(Movie, MovieAdmin)
