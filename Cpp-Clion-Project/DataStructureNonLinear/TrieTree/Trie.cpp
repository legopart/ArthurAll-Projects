#include <iostream>
#include <string>
#include <map>
#include <vector>
using std::string, std::to_string, std::cout;
class Trie {   //for example only
private:
    struct Node
    {
        std::map<char, struct Node> words;  //map <pair<char, Node>>
        char value;
        bool isEndOfWord;

        explicit Node(int data) : words{}, value{}, isEndOfWord{false}  { }
        ~Node(){ cout << "del:" << value << "\n"; }
        //used Word instead Child !
        bool isEmpty() const { return words.empty(); }
        struct Node& getWord(const char& ch)  { return words.find(ch)->second; }
        bool hasWord(char& ch) const { return words.contains(ch); }
        void addWord(const char& ch) { words.insert(std::pair( ch, Node{ch})); }
        void removeWord(const char& ch)  { words.erase(ch); }
        std::vector<Node> getWords() { return ; }
        bool HasWords() const { return !isEmpty(); }
    };

public:
    explicit Trie(){}
    ~Trie() { }


};