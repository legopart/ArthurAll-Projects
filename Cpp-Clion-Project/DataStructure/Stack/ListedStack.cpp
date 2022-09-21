//Improve print() method


#include <iostream>
#include <string>
#include <list>
#include <iterator>
using std::list, std::string, std::to_string;
class LinkedStack
{
private:
    list<int> items{};
    bool isEmpty() const { items.size() == 0; };
public:
    explicit LinkedStack() : items{} { }
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
    string print() const
    {
        string str{};
        for (auto it: items) str += to_string(it) + " ";
        return str;
    }

};