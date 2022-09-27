
#include <iostream>
#include <stack>
#import "bubbleSort.cpp"
#import "selectionSort.cpp"
#import "insertionSort.cpp"
#import "mergeSort.cpp"
#import "quickSort.cpp"
#import "countingSort.cpp"
#import "bucketSort.cpp"
using std::to_string,std::string, std::cout, std::endl;

static string print(int* array, int arrayLength) { string str {"["}; for(int i = 0; i < arrayLength; ++i) str += to_string(array[i]) + ", "; str += "]\n"; return str; }

int main()
{
    int arrayLength = 7;
    int* basicArray = new int[arrayLength] { 7, 3, 1, 4, 6, 2, 3};
    int* array = new int[arrayLength];

    memcpy(array, basicArray, arrayLength * sizeof(int));
    bubbleSort(array, arrayLength);
    cout <<"Bubble Sort: " << print(array, arrayLength);

    memcpy(array, basicArray, arrayLength * sizeof(int));
    selectionSort(array, arrayLength);
    cout <<"Selection Sort: " << print(array, arrayLength);

    memcpy(array, basicArray, arrayLength * sizeof(int));
    insertionSort(array, arrayLength);
    cout <<"Insertion Sort: " << print(array, arrayLength);

    memcpy(array, basicArray, arrayLength * sizeof(int));
    mergeSort(array, arrayLength);
    cout <<"Merge Sort: " << print(array, arrayLength);

    memcpy(array, basicArray, arrayLength * sizeof(int));
    quickSort(array, arrayLength);
    cout <<"Quick Sort: " << print(array, arrayLength);

    memcpy(array, basicArray, arrayLength * sizeof(int));
    countingSort(array, arrayLength);
    cout <<"Counting Sort: " << print(array, arrayLength);

    memcpy(array, basicArray, arrayLength * sizeof(int));
    bucketSort(array, arrayLength, 3);
    cout <<"Bucket Sort: " << print(array, arrayLength);


    delete[](basicArray);
    delete[](array);
    return EXIT_SUCCESS;
}
