
#include <iostream>
#include <stack>
#import "linearSearch.cpp"

using std::string, std::cout, std::endl;

static string print(int&& result) { return (result >= 0 ? to_string(result + 1 ) + " true" : to_string(result) + " false"); }

int main()
{
    int target = 1;
    int arrayLength = 7;
    int* array = new int[arrayLength] { 7, 3, 1, 4, 6, 2, 3};

    cout <<"Linear Search: " << print( linearSearch(array, arrayLength, target) );

    return EXIT_SUCCESS;
}
