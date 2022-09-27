
#include <iostream>
#include <string>
using std::string, std::to_string, std::swap, std::cout, std::exception;




struct Array{ int*& array; int length; };

static void mergeSort(int*&array, const int& arrayLength);
static void merge(struct Array& array, struct Array& left, struct Array& right );

static void mergeSort(Array& array)
{
    mergeSort(array.array, array.length);
}
static void mergeSort(int*& array, const int& arrayLength)
{
    if (arrayLength < 2) return;    //!
    int middle =  arrayLength / 2;

    int* left = new int[middle];
    int* right = new int[arrayLength - middle];
    for (auto i = 0; i < middle; ++i)  left[i] = array[i];
    for (auto i = middle; i < arrayLength; ++i) right[i - middle] = array[i];

    struct Array arrayArray {array, arrayLength};
    struct Array leftArray {left, middle};
    struct Array rightArray {right, arrayLength - middle};
    mergeSort(leftArray);
    mergeSort(rightArray);
    merge(arrayArray, leftArray, rightArray);
    delete[](left);
    delete[](right);
}

static void merge(struct Array& array, struct Array& left, struct Array& right )
{
    int l{0}, r{0}, arr{0};
    while (l < left.length && r < right.length)
    {
        if (left.array[l] <= right.array[r]) array.array[arr++] = left.array[l++];
        else array.array[arr++] = right.array[r++];
    }
    // copy remaining items in sorted array!
    while (l < left.length) array.array[arr++] = left.array[l++];
    while (r < right.length) array.array[arr++] = right.array[r++];
}















// C++ method:
static void merge2(int array[], int arrayStart, int middle, int arrayLength);
static void mergeSort2(int*& array, const int&arrayStart, const int& arrayLength);

[[maybe_unused]]
static void mergeSort2(int*& array, const int& arrayLength)
{
    mergeSort2(array, 0, arrayLength-1);
}
static void mergeSort2(int*& array, const int&arrayStart, const int& arrayLength)
{
    if (arrayStart < arrayLength)
    {
        int middle =(arrayStart + arrayLength) / 2;
        mergeSort2(array, arrayStart, middle);
        mergeSort2(array, middle + 1, arrayLength);
        merge2(array, arrayStart, middle, arrayLength);
    }
}

static void merge2(int array[], int arrayStart, int middle, int arrayLength)
{
    int leftLength = middle - arrayStart + 1;
    int rightLength = arrayLength - middle;
    int leftArray[leftLength], rightArray[rightLength];
    for (int i{}; i < leftLength; i++) leftArray[i] = array[arrayStart + i];
    for (int i{}; i < rightLength; i++) rightArray[i] = array[middle + 1 + i];
    int arr{0}, l{0}, r{arrayStart};
    while (arr < leftLength && l < rightLength)
    {
        if (leftArray[arr] <= rightArray[l]) array[r++] = leftArray[arr++];
        else array[r++] = rightArray[l++];
    }
    while (arr < leftLength) array[r++] = leftArray[arr++];
    while (l < rightLength) array[r++] = rightArray[l++];
}