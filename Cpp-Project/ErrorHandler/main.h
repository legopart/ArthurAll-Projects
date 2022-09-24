#include <iostream>
#include <string> //#include <iterator>
#include <exception>

using namespace std;



int main() {    // run arthur Object


    class MyException : public exception {
    public:
        virtual const char* what() const throw() {
            return "some error returned";   //important not forger ovveride
        }
    };

    class Test {
    public:
        void goesWrong() {
            throw MyException();
        }
    };


    cout << "Advenced Project, exeptions" << endl;

    try {

        //throw string("error #1");   //no new

            // bad_alloc exception
        //char* str = new char[999999999999999999];
        //delete[] str;

        //throw exception();

       // throw MyException{};
        Test test;
        test.goesWrong();
    }
    catch (int e) {
        cout << "error messageInt " << e << endl;
    }
    catch (char const* e) {
        cout << "error messageCharSet " << e << endl;
    }
    catch (string& e) {
        cout << "error messageString " << e << endl;
    }
    catch (bad_alloc& e) {
        cout << "error message bad_alloc " << e.what() << endl;
    }
    catch (MyException e) {
        cout << "error message MyException " << e.what() << endl;
    }



    cout << "after all message" << endl;

    return 0;
}
