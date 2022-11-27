from django.shortcuts import render

# Create your views here.

project_list = [
    {'id': 1, 'name': 'arthur'},
    {'id': 2, 'name': 'john'},
    {'id': 3, 'name': 'mycam'},
]


def projects(request):
    msg = 'Hello, you are on the projects page'
    number = 10
    context = {'message': msg, 'number': number, 'projects': project_list}
    return render(request, 'examples/projects.html', context)


def project(request, pk1):
    projectObj = None
    for some_project in project_list:
        if some_project['id'] == int(pk1):
            projectObj = some_project
    content = {'project': projectObj}
    return render(request, 'examples/single-project.html', content)
    #HttpResponse(f"<h2>Single project {str(pk1)}</h2>")
