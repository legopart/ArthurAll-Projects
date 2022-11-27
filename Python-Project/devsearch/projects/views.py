
from django.shortcuts import render, redirect
from .models import Project
from .forms import ProjectForm

# Create your views here.


def projects(request):
    project_list = Project.objects.all()
    context: dict = {'projects': project_list}
    return render(request, 'projects/projects.html', context)


def project(request, pk1):
    projectObj = Project.objects.get(id=pk1)
    tags = projectObj.tags.all()    # get all tags
    content: dict = {'project': projectObj, 'tags': tags}
    return render(request, 'projects/single-project.html', content)
    #HttpResponse(f"<h2>Single project {str(pk1)}</h2>")


def createProject(request):
    if request.method == 'POST':
        form = ProjectForm(request.POST, request.FILES)  # get backend files
        print(request.POST)  # request.POST['title']
        if form.is_valid():  # check required form + validity
            form.save()  # add new project to data base
            return redirect('projects')  # fix, change to project that created
    else:
        form = ProjectForm()
    context: dict = {'form': form}
    return render(request, "projects/project_form.html", context)


def updateProject(request, pk1):
    project = Project.objects.get(id=pk1)
    if request.method == 'POST':
        form = ProjectForm(request.POST, request.FILES, instance=project)
        print(request.POST)  # request.POST['title']
        if form.is_valid():  # check required form + validity
            form.save()  # add new project to data base
            return redirect('projects')  # change
    else:
        form = ProjectForm(instance=project)
    context: dict = {'form': form}
    return render(request, "projects/project_form.html", context)


def deleteProject(request, pk1):
    project = Project.objects.get(id=pk1)
    if request.method == 'POST':
        project.delete()
        return redirect('projects')
    context: dict = {'object': project}
    return render(request, 'projects/delete_object.html', context)
