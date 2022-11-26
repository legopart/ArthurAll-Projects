from django.urls import path
from django.http import HttpResponse
from . import views

urlpatterns = [
    path("projects/", views.projects, name="projects"),
    path("project/", lambda request:HttpResponse("<h3>please enter a number</h3>"),
         name="project no number"),
    path("project/<str:pk1>/", views.project, name="project"),
]
