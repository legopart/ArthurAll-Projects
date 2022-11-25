from django.urls import path
from . import views
#import views, allowed only relative


# movies/
# movies/1/details
app_name = 'movies'

urlpatterns = [
    path('', views.index, name='index'), # movies_index    #root
    path('<int:movie_id>', views.detail, name='detail'),    # movies_detail  # movies/1
]
