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
public:
    explicit Heap() : arrayLength{10}, itemArray{new int[arrayLength]}, count{}, {}
    ~Heap() { delete[](itemArray) ;}

};