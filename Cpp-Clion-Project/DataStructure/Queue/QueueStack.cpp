//use memcopy to allocate
// delete[](items);  issue

#include <iostream>
#include <stack>
#include <string>
class QueueStack
{
private:
    std::stack<int> queueStack; //stackA
    std::stack<int> enqueueStack; //stackB
    bool isEmpty(){ return queueStack.size() == 0;}
public:
    explicit QueueStack() : queueStack(), enqueueStack() {  }
    ~QueueStack(){  }

    void enqueue(int value)
    {
        queueStack.push(value);
    }
    int dequeue()
    {
        if(queueStack.empty()) throw 0;
        while(!queueStack.empty()) {enqueueStack.push(queueStack.top()); queueStack.pop();}
        int value = enqueueStack.top();
        enqueueStack.pop();
        while(!enqueueStack.empty()) {queueStack.push(enqueueStack.top()); enqueueStack.pop();}
        return value;
    }
    std::string print()
    {
        std::string str = "";
        while(queueStack.size() != 0) {enqueueStack.push(queueStack.top()); queueStack.pop();}
        while(enqueueStack.size() != 0) {
            str += std::to_string(enqueueStack.top()) + " ";
            queueStack.push(enqueueStack.top());
            enqueueStack.pop();
        }
        return str;
    }

};