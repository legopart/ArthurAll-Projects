
#include <iostream>
#include <string>
#include <map>
#include <set>
#include <vector>
#include <list>

using std::string, std::to_string, std::cout;
class Graph {   //for example only
private:
    struct Node {
        char label;
        explicit Node(char& label) : label{label} {   }
        ~Node(){cout << ';' ;}
        bool operator<(const struct Node& other) const { return this->label < other.label; }
        char print() const { return label; }

    };
    std::map<char, struct Node> nodes;
    std::map< struct Node, std::list<struct Node>> edges;
    bool isNull(Node* node) { return node == NULL;}
public:
    explicit Graph() : nodes{}, edges{} {}
    ~Graph() {}
    void addNode(char label)
    {
        Node newNode(label);
        nodes.insert({label, newNode});
        Node node = nodes.find(label)->second;
        std::list<struct Node> newNodeList{};
        edges.insert({node, newNodeList});  //new List
    }
    void removeNode(char label)
    {
        auto it = nodes.find(label);
        if ( it != nodes.end())
        {
            nodes.erase(label);
            edges.erase(it->second);
        }



    }
};