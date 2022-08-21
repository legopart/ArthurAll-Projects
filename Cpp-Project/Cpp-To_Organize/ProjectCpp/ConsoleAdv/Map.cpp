#include <iostream>
#include <string> //#include <iterator>

#include <map>


using namespace std;

static int mainMap() {

    class Someone {
    private:
        string name;
        int age;
    public:
        Someone() : name(""), age(0) {}
        Someone(const Someone& other) { //better then overiting sign operator (lection 4.6)
            cout << "Copy constructor running" << endl;
            name = other.name;
            age = other.age;
        }
        Someone(string name, int age) : name(name), age(age) {}
        void print() const { cout << name << ": " << age << endl; }
        bool operator<(const Someone& other)  const {
            if (name == other.name) {
                return this->age < other.age;   //order
            }
            else {
                return this->name < other.name;
            }
            //return this->name < other.name;   //order
        }
    };


    //Multi Map
    multimap<int, string> lookup;       //multimap allowes multiple same key like 30 20
    lookup.insert(make_pair(30, "Mike"));
    lookup.insert(make_pair(20, "Vicky"));
    lookup.insert(make_pair(30, "Raj"));
    lookup.insert(make_pair(20, "Bob"));
    lookup.insert(make_pair(30, "Raj2"));
    lookup.insert(make_pair(20, "Vicky2"));
    for (multimap<int, string>::iterator it = lookup.begin(); it != lookup.end(); it++) {
        cout << it->first << ": " << it->second << endl;
    }
    cout << endl;

    cout << "Range 20" << endl;
    for (multimap<int, string>::iterator it = lookup.find(20); it->first == 20 && it != lookup.end(); it++) {
        cout << it->first << ": " << it->second << endl;
    }
    cout << endl;

    cout << "Range 30" << endl;
    //pair<multimap<int, string>::iterator, multimap<int, string>::iterator> its = lookup.equal_range(30);
    auto its = lookup.equal_range(30);
    for (multimap<int, string>::iterator it = its.first; it != its.second; it++) {
        cout << it->first << ": " << it->second << endl;
    }
    cout << endl;

    cout << endl;



    //Maps Object
    map<Someone, int> people1;

    people1[Someone("Mike", 40)] = 40;
    people1[Someone("Mike", 555)] = 40; //got 2 Mikes after comparing
    people1[Someone("Viki", 30)] = 50;
    people1[Someone("Rag", 20)] = 20;


    people1.insert(make_pair(Someone("Bob", 45), 55));

    for (map<Someone, int>::iterator it = people1.begin(); it != people1.end(); it++) {
        cout << it->second << ": " << flush;
        it->first.print();
    }

    cout << endl;


    cout << endl;



    map<int, Someone> people2;

    people2[0] = Someone("Mike", 40);
    people2[50] = Someone("Viki", 30);
    people2[20] = Someone("Rag", 20);
    people2.insert(make_pair(55, Someone("Bob", 45)));

    for (map<int, Someone>::iterator it = people2.begin(); it != people2.end(); it++) {
        cout << it->first << ": " << flush;
        it->second.print();
    }
    cout << endl;


    //Maps
    map<string, int> ages;

    ages["Mike"] = 40;
    ages["Raj"] = 20;
    ages["Viki"] = 30;
    ages["Viki"] = 70;


    pair<string, int> addToMap("Shon", 25);

    ages.insert(addToMap);
    ages.insert(pair<string, int>("Peter", 45));

    cout << ages["Raj"] << endl;
    if (ages.find("Raj2") != ages.end()) {

        cout << "Rag2: " << ages["Raj2"] << endl; //_Not in the map   //will add to the map, will add to the map
    }
    else {
        cout << "Cant found, Raj2" << endl;
    }
    cout << endl;

    for (map<string, int>::iterator it = ages.begin(); it != ages.end(); it++) {
        cout << it->first << ": " << it->second << endl;
    }
    cout << endl;

    for (map<string, int>::iterator it = ages.begin(); it != ages.end(); it++) {
        pair<string, int> age = *it;
        cout << age.first << ": " << age.second << endl;
    }
    cout << endl;

    return 0;
}

