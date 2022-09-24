//Fix inset / print issue for same words with changing
#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>
#include <string.h>

#define NUM_CHAR 256



struct Person{
    int age;
    char *name;
    int height_in_cm;};

int main() {
    printf("C Main: \n\n\n");

    struct Person hero = { 20, "Robin Hood", 191 };
    struct Person john;
    john.age = 31;
    john.name = "John Little";
    john.height_in_cm = 237;
    printf("%s is %d years old and stands %dcm tall in his socks\n",
           john.name, john.age, john.height_in_cm);
    printf( "He is often seen with %s.\n", hero.name );




    return 0;
}
