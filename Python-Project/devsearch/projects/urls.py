from django.urls import path
from django.http import HttpResponse
from . import views

urlpatterns = [
    path("projects/", views.projects, name="projects"),
    path("project/", lambda request:HttpResponse("<h3>please enter a number</h3>"),
         name="project no number"),
    path("project/<str:pk1>/", views.project, name="project"),
    path("create-project/", views.createProject, name="create-project"),
    path("update-project/<str:pk1>", views.updateProject, name="update-project"),
    path("delete-project/<str:pk1>", views.deleteProject, name="delete-project"),
]