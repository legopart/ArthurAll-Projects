from django.urls import path
from django.http import HttpResponse
from . import views

urlpatterns = [
    path("examples/", views.projects, name="example_projects"),
    path("example/", lambda request:HttpResponse("<h3>(example)please enter a number</h3>"),
         name="example project no number"),
    path("example/<str:pk1>/", views.project, name="example_project"),
]
