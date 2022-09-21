//use memcopy to allocate
// delete[](items);  issue

#include <iostream>
#include <string>
using std::string, std::to_string;
class QueueCircular
{
private:
    int* items;
    int itemsLength;
    int count;
    int first;
    int last;
    bool isEmpty() const { return count == 0;}
    bool isFull() const { return itemsLength == count;}
public:
    explicit QueueCircular() : itemsLength{10}, items{new int[itemsLength]}, count{}, first{}, last{} {  }
    ~QueueCircular(){ delete[](items); }
    void enqueue(int value)
    {
        if(isFull()) throw new std::exception();
        items[last] = value;
        last = (last + 1) % itemsLength;
        count ++;
    }
    int dequeue()
    {
        if(isEmpty()) throw new std::exception();
        int value = items[first];
        first = (first +1) % itemsLength;
        count --;
        return value;   //return items[--count];
    }
    string print() const
    {
        string str{};
        for(int i = first; i < count; ++i) str += to_string(items[i]) + " ";
        return str;
    }
};