
#include <iostream>
#include <string>
class Stack
{
private:
    int itemsLength;
    int* items;
    int count;
    bool isEmpty() const { return count == 0;}
    void allocate()
    {
        int* newStack = new int[itemsLength * 2];
        for(int i = 0; i < count; ++i )  newStack[i] = items[i];
        itemsLength *= 2;
        delete[](items);
        items = newStack;
    }
public:
    explicit Stack() : itemsLength(10), items(new int[itemsLength]), count(0) { }
    ~Stack(){ delete[](items); }
    void push(int value){
        if(itemsLength == count) allocate();//throw 0; //or allocate
        items[count] = value;
        count ++;
    }

    int peak(){
        if(isEmpty()) throw 0;
        return items[count - 1];
    }

    int pop(){
        if(isEmpty()) throw 0;
        int value = items[count - 1];
        count --;
        return value;
    }

    std::string print(){
        std::string str = "";
        for (int i = 0; i < count; ++i){
            str += std::to_string(items[i]) + " ";
        }
        return str;
    }

};