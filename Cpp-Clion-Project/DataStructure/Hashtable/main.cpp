

#include <iostream>
#include "HashtableChaining.cpp"
using std::cout ;
int main()
{
    cout << "hashtable \n";
    HashtableChaining hashtable{};
    if(hashtable.isEmpty()) cout <<  "true!\n";
    hashtable.insert(345, "Arthur");
    hashtable.insert(345677, "Bob");
    hashtable.insert(564798, "Salli");
    hashtable.insert(445868, "Sandy");
    hashtable.insert(346430, "Rub");
    hashtable.insert(548569, "John");

    hashtable.print();
    cout << "\n\n\n";

    hashtable.remove(345677); //Bob
    hashtable.remove(5798);  // -
    hashtable.remove(564798); // Salli
    hashtable.print();
    if(hashtable.isEmpty()) cout <<  "true!\n";
    else cout << "ok\n";

}