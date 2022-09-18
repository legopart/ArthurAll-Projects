
#include <iostream>
#import "Stack.cpp"
#import "ListedStack.cpp"
using std::cout;
int main()
{
    Stack stack{};
    stack.push(10);
    cout << stack.pop() << "\n";
    stack.push(20);
    stack.push(30);
    stack.push(40);
    stack.push(50);
    stack.push(60);
    stack.push(70);
    stack.push(80);
    stack.push(90);
    stack.push(100);
    stack.push(110);
    stack.push(120);
    stack.push(130);
    stack.push(140);
    stack.push(150);
    stack.push(160);

    cout << stack.pop() << "\n";
    cout << "Stack: "<< stack.print() + "\n";


    cout << "\nStack wit Linked List\n";
    LinkedStack stack2{};

    stack2.push(10);
    stack2.push(20);
    stack2.push(30);
    stack2.push(40);
    stack2.push(50);
    cout << stack2.pop() << "\n";
    cout << stack2.print();

}