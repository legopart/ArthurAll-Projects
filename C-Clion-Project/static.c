//Fix inset / print issue for same words with changing
#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>
#include <string.h>
#include <time.h>
#define NUM_CHAR 256



void foo()
{
    int someInt = 0;
    static int staticInt = 0;

    someInt += 5;
    staticInt += 5;

    printf("someInt = %d, staticInt = %d\n", someInt, staticInt);
}


int main() {
    int i;

    for (i = 0; i < 10; ++i)
        foo();

    return 0;
}
