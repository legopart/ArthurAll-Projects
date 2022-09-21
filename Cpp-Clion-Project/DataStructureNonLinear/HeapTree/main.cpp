

#include <iostream>
#include <list>
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