
#include <iostream>
#include <string>
#include <list>
using std::pair, std::list, std::string, std::begin, std::end, std::cout ;

struct Pair
{
    int key;
    string value;
    explicit Pair(int key, string value) : key(key), value(value) { }
    ~Pair(){ }
};

class HashtableChaining
{
private:
    static const int HASHTABLE_LENGTH = 10;
    //list<pair<int, string>>* hashtable;
    list<Pair>* hashtable;


    int hashFunction(int key) const { return key % HASHTABLE_LENGTH; };
    list<Pair> getList(int key) { return hashtable[key]; };
    bool beginList(int key)
    {
//        auto list = getList(key);
//        if(list.size() == 0) {hashtable[hashFunction(key)] = new list<>() ; return true;}
        return false;
    }
public:
    HashtableChaining() : hashtable(new list<Pair>[HASHTABLE_LENGTH]) { }
    ~HashtableChaining(){  }
    bool isEmpty() const
    {
        for (int i{}; i < HASHTABLE_LENGTH; ++i) if(hashtable[i].size() != 0) return false;
        return true;
    };
    void insert(int key, string value)
    {
        auto& cell = hashtable[hashFunction(key)];
        bool keyExists = false;
        for(auto it = std::begin(cell);it != std::end(cell); it++){
            if(it->key == key) /*first in pair*/
            {
                keyExists = true;
                it->value = value; //new value
                break;
            }
        }
        if(!keyExists) cell.emplace_back(Pair(key, value)); //?
    }
    void remove(int key)
    {
        auto& cell = hashtable[hashFunction(key)];
        bool keyExists = false;
        for(auto it = std::begin(cell);it != std::end(cell); it++){
            if(it->key == key)   /*first in pair*/
            {
                keyExists = true;
                it = cell.erase(it); //new iterator
                break;
            }
        }
        if(!keyExists) {cout << "item not founnd"; } //?
    }
    void print() const
    {
        for(int i{}; i < HASHTABLE_LENGTH; ++i){
            if(hashtable[i].size() == 0) continue;
            for(auto it = hashtable[i].begin(); it != hashtable[i].end(); ++it){
                cout << "the key:" << it->key << " value: " <<  it->value <<"\n";
            }
        }
    }

};