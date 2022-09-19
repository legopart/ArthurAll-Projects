

#include <iostream>
#include "LinkedList.cpp"
using  std::cout;
int main()
{
    cout << "LinkedList\n";
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

    cout << "KTH " <<list.kth(3) <<"\n";
    cout << list.print();
    list.reverse();
    cout << list.print();

    return 0;
}
