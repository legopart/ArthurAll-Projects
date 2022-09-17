
#include <iostream>
#import "Stack.cpp"
#import "ListedStack.cpp"
int main()
{
    Stack stack{};
    stack.push(10);
    std::cout << stack.pop() << "\n";
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

    std::cout << stack.pop() << "\n";
    std::cout << "Stack: "<< stack.print() + "\n";


    std::cout << "\nStack wit Linked List\n";
    LinkedStack stack2{};

    stack2.push(10);
    stack2.push(20);
    stack2.push(30);
    stack2.push(40);
    stack2.push(50);
    std::cout << stack2.pop() << "\n";
    std::cout << stack2.print();

}