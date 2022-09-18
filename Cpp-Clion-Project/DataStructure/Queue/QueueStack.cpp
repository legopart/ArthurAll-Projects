//use memcopy to allocate
// delete[](items);  issue

#include <iostream>
#include <stack>
#include <string>
using std::stack, std::string, std::to_string;
class QueueStack
{
private:
    stack<int> queueStack; //stackA
    stack<int> enqueueStack; //stackB
    bool isEmpty() const { return queueStack.size() == 0;}
public:
    explicit QueueStack() : queueStack(), enqueueStack() {  }
    ~QueueStack(){  }

    void enqueue(int value) { queueStack.push(value);  }
    int dequeue()
    {
        if(queueStack.empty()) throw 0;
        while(!queueStack.empty()) {enqueueStack.push(queueStack.top()); queueStack.pop();}
        int value = enqueueStack.top();
        enqueueStack.pop();
        while(!enqueueStack.empty()) {queueStack.push(enqueueStack.top()); enqueueStack.pop();}
        return value;
    }
    string print()
    {
        string str = "";
        while(queueStack.size() != 0) {enqueueStack.push(queueStack.top()); queueStack.pop();}
        while(enqueueStack.size() != 0) {
            str += to_string(enqueueStack.top()) + " ";
            queueStack.push(enqueueStack.top());
            enqueueStack.pop();
        }
        return str;
    }

};