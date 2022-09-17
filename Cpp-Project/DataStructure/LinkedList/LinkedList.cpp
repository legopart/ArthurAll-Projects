#include <iostream>
#include "List.cpp"


int main()
{
    std::cout << "LinkedList\n";
    List list{};
    list.insertLast(10);
    list.insertLast(20);
    list.insertLast(30);
    list.insertLast(40);
    list.insertLast(50);
    list.insertLast(60);
    list.insertLast(70);
    list.insertLast(80);
    list.insertLast(90);
    list.insertLast(100);

    list.removeFirst();
    list.removeLast();

    std::cout << "KTH " << list.kth(3) << "\n";
    std::cout << list.print();
    list.reverse();
    std::cout << list.print();

}
