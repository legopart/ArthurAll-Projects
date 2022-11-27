from django.forms import ModelForm
from .models import Project


class ProjectForm(ModelForm):
    class Meta:
        model = Project
        # '__all__'  # all changeable fields # ['title', ...]
        fields = ['title', 'featured_image', 'description',
                  'demo_link', 'source_link', 'tags']
