//Fix needToSwap function
//Delete vector version

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
    void swap(int& a, int b) const { std::swap(itemArray[a], itemArray[b]); }
    int parent(int& index) const {return index / 2;} // index/2
    int child(int& index) const {return index * 2;} // index*2
    int left(int& index) const { return  child(index) + 1; } // index*2+1
    int right(int& index) const { return  child(index) + 2; } // index*2+2
    void bubbleUp() const
    {
        auto index = count - 1; //last
        while (index > 0 && itemArray[index] > itemArray[parent(index)])
        {
            std::swap(itemArray[index], itemArray[parent(index)]);
            index = parent(index);
        }
    }


    void bubbleDown()  // לחזור!
    {
        int index{};
        while (index <= count && !isValidParant(index))
        {
            int largerIndex = largerChildIndex(index);
            std::swap(itemArray[index], itemArray[largerIndex]);
            index = largerIndex;
        }
    }

    bool hasLeftChild(int i) { return left(i) <= count; }
    bool hasRightChild(int i) { return right(i) <= count; }
    int largerChildIndex(int index)
    {
        if (hasLeftChild(index) && hasRightChild(index))
        {
            if (itemArray[left(index)] > itemArray[right(index)]) return left(index);
            else return right(index);
        }
        else if (!hasRightChild(index) && hasLeftChild(index)) return left(index);
        else return index;
    }
    bool isValidParant(int index)
    {
        auto isValidLeft = itemArray[index] >= itemArray[left(index)];
        auto isValidRight = itemArray[index] >= itemArray[right(index)];
        if (hasLeftChild(index) && hasRightChild(index)) return isValidLeft && isValidRight;
        if (!hasRightChild(index) && hasLeftChild(index)) return isValidLeft;
        /*if (!hasLeftChild(index))*/  return true;
    }

public:
    explicit Heap() : arrayLength{20}, itemArray{new int[arrayLength]}, count{} {}
    ~Heap() { delete[](itemArray); }
    bool isFull() const { return count == arrayLength; }
    bool isEmpty() const { return count == 0; }
    void insert(const int data)
    {
        if(isFull()) throw new std::exception(); //or extend
        itemArray[count] = data;
        count ++;
        bubbleUp();
    }
    int max() const
    {
        if (isEmpty()) throw new std::exception();
        return itemArray[0];    //root
    }
    int remove() //remove top
    {
        if (isEmpty()) throw new std::exception();
        int temp = itemArray[0];
        count--;
        itemArray[0] = itemArray[count];
        bubbleDown();
        return temp;
    }
    string print() const {
        string str{};
        for(int i{}; i < count; i++) str += std::to_string(itemArray[i]) + ", ";
        str += "\n";
        return str;
    }
};