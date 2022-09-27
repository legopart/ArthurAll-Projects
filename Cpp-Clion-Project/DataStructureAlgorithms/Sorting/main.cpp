
#include <iostream>
#include <stack>
#import "bubbleSort.cpp"
#import "selectionSort.cpp"
//#import "ListedStack.cpp"
using std::string, std::cout, std::endl;

static string print(int* array, int arrayLength) { string str {"["}; for(int i = 0; i < arrayLength; ++i) str += to_string(array[i]) + ", "; str += "]\n"; return str; }

int main()
{
    int arrayLength = 7;
    int* array;

    array = new int[arrayLength] { 7, 3, 1, 4, 6, 2, 3 };
    bubbleSort(array, arrayLength);
    cout <<"Bubble Sort: " << print(array, arrayLength);

    array = new int[arrayLength] { 7, 3, 1, 4, 6, 2, 3 };
    selectionSort(array, arrayLength);
    cout <<"Selection Sort: " << print(array, arrayLength);



    return EXIT_SUCCESS;
}
