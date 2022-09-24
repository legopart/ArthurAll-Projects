#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>
#include <string.h>

#define SIZE_OF_SQUARE 4
#define MAX(a, b) (a > b ? a : b)
//Macros	//compilation define

int main()
{
    int cows = 10, sheep = 12;

    printf("we have %d of our most common animal\n", MAX(cows, sheep));

    for(int i = 0; i < SIZE_OF_SQUARE; i++){ }
    return 0;
}