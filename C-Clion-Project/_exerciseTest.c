 #include <stdio.h>
    #include <string.h> //get
    #include <time.h>   //time_t
    #include <stdarg.h> //va_arg
#include "external.c"

//void main(){printf("hello world2");}
/*
enum constansts{false=0, true=1};
typedef short boolean;
*/

int intagerAdd(int x){return x+1;}

int x = 1234;         /* program scope */
static int z = 3;         /* program scope */
void function_1(){printf("function x=%i\n",x);}

int add_two() ; //function declaration


//void GetDateTime(void); // no Value returened or entered



        //GetDateTime() definition ????? 
    void GetDateTime(void){ // GetDateTime()
        time_t now;
        //time(&now); //not require in this version
        printf("Within GetDateTime, date and time is: %s",
         asctime(localtime(&now))
        );}

double AddDouble(int x, ...){ // x= number of args
    va_list arglist; //...[1.5, 2.5, 3.5, 4.5]
    int i;
    double result = 0.0;

    printf("The number of arguments is: %d\n", x);
    va_start (arglist, x); //[1.5, 2.5, 3.5, 4.5], 4
            //void va_start(va_list ap, lastfix);
    for (i=0; i<x; i++) //i=0, 1, 2 ,3
        result += va_arg(arglist, double); //[1.5, 2.5, 3.5, 4.5], double
                //type va_arg(va_list ap, data_type)
    va_end (arglist);
    return result;}

struct Person{
    int age;
    char *name;
    int height_in_cm;
};



int main(){

printf("%i", INT_MIN);
    /* *
  struct Person hero = { 20, "Robin Hood", 191 };
  struct Person john;

  john.age = 31;
  john.name = "John Little";
  john.height_in_cm = 237;

  printf("%s is %d years old and stands %dcm tall in his socks\n",
         john.name, john.age, john.height_in_cm);

  printf( "He is often seen with %s.\n", hero.name );

    /* */

//add_twoExternal();


    /* *
    //functions
   
enum language {human=100,computer,
    animal=50};
enum days{SUN,
    MON,
    TUE,
    WED,
    THU,
    FRI,
    SAT};

printf("human: %d,  animal: %d,  computer: %d\n",
    human, animal, computer);
printf("SUN: %d\n", SUN);
printf("MON: %d\n", MON);
printf("TUE: %d\n", TUE);
printf("WED: %d\n", WED);
printf("THU: %d\n", THU);
printf("FRI: %d\n", FRI);
printf("SAT: %d\n", SAT);
    /* */

    /* *
        //functions arglist...
        double d1 = 1.5;
        double d2 = 2.5;
        double d3 = 3.5;
        double d4 = 4.5;
printf("Given an argument: %2.1f\n", d1);
printf("The result returned by AddDouble() is: %2.1f\n\n",
    AddDouble(1, d1));
printf("Given arguments: %2.1f, %2.1f, %2.1f, and %2.1f\n", d1, d2, d3, d4);
printf("The result returned by AddDouble() is: %2.1f\n",
    AddDouble(4, d1, d2, d3, d4));
    /* */

    /* *
        //functions
    //time
    printf("Before the GetDateTime() function is called.\n");
    GetDateTime();
    printf("After the GetDateTime() function is called.\n");



    /* */


    //add_two(); //function declar + define


     

    /* *
    //Static duration + Scopes and functions and vars outside the main
   
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

    /* */

    /* * //scanf() another example
    int x, y, sum;
    scanf("%i+%i", &x, &y);
    sum=x+y;
    printf("=%i",sum);
    /* */

    /* *
            // scanf("%d", &x)
    char str[80];
    int x, y;
    float z;

    printf("Enter two integers separated by a space:\n");
    scanf("%d  %d", &x, &y);
    printf("Enter a floating-point number:\n");
    scanf("%f", &z);
    printf("Enter a string:\n");
    scanf("%s", str);
    printf("Here are what you've entered:\n");
    printf("%d  %d\n%f\n%s\n", x, y, z, str);
    /* */

    /* *
        // gets( str ) puts( str )
    char str[80];
    int i, delt = 'a' - 'A';
    printf("Enter a string less than 80 characters:\n");
    gets( str );
    i = 0;
    while (str[i]){
        if ((str[i] >= 'a') && (str[i] <= 'z')) str[i] -= delt;  // convert to upper case 
        ++i;}
    printf("The entered string is (in uppercase):\n");
    puts( str );
    /* */




    /* * 
        //Strings -strcpy()
    char str1[] = "Copy a string.";
    char str2[15];
    strcpy(str2, str1);
    //for (i=0; str1[i]; i++) str2[i] = str1[i];
    printf("The content of str2: %s\n", str2);

    /* */

    /* *
    //Strings - strlen()
        char str1[] = {'A', ' ',
                's', 't', 'r', 'i', 'n', 'g', ' ',
                    'c', 'o', 'n', 's', 't', 'a', 'n', 't', '\0'};
    char str2[] = "Another string constant";
    char *ptr_str;
    ptr_str= "Assign a string to a pointer.";
    printf("%d", strlen(ptr_str)); // the string itself


    // char *ptr_str ;
    // ptr_str= "Assign a string to a pointer.";
    //     for (int i=0; *ptr_str; i++)
    //        printf("%c", *ptr_str++);


    /* */  



    /* *
// multy dimension Array
    // all options to set
    
    int array_int[2][3];
        array_int[0][0] = 1;
        array_int[0][1] = 2;
        array_int[0][2] = 3;
        array_int[1][0] = 4;
        array_int[1][1] = 5;
        array_int[1][2] = 6;
    //int array_int[2][3] = {1, 2, 3, 4, 5, 6};
    //int array_int[2][3] = {{1, 2, 3}, {4, 5, 6}};
    
 for (int i=0; i<2; i++){
    printf("\n");
    for (int j=0; j<3; j++)
    printf("%6d", array_int[i][j]);
        }   //6characters distance if needed

    printf("\n\n array size %d \n 1 int size:%d \n", sizeof (array_int), sizeof (int));

    /* *
//Arrays and Strings
    int array_int[8]; //declare 
    char day[7];
        day[0] = 'S';
    int arInteger[5] = {100, 8, 3, 365, 16};
     char array_ch[7] = {'H', 'e', 'l', 'l', 'o', '!', '\0'};
     // \0 null/false
    for (int i=0; array_ch[i]; i++)     //for (int i=0; array_ch[i] != '\0'; i++)
        printf("%c", array_ch[i]);
     //     char *ptr_str = "Assign a string to a pointer.";
     //     for (int i=0; *ptr_str; i++)
     //     printf("%c", *ptr_str++);
    printf("\n %s\n", array_ch); // print all array trogether
    /* */


    /* *
//print address pointers
    char c = 'a';
    char *ptr_c ;
    ptr_c=&c;
    *ptr_c='b';
    printf("c = '%c'\n", c); //c = 'b'
    char *ptr_c2=ptr_c; // ptr_c2=ptr_c;
    *ptr_c2='c';
    printf("(ptr_c2) c = '%c'\n", c); //c = 'b  
    /* */

    /* *
//print address
char c = 'c';
char d = c;
d = 'd';
printf("\n c: %c\n d: %c\n", c, d);
printf("\n c: %p\n d: %p\n", &c, &d);
    /* */


    /* *
int i,j;
for (i=0, j=1; i<8; i++, j++);
     printf("%d  +  %d  =  %d\n", i, j, i+j);
    /* */


    /* *
int i=65;
do{
printf("%c\n", i);
i++;
}
while(i<=90);
    /* */


//while(1){};

    /* *
    printf("Enter a character:\n(enter x to exit)\n");
for(char  c=' ';  c != 'x'; ) {
    c = getc(stdin);
    switch(x){
        case: 'a': printf("you pressed a");break;
        case: 'b': printf("you pressed b");break;
        case: 'x': printf("you will exit");break;
        default: printf("you presesed %c", c); //putchar(c);
    }
   }
printf("\nOut of the for loop. Bye!\n");
   /* */


    /* *
for (int i=1, j=14; i<=15, j>0; i++, j--)
       printf("%d\n", i); 
    /* */

    /* *
printf("\n\n");

   int a=4;
   float b=32.0/10.0;
   char c='A';
    printf("%d \t %c \t  %f \n", intagerAdd(a), c, b);

    printf("Please type in one character:\n");
    int ch = getc( stdin ); //getchar( ) on error EOF
    printf("The character you just entered is: %d\n", ch);

    printf("The Char is:\n");
    putc(ch, stdout); //putchar(ch)


    /* */

    return 0; //exit(0)
}


int add_two() { //function definition
    static int counter = 1;
    printf("This is the function call of %d,\n", counter++);
    }

/*comment*/