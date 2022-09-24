#include "ArthurClass.h"

#include <iostream> // directive //pre process directive
#include <string> 
#include <cmath> 

using namespace std;    // libabarery //standart libarary



namespace arthur1 {
    string abc = "dfgsdgds";
}

string str = "fsfasfsafasfa";


template <class T>  //generic type of data
T addCrap(T a, T b) {
    return a + b;
}

template < class T1, class T2>
double smaller(T1 a, T2 b) {
    return (a < b ? a : b);
}


namespace arthur {



    void foo(int y); //function prototype
    void foo(float y);  //override

    int ff() { return 5599; }
    int main() {    //
        double* ptr{ nullptr };
        double xx;
        void* yy = &xx;
        //using std::cout;
        // cout << ""; //using only one method from namespace

        using distance_t = double;
        typedef long miles_t;

        cout << smaller(111, 999.0) << endl;


        cout << ::addCrap(111.99, 999.0) << endl;
        const int TTT = 5;

        int arr[4] = { 9, 8, 7, 6 };

        ArthurClass arthurClass("exelent!!!");
        arthurClass.cool();
        ArthurClass* arthurPointer = &arthurClass;
        arthurPointer->cool();//arrow selection operator
        cout << "---------155---------" << endl;
        cout << arthurClass + 55 << endl;
        ArthurClass c = arthurClass + ArthurClass("bbb");
        cout << arthurClass.parantFoo() << endl;

        cout << arthurClass.getValue() << endl;

        const ArthurClass arthurClass2("exelent2!!!");
        cout << arthurClass2.getConst() << endl;


        //arthurClass.setValue("exelent!!!");


        int aa{ ff() };
        cout << "11111 a" << " ===> " << aa << endl;


        cout << ::str << " " << arthur1::abc << " ===> " << arr[2] << endl;      //use the global one



        //auto result = (10 <=> 20) > 0;
        int value{ 1 }; //= 1
        if (true)
            cout << "hello" << " world " << value << endl;

        int a;
        int* p = &a;

        //std::cout << *p;

        //std::cout << "hello world" << std::endl;

        return 0;
    }

    void foo(int y) {
        int x;
        cin >> x;
        cout << "some message " << x << endl;

    }

    void foo(float y) {

    }

}



struct Person {
    const int id{};
    int age{};
    string name{};

};

int main(int argc, char** argv) {    // run arthur Object

    Person john = { 1, 32, "John" }; // use with ={} or {} or ()

    arthur::main();
    //throw string("error #1");   //no new

    return 0;
}
