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

    int parent(int& index) const {return index >> 1;} // index/2
    int child(int& index) const {return index << 1;} // index*2
    int left(int& index) const { return  child(index) + 1; } // index*2+1
    int right(int& index) const { return  child(index) + 2; } // index*2+2
    void swap(int& a, int b) const { std::swap(itemArray[a], itemArray[b]); }
    //void swap(int& a, int&& b){ std::swap(itemArray[a], itemArray[b]); }
    void bubbleUp() const
    {
        auto index = count - 1; //last
        while (itemArray[index] > itemArray[parent(index)])
        {
            swap(index, parent(index));
            index = parent(index);
        }
    }
    bool isParant(int index) const
    {
        auto childLeft = itemArray[left(index)];
        auto childRight = itemArray[right(index)];
        if (index > count) return true;
        if (left(index) > count) return true;  //no right one;
        else if (right(index) > count) return itemArray[index] >= childLeft;
        else return itemArray[index] >=  childLeft &&  itemArray[index] >=  childRight;
    }
    void bubbleDown() const  // לחזור!
    {
        int index{};
        while (!isParant(index))
        {
            auto childLeft = itemArray[left(index)];
            auto childRight = itemArray[right(index)];
            int largerIndex = index; //ChildLeft(index) >= Counter
            if (right(index) < count && left(index) < count)
            {
                if (childLeft > childRight) largerIndex = left(index);
                else largerIndex = right(index);
            }
            else if (right(index) == count) largerIndex = left(index);
            //else largerIndex = index;
            swap(index, largerIndex);
            index = largerIndex;
        }
    }
public:
    explicit Heap() : arrayLength{10}, itemArray{new int[arrayLength]}, count{} {}
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