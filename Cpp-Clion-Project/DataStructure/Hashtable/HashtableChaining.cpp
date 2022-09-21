
#include <iostream>
#include <string>
#include <list>
using std::pair, std::list, std::string, std::to_string, std::begin, std::end, std::cout ;

class HashtableChaining
{
private:
    struct Pair
    {
        int key;
        string value;
        explicit Pair(int key, string value) : key{key}, value{value} { }
        ~Pair(){ }
    };
    static const int HASHTABLE_LENGTH = 10;
    //list<pair<int, string>>* hashtable;
    list<struct Pair>* hashtable;
    int hashFunction(int key) const { return key % HASHTABLE_LENGTH; };
    list<Pair> getList(int key) { return hashtable[key]; };
    bool beginList(int key) {  }
public:
    HashtableChaining() : hashtable{new list<Pair>[HASHTABLE_LENGTH]} { }
    ~HashtableChaining(){ delete[](hashtable); }
    bool isEmpty() const
    {
        for (int i{}; i < HASHTABLE_LENGTH; ++i) if(hashtable[i].size() != 0) return false;
        return true;
    };
    void insert (int key, string value)
    {
        auto& cell = hashtable[hashFunction(key)];
        bool keyExists = false;
        //for(auto it = std::begin(cell);it != std::end(cell); it++){
        for(auto& it : cell)
            if(it.key == key) /*first in pair*/
            {
                keyExists = true;
                it.value = value; //new value
                break;
            }
        if(!keyExists) cell.emplace_back(Pair(key, value)); //?
    }
    void remove(int key)
    {
        auto& cell = hashtable[hashFunction(key)];
        bool keyExists = false;

        for(auto it = std::begin(cell);it != std::end(cell); it++)
            if(it->key == key)   /*first in pair*/
            {
                keyExists = true;
                it = cell.erase(it); //new iterator
                break;
            }
        if(!keyExists) {cout << "item not found to delete " << to_string(key) << "\n"; } //?
    }
    string print() const
    {
        string str{};
        for(int i{}; i < HASHTABLE_LENGTH; ++i){
            if(hashtable[i].empty()) continue;
            for(auto& it :hashtable[i]) str += "the key:" + to_string(it.key) + " value: " + it.value +"\n";
        }
        return str;
    }

};