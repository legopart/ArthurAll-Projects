#include <iostream>
#include <memory>
using namespace std;
//struct C{
//    int x;
//    C(int x){this->x = x;}
//};




struct B2;
struct B1
{
    shared_ptr<B2> adjast;
    B1() { }
    ~B1() { cout << "byeA"; }
};


struct B2
{
    shared_ptr<B1> adjast;
    B2() { }
    ~B2() { cout << "byeA"; }
};


struct A
{
    char a;
    shared_ptr<A> adjast;
    A(char a) : a{a} { }
    ~A() { cout << "bye " << a << "\n"; }
};

int main() {
    shared_ptr<A> a = make_shared<A>('a');
    shared_ptr<A> b = make_shared<A>('b');
    a->adjast = b;
    b->adjast = a;
    shared_ptr<A> c = make_shared<A>('c');
    c->adjast = a;
    cout << "used count(a): " << a.use_count() << "\n";

//    int x = 1;
//    int y = -1;
//    std::cout << (false, ++x) << std::endl;
//    std::cout << x << std::endl;
//    std::cout << y << std::endl;
    cout << "end\n";
    return 0;
}
