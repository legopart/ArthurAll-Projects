
#include <iostream>
#import "QueueArray.cpp"
#import "QueueStack.cpp"

int main()
{
    QueueArray queue{};
    queue.enqueue(10);
    std::cout << queue.dequeue() << "\n";
    queue.enqueue(20);
    queue.enqueue(30);
    queue.enqueue(40);
    queue.enqueue(50);
    queue.enqueue(60);
    queue.enqueue(70);
    queue.enqueue(80);
    queue.enqueue(90);
    queue.enqueue(100);
    queue.enqueue(110);
    queue.enqueue(120);
    queue.enqueue(120);
    queue.enqueue(130);
    queue.enqueue(140);
    queue.enqueue(150);
    queue.enqueue(160);

    std::cout << "QueueArray: " << queue.print() << "\n";


    QueueStack queue2{};
    queue2.enqueue(10);
    std::cout << queue2.dequeue() << "\n";
    queue2.enqueue(20);
    queue2.enqueue(30);
    queue2.enqueue(40);
    queue2.enqueue(50);
    queue2.enqueue(60);
    queue2.enqueue(70);
    queue2.enqueue(80);
    queue2.enqueue(90);
    queue2.enqueue(100);
    queue2.enqueue(110);
    queue2.enqueue(120);
    queue2.enqueue(120);
    queue2.enqueue(130);
    queue2.enqueue(140);
    queue2.enqueue(150);
    queue2.enqueue(160);
    //std::cout << queue2.dequeue() << "\n";
    std::cout << "QueueStack: " << queue2.print() << "\n";
}