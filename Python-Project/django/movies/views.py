from django.http import HttpResponse, Http404
from django.shortcuts import render, get_object_or_404
from .models import Movie

# Create your views here.


def index(request):
    movies = Movie.objects.all()     # SELECT * FROM movies_movie

    # Movie.objects.filter(release_year=1984)     # SELECT * FROM movies_movie WHERE release_year=1984       # filter
    # Movie.objects.get(id=1)
    #
    return render(request, 'movies/index.html', {'movies': movies})
    #
    # output = ', '.join([m.title for m in movies])
    # return HttpResponse("Hello Movies: " + output)


def detail(request, movie_id):
    try:
        movie = get_object_or_404(Movie, pk=movie_id)  # id or pk
        return render(request, 'movies/detail.html', {'movie': movie})
    except Movie.DoesNotExist:
        raise Http404()
        # return HttpResponse(movie_id)
