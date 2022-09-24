
#include <iostream>
#include <string> //#include <iterator>
#include <list>
using namespace std;



int main() {
    //list node > node > node, no index

    list<int> numbers;
    numbers.push_back(1);
    numbers.push_back(2);
    numbers.push_back(3);
    numbers.push_front(0);




    list<int> ::iterator it = numbers.begin();

    cout << *it << endl;

    it++;   //forward
    numbers.insert(it, 100);

    it--;
    cout << "aa " << *it << endl;
    list<int> ::iterator erased = numbers.erase(it);
    cout << "erased " << *erased << endl;   //1
    cout << endl;

    for (list<int> ::iterator it = numbers.begin(); it != numbers.end();) {
        if (*it == 2) {
            numbers.insert(it, 1234);   // 0 1 1234 2 3
        }
        if (*it == 1) {
            it = numbers.erase(it);   // 0 2 3
        }
        else { it++; } // 0 1234 2 3
    }
    cout << endl;




    for (list<int> ::iterator it = numbers.begin(); it != numbers.end(); it++) {
        cout << *it << endl;
    }
    cout << endl;




    return 0;
}