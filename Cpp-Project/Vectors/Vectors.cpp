#include <iostream>
#include <string> //#include <iterator>
#include <vector>
#include <algorithm>

using namespace std;


static bool comp(const string& a, const string& b) {
    return a > b;
}

int main() {
    //vectors

    vector< vector<int> > grid(3, vector<int>(4, 1)); // size, initialize
    grid[1].push_back(8);

    for (int row = 0; row < grid.size(); row++) {
        for (int col = 0; col < grid[row].size(); col++) {
            cout << grid[row][col] << flush;
        }
        cout << endl;
    }

    /**
    vector<string> strings1;
    strings1.push_back("one");
    strings1.push_back("two");
    strings1.push_back("three");
    /**/
    vector<string> strings1{ "one", "two", "three" };

    strings1[1] = "dog";

    cout << strings1[1] << endl;
    cout << strings1.size() << endl;
    cout << strings1.capacity() << endl;
    cout << endl;



    for (int i = 0; i < strings1.size(); i++) {
        cout << strings1[i] << endl;
    }
    cout << endl;


    vector<string>::iterator it1 = strings1.begin();     // iteretor = pointer , this begin, the first one as pointer!
    cout << *it1 << endl;
    cout << endl;


    cout << "sort:" << endl;
    sort(strings1.begin(), strings1.end(), comp);



    for (vector<string>::iterator it = strings1.begin(); it != strings1.end(); it++) {
        cout << *it << endl;
    }


    strings1.clear();       //change size to 0
    strings1.resize(2);      //change size
    strings1.reserve(2);    //change capacity, will take to move the array
    cout << endl;

    cout << endl;

    vector<string> strings(5, "begin value");
    strings.push_back("one");
    strings.push_back("two");
    strings.push_back("three");
    strings[3] = "dog";

    cout << strings[3] << endl;
    cout << strings.size() << endl;
    cout << strings.capacity() << endl;
    return 0;
}
