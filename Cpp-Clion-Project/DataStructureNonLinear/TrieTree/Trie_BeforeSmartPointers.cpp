// fix the amount of Destruction
// fix trim
// fix toLowerCaseSting

#include <iostream>
#include <string>
#include <map>
#include <vector>
#include <list>

using std::string, std::to_string, std::cout;
class Trie {   //for example only
private:
    struct Node
    {
        char value;
        bool isEndOfWord;
        std::map<char, struct Node> words;  //map <pair<char, Node>>
        explicit Node(char data) : words{}, value{data}, isEndOfWord{false} { }
        ~Node(){ std::cout << ";";/* << value << ";";*//* << value << "\n";*/ }
        //used Word instead Child !
        bool isEmpty() const { return words.empty(); }
        struct Node* getWord(const char& ch)  {  return &words.find(ch)->second; }
        bool hasWord(char& ch) const { return words.contains(ch); }
        void addWord(char ch)
        {
            Node newNode = Node(ch);
            words.insert({ch, newNode});
        }
        void removeWord(const char& ch)  { words.erase(ch); }
        std::vector<struct Node> getWords() const
        {
            std::vector<struct Node> wordsVector{};
            for( auto it = words.begin(); it != words.end(); ++it )  wordsVector.push_back(it->second);
            return wordsVector;
        }
        bool hasWords() const { return !isEmpty(); }
    };

    bool isNull(struct Node* node) const { return node == NULL; }
    bool isNull(string word) const { return word.length() == NULL; }
    std::string& toLowerCaseSting(const std::string& str)
    {
        std::string lowerCaseString = str;
        std::transform(lowerCaseString.begin(), lowerCaseString.end(), lowerCaseString.begin(),
                       [](unsigned char ch){ return std::tolower(ch); });
        return lowerCaseString;
    }
    std::string& trim(std::string& str){
        size_t space = str.find_first_not_of(" \t");
        if( string::npos != space )
        {
            str = str.substr( space );
        }
        return str;
    }
    bool contains(string& word, int index, struct Node* node) const
    {
        if (index == word.length()) return node->isEndOfWord;
        char ch = word[index];
        if (!node->hasWord(ch)) return false;
        else return contains(word, index + 1, node->getWord(ch));
    }
    void remove(const std::string& word, const int& index, struct Node* node)
    {   //לחזור
        if (index == word.length())
        {
            node->isEndOfWord = false;
            return;
        }
        auto ch = word[index];
        Node* next = node->getWord(ch);
        if (isNull(next)) return;
        remove(word, index +1, next);
        if (!next->hasWords() && !next->isEndOfWord) node->removeWord(ch); //!!!
    }

    void traversePreOrder(struct Node* node, std::string& str)
    {
        str += node->value;
        for (auto& ch : node->getWords()) traversePreOrder(&ch, str);
        str += " ";
    }
    void traversePostOrder(Node* node)
    {
        std::cout << " ";
        for (auto& ch : node->getWords()) traversePostOrder(&ch);
        std::cout << node->value;
    }
    void findWords(std::string word, /*ref*/ std::list<std::string>& wordList, Node* node)
    {
        if (node->isEndOfWord) wordList.push_back(word);
        for(auto& ch : node->getWords()) findWords(word + std::to_string(ch.value), wordList, &ch);
    }
    struct Node* findWordEnd(string word)
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
    explicit Trie() : root{new struct Node('\0')} { }
    ~Trie() { delete(root); }
    struct Node* root;
    void insert(const std::string& word)
    {
        std::string lowerCaseString = word;//toLowerCaseSting(word);
        if (isNull(word)) throw std::exception();
        struct Node *current = root ;
        for(char& ch : lowerCaseString)
        {
            if (!current->hasWord(ch))  current->addWord(ch);
            current = current->getWord(ch);
        }
        current->isEndOfWord = true;
    }
    bool contains(std::string word)   //recursion
    {
        std::string lowerCaseString = word;//toLowerCaseSting(word);
        if (isNull(word)) return false;
        return contains(lowerCaseString, 0, root);
    }
    void remove(std::string word) { remove(word, 0, root); }
    std::string traversePreOrder() { std::string str=""; traversePreOrder(root, str);str = trim(str) ;str += "\n"; return str  ; }
    void traversePostOrder() { traversePostOrder(root); }
    std::list<std::string>& findWords(string word) //לחזור
    {
        std::list<std::string> wordList{};    //java ArrayList<>
        auto startNode = findWordEnd(word);    //startPoint
        findWords(word, wordList, startNode);
        return wordList;
    }
    std::string print() { return traversePreOrder();  }
};