//Improve print() method


#include <iostream>
#include <string>
#include <list>
#include <iterator>
class LinkedStack
{
private:
    std::list<int> items{};
    bool isEmpty() const { items.size() == 0; };
public:
    explicit LinkedStack() : items() { }
    ~LinkedStack(){  }

    void push(int value){
        items.push_back(value);
    }
    int peak(){
        if(isEmpty()) throw 0;
        return items.back();
    }

    int pop(){
        int i  = items.back();;
       items.pop_back();
       return  i;
    }
    std::string print(){
        std::string str = "";
        for (auto it: items) str += std::to_string(it) + " ";
        return str;
    }

};