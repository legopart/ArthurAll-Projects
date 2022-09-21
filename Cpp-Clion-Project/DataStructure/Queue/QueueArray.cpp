//use memcopy to allocate
// delete[](items);  issue

#include <iostream>
#include <string>
using std::string, std::to_string;
class QueueArray
{
private:
    int itemsLength;
    int* items;
    int count;
    int first;
    bool isEmpty() const { return count == 0;}
    void allocate()
    {
        int* newQueue = new int[itemsLength * 2];
        for(int i = first ; i < count; ++i) newQueue[i - first] = items[i];

        count -= first;
        first = 0;
        delete[](items);
        itemsLength *= 2;
        items = newQueue;
    }
public:
    explicit QueueArray() : itemsLength{10}, items{new int[itemsLength]}, count{}, first{} {  }
    ~QueueArray(){ delete[](items); }
    void enqueue(int value)
    {
        if(count == itemsLength) allocate();//throw 0; // allocate
        items[count] = value;
        count ++;
    }
    int dequeue()
    {
        if(isEmpty()) throw 0;
        int value = items[first];
        first++;
        return value;   //return items[--count];
    }
    string print() const
    {
        string str{};
        for(int i = first; i < count; ++i) str += to_string(items[i]) + " ";
        return str;
    }
};