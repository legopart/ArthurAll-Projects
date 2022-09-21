

#include <iostream>
#include <list>
#include<bits/stdc++.h>
#include "Heap.cpp"
using  std::cout;
int main() {
    cout << "HeapTree\n";

    Heap heap{};
    heap.insert(20);
    heap.insert(10);
    heap.insert(5);
    heap.insert(2);
    heap.insert(6);
    heap.insert(8);
    heap.remove();
    cout << heap.print() << "\n";
    return 0;
}

 int getKthLargest (const int* array, const int& arrayLength,const int& kth)
{
    if (kth > arrayLength || kth < 1) throw new std::exception();
    Heap heap{};
    for (int i{}; i < arrayLength; ++i) heap.insert(array[i]);
    for (int i = 0; i < kth - 1; i++) heap.remove();
    return heap.max();//heap.Remove();
}

void arrayHeapify (const int* array, const int& arrayCount) { for (int i = arrayCount / 2 - 1; i >= 0; i--) arrayHeapify(array, i); }
void arrayHeapify (int* array, const int& arrayCount,  const int& i)
{
    auto largerIndex = i;
    auto leftIndex = i << 1  + 1; //i*2+1
    auto rightIndex = i << 1 + 2; //i*2+2
    if (leftIndex < arrayCount && array[leftIndex] > array[largerIndex]) largerIndex = leftIndex;
    if (rightIndex < arrayCount && array[rightIndex] > array[largerIndex]) largerIndex = rightIndex;
    if (i == largerIndex) return;
    std::swap(array[i], array[largerIndex]);
}

