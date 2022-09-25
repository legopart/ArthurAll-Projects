
#include <iostream>
#include <memory>
using namespace std;

struct A
{
    shared_ptr<A> adjast;
    A() { }
    ~A() { cout << "byeA; "; }
};


struct B2;
struct B1
{
    shared_ptr<B2> adjast;
    B1() { }
    ~B1() { cout << "byeB1; "; }
};
struct B2
{
    static int a(int a, int b) { return 2; }
    weak_ptr<B1> adjast;    // <------------ Replaced to weak_ptr
    B2() { }
    ~B2() { cout << "byeB2; "; }
};
int main()
{

    shared_ptr<A> a = make_shared<A>();
    shared_ptr<A> b = make_shared<A>();
    a->adjast = b;
    b->adjast = a;

    shared_ptr<B1> b1 = make_shared<B1>();
    shared_ptr<B2> b2 = make_shared<B2>();
    
    b1->adjast = b2;
    b2->adjast = b1;

    cout << "Hello World!\n";
}

