
from django.shortcuts import render
from .models import Project

# Create your views here.

project_list = [
    {'id': 1, 'name': 'arthur'},
    {'id': 2, 'name': 'john'},
    {'id': 3, 'name': 'mycam'},
]


def projects(request):
    project_list = Project.objects.all()
    context = {'projects': project_list}
    return render(request, 'projects/projects.html', context)


def project(request, pk1):
    #project_list = Project.objects.all()
    projectObj = Project.objects.get(id=pk1)
    tags = projectObj.tags.all()    # get all tags
    content = {'project': projectObj, 'tags': tags}
    return render(request, 'projects/single-project.html', content)
    #HttpResponse(f"<h2>Single project {str(pk1)}</h2>")
