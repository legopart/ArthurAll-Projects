
from django.shortcuts import render
from django.http import HttpResponse


# Create your views here.


def projects(request):
    msg = 'Hello, you are on the projects page'
    number = 11
    context = {'message': msg, 'number': number}
    return render(request, 'projects/projects.html', context)


def project(request, pk1):
    return render(request, 'projects/single-project.html')
    #HttpResponse(f"<h2>Single project {str(pk1)}</h2>")
