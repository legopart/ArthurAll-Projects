#include <stdlib.h>
#include <stdbool.h>
#include <string.h>
#include <stdio.h>

struct computer {
    float cost;
    int year;
    int cpu_speed;
    char cpu_type[16];

};
/* create synonym */
typedef struct computer SC;
/* function declaration */

/* function definition */
SC DataReceive(SC s)
{
    printf("please type");
    printf("The type of the CPU inside your computer?\n");
    gets(s.cpu_type);
    printf("The speed(MHz) of the CPU?\n");
    scanf("%d", &s.cpu_speed);
    printf("The year your computer was made?\n");
    scanf("%d", &s.year);
    printf("How much you paid for the computer?\n");
    scanf("%f", &s.cost);
    return s;
}


int main(void)
{
    SC model;

    model = DataReceive(model);
    printf("Here are what you entered:\n");
    printf("Year: %d\n", model.year);
    printf("Cost: $%6.2f\n", model.cost);
    printf("CPU type: %s\n", model.cpu_type);
    printf("CPU speed: %d MHz\n", model.cpu_speed);
    return 0;
}
