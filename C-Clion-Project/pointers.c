//Fix inset / print issue for same words with changing
#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>
#include <string.h>
#include <time.h>
#define NUM_CHAR 256




int swap_ints(int *first_number, int *second_number){
    int temp;
    /* temp = "what is pointed to by" first_number; etc... */
    temp = *first_number;
    *first_number = *second_number;
    *second_number = temp;return 0;}

int main() {

        int a = 4, b = 7;
        printf("pre-swap values are: a == %d, b == %d\n", a, b);
        swap_ints(&a, &b);
        printf("post-swap values are: a == %d, b == %d\n", a, b);

        return 0;
}
