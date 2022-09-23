#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>
#include <string.h>

#define NUM_CHAR 256

struct node
{
	bool terminal1;
	struct node* nodeWords[NUM_CHAR];
};

struct node* createNode()
{
	struct node* newNode = malloc(sizeof * newNode);
	for (int i = 0; i < NUM_CHAR; i++) newNode->nodeWords[i] = NULL;
	newNode->terminal1 = false;
};

int main() {
	printf("Hello, World!\n");
	return 0;
}


int main() {
	printf("Hello, World!\n");
	return 0;
}


int main() {
	printf("hello");
	//upload basics here, video 1
}

