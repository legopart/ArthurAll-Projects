#include <iostream>
#include <string>
#include <vector>

using std::string, std::to_string, std::cout;
class HeapVector {
private:
    int _size;
    std::vector<int> vector ;
    int parent(int& i) const {return i >> 1;}    // i/2
    void shiftUp(int i)
    {
        if(i > _size) return;
        if(i == 0) return;  //top
        if(vector[i] > vector[parent(i)]) std::swap(vector[i], vector[parent(i)]);
        shiftUp(parent(i));
    }

    int child(int& i) const {return i << 1;} // i*2
    int left(int& i) const { return  child(i) + 1; } // index*2+1
    int right(int& i) const { return  child(i) + 2; } // index*2+2
    void shiftDown(const int& i)
    {
        if(i > _size) return;
        int swapId = largerChildIndex(i);
        if(swapId != i) std::swap(vector[i], vector[swapId]);
        if( i <= _size && !isValidParent(swapId) ) shiftDown(swapId);//1-2 parents
    }
    bool hasLeftChild(int& i) const { return left(i) <= _size; }
    bool hasRightChild(int& i) const { return right(i) <= _size; }
    int largerChildIndex(int i) const
    {
        if (hasLeftChild(i) && hasRightChild(i))
        {
            if (vector[left(i)] > vector[right(i)]) return left(i);
            else return right(i);
        }
        else if (hasLeftChild(i) && !hasRightChild(i)) return left(i);
        else return i;
    }
    bool isValidParent(int& i) const
    {
        auto isValidLeft = vector[i] >= vector[left(i)];
        auto isValidRight = vector[i] >= vector[right(i)];
        if (hasLeftChild(i) && hasRightChild(i)) return isValidLeft && isValidRight;
        if (hasLeftChild(i) && !hasRightChild(i)) return isValidLeft;
        /*if (!hasLeftChild(i))*/  return true;
    }

public:
    explicit HeapVector() : vector{}, _size{} {}  //set to NULL
    ~HeapVector() { }
    bool isEmpty() const { return _size == 0; }
    int getMax() const { return vector[0]; }
    void insert(const int& value)
    {
        if (_size >= vector.size()) vector.push_back(value);
        _size ++;
        vector[_size] = value;

        shiftUp(_size);
    }
    int extractMax() //remove()
    {
        int maxNum = vector[0];
        std::swap(vector[0], vector[_size]);
        vector.pop_back();
        _size --;
        shiftDown(0);
        return maxNum;
    }
    string print() const {
        string str{};
        for(int i{}; i < _size; i++) str += std::to_string(vector[i]) + ", ";
        //for(auto data : vector) str += std::to_string(data) + ", ";
        str += "\n";
        return str;
    }
};