#include <iostream>
#include <string>
#include <vector>

using std::string, std::to_string, std::cout;
class HeapVector {
private:
    int _size;
    std::vector<int> vector ;
    int parent(int& i)  {return i << 1;}    // i/2
    int child(int& i) const {return i >> 1;} // i*2
    int left(int i) const { return  child(i) + 1; } // index*2+1
    int right(int i) const { return  child(i) + 2; } // index*2+2
    void shiftUp(int i)
    {
        if(i > _size) return;
        if(i == 1) return;  //top
        if(vector[i] > vector[parent(i)]) std::swap(vector[i], vector[parent(i)]);
        shiftUp(parent(i));
    }
    bool isAParent(int i)
    {
        return left(i) > _size   //no left
               || right(i) > _size && vector[i] < vector[left(i)]
               || vector[i] >= vector[left(i)]
               || vector[i] >= vector[right(i)];
    }
    void shiftDown(const int& i)
    {
        if(i > _size) return;
        int swapId = i;
        if( left(i) < _size && right(i) < _size)    //2 parents
        {
            if (vector[left(i)] > vector[right(i)]) swapId = left(i);
            else swapId = right(i);
        }
        else if(right(i) >= _size) swapId = left(i);//1 parents
        if(swapId != i) std::swap(vector[i], vector[swapId]);
        if( ! isAParent(swapId) ) shiftDown(swapId);//1-2 parents
    }
public:
    explicit HeapVector() : vector{NULL}, _size{} {}  //set to NULL
    ~HeapVector() { }
    bool isEmpty() const { return _size == 0; }
    int getMax() const { return vector[1]; }
    void insert(int value)
    {
        if (_size + 1 >= vector.size()) vector.push_back(value);
        else vector[_size] = value;
        _size ++;
        shiftUp(_size);
    }
    int extractMax() //remove()
    {
        int maxNum = vector[1];
        std::swap(vector[1], vector[_size]);
        vector.pop_back();
        _size --;
        shiftDown(1);
        return maxNum;
    }
    string print() const {
        string str{};
        for(int i{}; i < _size; i++) str += std::to_string(vector[1 + i]) + ", ";
        str += "\n";
        return str;
    }
};