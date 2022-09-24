//Fix inset / print issue for same words with changing
#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>
#include <string.h>
#include <time.h>
#define NUM_CHAR 256


int main() {
    goto  start;
    start:{}    ;
    printf("Please type some string:");
    char str[80];
    gets(str);
    puts(str);


    printf(str);
    return 0;
}
