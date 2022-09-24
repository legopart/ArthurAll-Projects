
#include <iostream>
#include <string> //#include <iterator>
#include <set>
#include <stack>
#include <queue>

using namespace std;

int main() {

    class Test {
    private:
        int id;
        string name;
    public:
        Test() : id(0), name("") {}   //default constructure
        Test(int id, string name) : id(id), name(name) {}
        // ~Test() { cout << "Obj-dstryd" << endl; }
        void print() const { cout << this->id << ": " << this->name << endl; }
        bool operator<(const Test& other) const { return this->name < other.name; }
    };

    cout << "Stack" << endl;
    stack<Test> testStack;
    testStack.push(Test(10, "Mike"));
    testStack.push(Test(20, "Joe"));
    testStack.push(Test(255, "Joe"));
    testStack.push(Test(30, "Sue"));

    Test test1 = testStack.top();   // Sue 30, last object
    test1.print();

    testStack.pop();
    //Test test2 = testStack.top();   // Joe 255, last object //Reference
    Test& test2 = testStack.top();
    test2.print();
    cout << endl;


    while (testStack.size() > 0) {
        Test& test3 = testStack.top();
        test3.print();
        testStack.pop();
    }
    cout << endl;




    //FIFO
    cout << "Queue" << endl;
    queue<Test> testQueue;
    testQueue.push(Test(10, "Mike"));
    testQueue.push(Test(20, "Joe"));
    testQueue.push(Test(255, "Joe"));
    testQueue.push(Test(30, "Sue"));

    Test test4 = testQueue.front();   // Sue 30, last object
    test4.print();

    testQueue.pop();
    //Test test2 = testStack.top();   // Joe 255, last object //Reference
    Test& test5 = testQueue.front();
    test5.print();
    cout << endl;


    while (testQueue.size() > 0) {
        Test& test6 = testQueue.front();
        test6.print();
        testQueue.pop();
    }
    cout << endl;



    cout << endl;

    set<Test> tests;
    tests.insert(Test(10, "Mike"));
    tests.insert(Test(20, "Joe"));
    tests.insert(Test(255, "Joe")); //same name (exaple to fix another name but order by id next in map)
    tests.insert(Test(30, "Sue"));

    for (set<Test>::iterator it = tests.begin(); it != tests.end(); it++) {
        it->print();
    }
    cout << endl;

    set<int> numbers;
    numbers.insert(50);
    numbers.insert(10);
    numbers.insert(40);
    numbers.insert(30);
    numbers.insert(30);

    for (set<int>::iterator it = numbers.begin(); it != numbers.end(); it++) {
        cout << *it << endl;
    }
    cout << endl;

    set<int>::iterator itFind = numbers.find(30);
    if (itFind != numbers.end()) {
        cout << "Found: " << *itFind << endl;
    }
    cout << endl;


    if (numbers.count(30)) {
        cout << "Found: " << 30 << endl;
    }
    cout << endl;

    return 0;
}

