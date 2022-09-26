
#include <iostream>
#include <map>
#include <set>
#include "HashtableChaining.cpp"
using std::cout, std::endl, std::string, std::map, std::set ;
static char firstNonRepeatedChar(string str);
static char firstRepeatedChar(string str);
int main()
{
    cout << "hashtable" << endl;
    HashtableChaining hashtable{};
    if(hashtable.isEmpty()) cout <<  "true!" << endl;
    hashtable.insert(345, "Arthur");
    hashtable.insert(345677, "Bob");
    hashtable.insert(564798, "Salli");
    hashtable.insert(445868, "Sandy");
    hashtable.insert(346430, "Rub");
    hashtable.insert(548569, "John");

    cout << hashtable.print();
    cout << endl << endl << endl;

    hashtable.remove(345677); //Bob
    hashtable.remove(5798);  //    item not found to delete 5798
    hashtable.remove(564798); // Salli
    cout << hashtable.print();
    if(hashtable.isEmpty()) cout <<  "true!" << endl;
    else cout << "ok" << endl << endl << endl;

    cout << firstNonRepeatedChar("A Green Apple") << endl; //g
    cout << firstRepeatedChar("A Green Apple") << endl; //e

    return EXIT_SUCCESS;
}


static char firstNonRepeatedChar(string str) {
    std::map<char, int> map {};
    /*to lower case*/std::transform(str.begin(), str.end(), str.begin(), [](unsigned char c){ return std::tolower(c); });
    for (auto ch : str) {
        if (map.contains(ch)) map.find(ch)->second ++;
        else map.insert(std::pair(ch, 1));
    }
    for (auto item : map)  if (item.second == 1) return (char)item.first;
}

static char firstRepeatedChar(string str) {
    std::set<char> set {};
    /*to lower case*/std::transform(str.begin(), str.end(), str.begin(), [](unsigned char c){ return std::tolower(c); });
    for (auto ch : str) {
        if (set.contains(ch)) return ch;
        else set.insert(ch);
    }
}