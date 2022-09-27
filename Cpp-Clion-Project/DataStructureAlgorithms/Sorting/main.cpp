
#include <iostream>
#include <stack>
#import "bubbleSort.cpp"
#import "selectionSort.cpp"
#import "insertionSort.cpp"
#import "mergeSort.cpp"
#import "quickSort.cpp"
#import "countingSort.cpp"
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

    array = new int[arrayLength] { 7, 3, 1, 4, 6, 2, 3 };
    insertionSort(array, arrayLength);
    cout <<"Insertion Sort: " << print(array, arrayLength);

    array = new int[arrayLength] { 7, 3, 1, 4, 6, 2, 3 };
    mergeSort(array, arrayLength);
    cout <<"Merge Sort: " << print(array, arrayLength);

    array = new int[arrayLength] { 7, 3, 1, 4, 6, 2, 3 };
    quickSort(array, arrayLength);
    cout <<"Quick Sort: " << print(array, arrayLength);

    array = new int[arrayLength] { 7, 3, 1, 4, 6, 2, 3 };
    countingSort(array, arrayLength);
    cout <<"Counting Sort: " << print(array, arrayLength);


    return EXIT_SUCCESS;
}
