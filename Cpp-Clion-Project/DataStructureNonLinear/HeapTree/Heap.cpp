#include <iostream>
#include <string>
//move to smart pointer
//move to string_view to print
//fix destructures!     List.root   List.last
//delete in the middle
using std::string, std::to_string, std::cout;
class Heap {
private:
    int count;
    int* itemArray;
    int arrayLength;
    bool isFull(){ return count == arrayLength; }
    bool ismpty(){ return count == 0; }
    int parant(int index) {return index >> 1;} // index/2
    int child(int index) {return index << 1;} // index*2
    int left(int index){ return  child(index) + 1; } // index*2+1
    int right(int index){ return  child(index) + 2; } // index*2+2
    void swap(int* a, int* b){ std::swap(a, b); }
public:
    explicit Heap() : arrayLength{10}, itemArray{new int[arrayLength]}, count{} {}
    ~Heap() { delete[](itemArray) ;}
    void insert(int data)
    {

    }
};