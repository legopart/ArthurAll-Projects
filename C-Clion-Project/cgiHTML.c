#include <stdio.h>
// run with Apache 2 / XAMPP
// gcc cgiHTML -o cgiHTML.cgi

int main(int argc, char *argv[])
{
    printf("Content-type: text/html\n\n");  
    printf("<html>");
    printf("<head>");
    printf("<title>Test</title>");
    printf("</head>");
    printf("<body>");
    printf("<h1>Hello world!</h1>");
    printf("</body>");
    printf("</html>");
    return 0;
}