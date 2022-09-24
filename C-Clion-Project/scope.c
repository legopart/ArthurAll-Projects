//Fix inset / print issue for same words with changing
#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>
#include <string.h>
#include <time.h>
#define NUM_CHAR 256




int x = 1234;         /* program scope */
static int z = 3;         /* file scope */
void function_1(){printf("function x=%i\n",x);}

int main() {
    printf("x=%i\n",x); //1234
    int x = 4444;
    static int y = 2;
    function_1(); //1234
    printf("x=%i\n",x); //4444
    {int x = 1;
        printf("internal x=%i\n",x); //1
        printf("internal y=%i\n",y); //2
        printf("internal z=%i\n",z); //3
        y+=10; // static addition
        z+=10; // static addition

    }
    printf("y=%i\n",y); //12
    printf("z=%i\n",z); //13



    return 0;
}
