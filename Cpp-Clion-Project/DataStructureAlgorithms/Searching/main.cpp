
#include <iostream>
#include <stack>
#import "linearSearch.cpp"

using std::string, std::cout, std::endl;

static string print(int* array, int arrayLength) { string str {"["}; for(int i = 0; i < arrayLength; ++i) str += to_string(array[i]) + ", "; str += "]\n"; return str; }

int main()
{
    int target = 4;
    int arrayLength = 7;
    int* array = new int[arrayLength] { 7, 3, 1, 4, 6, 2, 3};


    memcpy(array, basicArray, arrayLength * sizeof(int));
    linearSearch(array, arrayLength, target);
    cout <<"Bubble Sort: " << print(array, arrayLength);

    return EXIT_SUCCESS;
}
