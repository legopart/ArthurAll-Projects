from django.db import models
import uuid


# Create your models here.
class Project(models.Model):
    id = models.UUIDField(default=uuid.uuid4, primary_key=True,
                          unique=True, editable=False)  # id = created by default
    created = models.DateTimeField(auto_now_add=True)
    title = models.CharField(max_length=200)
    description = models.TextField(
        null=True, blank=True)  # can be empty or null
    featured_image = models.ImageField(
        null=True, blank=True, default="default.png")  # please rename the image name
    demo_link = models.CharField(max_length=200, null=True, blank=True)
    source_link = models.CharField(max_length=200, null=True, blank=True)
    tags = models.ManyToManyField('Tag', blank=True)  # 'Tag' ref
    vote_total = models.IntegerField(default=0, null=True, blank=True)
    vote_ratio = models.IntegerField(default=0, null=True, blank=True)
    # admin line model

    def __str__(self) -> str:
        return "Project: " + self.title


class Review(models.Model):
    VOTE_TYPE = (
        ('up', 'Up Vote'),
        ('down', 'Down Vote'),
    )
    id = models.UUIDField(default=uuid.uuid4, primary_key=True,
                          unique=True, editable=False)  # id = created by default
    created = models.DateTimeField(auto_now_add=True)
    project = models.ForeignKey(Project, on_delete=models.CASCADE)  # SET_NULL
    value = models.CharField(max_length=200, choices=VOTE_TYPE)
    body = models.TextField(null=True, blank=True)
    # owner =

    def __str__(self) -> str:
        return self.value + " rate -> " + str(self.project)


class Tag(models.Model):
    id = models.UUIDField(default=uuid.uuid4, primary_key=True,
                          unique=True, editable=False)  # id = created by default
    created = models.DateTimeField(auto_now_add=True)
    name = models.CharField(max_length=200)

    def __str__(self) -> str:
        return self.name
