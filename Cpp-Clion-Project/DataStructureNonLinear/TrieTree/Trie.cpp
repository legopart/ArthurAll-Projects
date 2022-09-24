// fix the amount of Destruction
// fix trim
// fix toLowerCaseSting

#include <iostream>
#include <string>
#include <map>
#include <vector>
#include <list>
#include <memory>

using std::string, std::to_string, std::cout,  std::vector, std::map;
using std::pair, std::list, std::shared_ptr, std::make_shared, std::exception;

class Trie {   //for example only

private:
    struct Node
    {
        typedef std::shared_ptr<struct Node> p_Node;
        char value;
        bool isEndOfWord;
        map<char, p_Node> words;  //map <pair<char, Node>>
        explicit Node(char data) : words{}, value{data}, isEndOfWord{false} { }
        ~Node(){ cout << "del:" << value << "; "; }
        //used Word instead Child !
        bool isEmpty() const { return words.empty(); }
        p_Node getWord(const char& ch)  {  return words.find(ch)->second; }
        bool hasWord(char& ch) const { return words.contains(ch); }
        void addWord(char ch)
        {
            auto newNode = make_shared<struct Node>(ch);
            words.insert({ch, newNode});
        }
        void removeWord(const char& ch)  { words.erase(ch); }
        vector<p_Node> getWords() const
        {
            vector<p_Node> wordsVector{};
            for( auto it = words.begin(); it != words.end(); ++it )  wordsVector.push_back(it->second);
            return wordsVector;
        }
        bool hasWords() const { return !isEmpty(); }
    };

    typedef std::shared_ptr<struct Node> p_Node;

    bool isNull(p_Node node) const { return node == NULL; }
    bool isNull(string word) const { return word.length() == NULL; }
    string& toLowerCaseSting(const string& str)
    {
        string lowerCaseString = str;
        transform(lowerCaseString.begin(), lowerCaseString.end(), lowerCaseString.begin(),
                       [](unsigned char ch){ return tolower(ch); });
        return lowerCaseString;
    }
    string& trim(string& str){
        size_t space = str.find_first_not_of(" \t");
        if( string::npos != space )
        {
            str = str.substr( space );
        }
        return str;
    }
    bool contains(string& word, int index, p_Node node) const
    {
        if (index == word.length()) return node->isEndOfWord;
        char ch = word[index];
        if (!node->hasWord(ch)) return false;
        else return contains(word, index + 1, node->getWord(ch));
    }
    void remove(const string& word, const int& index, p_Node node)
    {   //לחזור
        if (index == word.length())
        {
            node->isEndOfWord = false;
            return;
        }
        auto ch = word[index];
        auto next = node->getWord(ch);
        if (isNull(next)) return;
        remove(word, index + 1, next);
        if (!next->hasWords() && !next->isEndOfWord) node->removeWord(ch); //!!!
    }

    void traversePreOrder(p_Node node, string& str)
    {
        str += node->value;
        for (auto chNode : node->getWords()) traversePreOrder(chNode, str);
        str += " ";
    }
    void traversePostOrder(p_Node node)
    {
        cout << " ";
        for (auto chNode : node->getWords()) traversePostOrder(chNode);
        cout << node->value;
    }
    void findWords(string word, /*ref*/ list<string>& wordList, p_Node node)
    {
        if (node->isEndOfWord) wordList.push_back(word);
        for(auto chNode : node->getWords()) findWords(word + to_string(chNode->value), wordList, chNode);
    }
    p_Node findWordEnd(string word)
    {
        auto current = root;
        for (auto ch : word)
        {
            auto next = current->getWord(ch);
            if (isNull(next)) return 0;
            current = next;
        }
        return current;
    }
public:
    explicit Trie() : root{make_shared<struct Node>('\0')} { }
    ~Trie() {  }
    p_Node root;
    void insert(const string& word)
    {
        string lowerCaseString = word;//toLowerCaseSting(word);
        if (isNull(word)) throw exception();
        auto current = root ;
        for(char& ch : lowerCaseString)
        {
            if (!current->hasWord(ch))  current->addWord(ch);
            current = current->getWord(ch);
        }
        current->isEndOfWord = true;
    }
    bool contains(string word)   //recursion
    {
        string lowerCaseString = word;//toLowerCaseSting(word);
        if (isNull(word)) return false;
        return contains(lowerCaseString, 0, root);
    }
    void remove(string word) { remove(word, 0, root); }
    string traversePreOrder() { string str=""; traversePreOrder(root, str);str = trim(str) ;str += "\n"; return str  ; }
    void traversePostOrder() { traversePostOrder(root); }
    list<string>& findWords(string word) //לחזור
    {
        list<string> wordList{};    //java ArrayList<>
        auto startNode = findWordEnd(word);    //startPoint
        findWords(word, wordList, startNode);
        return wordList;
    }
    string print() { return traversePreOrder();  }
};