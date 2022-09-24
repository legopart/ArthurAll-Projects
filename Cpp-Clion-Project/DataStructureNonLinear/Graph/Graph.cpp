
#include <iostream>
#include <string>
#include <map>
#include <set>
#include <vector>
#include <list>
#include <memory>

using std::string, std::to_string, std::cout;
class Graph {   //for example only
private:
    struct Node {
     char label;
     explicit Node(char& label) : label{label} {   }
     ~Node(){cout << ';' << label << " ";}
     bool operator<(const struct Node& other) const { return this->label < other.label; }
     char print() const { return label; }
    };
    std::map<char, std::shared_ptr<struct Node>> nodes;
    std::map< std::shared_ptr<struct Node>, std::list<std::shared_ptr<struct Node>>> edges;
    bool isNull(Node* node) { return node == NULL;}
public:
    explicit Graph() : nodes{}, edges{} {}
    ~Graph() {}
    void addNode(char label)
    {
        auto newNode= std::make_shared<Node>(Node(label));
        nodes.insert({label, newNode});
        auto node = nodes.find(label)->second;
        std::list<std::shared_ptr<struct Node>> newNodeList{};
        edges.insert({node, newNodeList});  //new List
    }
    void removeNode(char label)
    {
        auto it = nodes.find(label);
        if ( it == nodes.end()) return;
        nodes.erase(label);
        edges.erase(it->second);
    }
};