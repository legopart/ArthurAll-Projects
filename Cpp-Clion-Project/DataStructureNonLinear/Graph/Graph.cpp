
#include <iostream>
#include <string>
#include <map>
#include <set>
#include <vector>
#include <list>
#include <stack>
#include <queue>
#include <memory>
#include <iterator>
using std::string, std::to_string, std::cout;
class Graph {   //for example only
private:
    struct Node {
     char label;
     explicit Node(char& label) : label{label} {   }
     ~Node(){cout << "del:" << label << " ";}
     bool operator<(const struct Node& other) const { return this->label < other.label; }
     char print() const { return label; }
    };
    std::map<char, std::shared_ptr<struct Node>> nodes;
    std::map< std::shared_ptr<struct Node>, std::list<std::shared_ptr<struct Node>>> edges;
    bool isNull(std::_Rb_tree_iterator<std::pair<const char, std::shared_ptr<struct Node>>> itNode) { return itNode == nodes.end();}
    void traverseDepthFirst_recursion(std::shared_ptr<struct Node> node, std::set<std::shared_ptr<struct Node>>& visited)
    {
        std::cout << node->print() << " ";
        visited.insert(node);
        for (auto neighbour : edges.find(node)->second)
        if (!visited.contains(neighbour)) traverseDepthFirst_recursion(neighbour, visited);
    }
    std::list<char> ToList(std::stack<std::shared_ptr<struct Node>>& stack) {
        std::list<char> sortedList{};
        while (stack.empty()) {sortedList.push_back(stack.top()->label); stack.pop();}
        return sortedList;
    }
    void topologicalSort(std::shared_ptr<struct Node> node, std::set<std::shared_ptr<struct Node>> visitedSet, std::stack<std::shared_ptr<struct Node>> stack)
    {
        if (visitedSet.contains(node)) return;
        visitedSet.insert(node);
        for (auto neighbour : edges.find(node)->second)
            topologicalSort(neighbour, visitedSet, stack);
        stack.push(node);
    }
    bool hasCycle(std::shared_ptr<struct Node> node, std::set<std::shared_ptr<struct Node>> all, std::set<std::shared_ptr<struct Node>> visiting, std::set<std::shared_ptr<struct Node>> visited)
    {
        all.erase(node);
        visiting.insert(node);
        for (auto neighbour : edges.find(node)->second)
        {
            if (visited.contains(neighbour)) continue;
            if (visiting.contains(neighbour)) return true;
            if (hasCycle(neighbour, all, visiting, visited)) return true;
        }
        visiting.erase(node);
        visited.insert(node);
        return false;
    }
public:
    explicit Graph() : nodes{}, edges{} {}
    ~Graph() {}
    void addNode(char label)
    {
        auto newNode= std::make_shared<Node>(label);
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

    void addEdge(char from, char to)
    {   //relationship from -> to

        try
        {
            if(nodes.find(from) == nodes.end() || nodes.find(to) == nodes.end()) throw std::exception();
            edges.find(nodes.find(from)->second)->second.push_back(nodes.find(to)->second);
        } catch (...) { throw std::exception(); }    //IsNull
    }
    void removeEdge(char from, char to)
    {   //remove from.to
        try {edges.find(nodes.find(from)->second)->second.remove(nodes.find(to)->second);}
        catch (...) { return; }    //IsNull
    }



    //Iteration
    void traverseDepthFirst(char root)
    {
        std::set<std::shared_ptr<struct Node>> visited{};
        std::stack<std::shared_ptr<struct Node>> stack{};
        auto rootNode = nodes.find(root);
        if (isNull(rootNode)) return;
        stack.push(rootNode->second);   //Link
        while (stack.empty())
        {
            auto node = stack.top() ;
            stack.pop();
            if (visited.contains(node)) continue;
            else visited.insert(node);
            std::cout << node << " ";
            for (auto neighbour : edges.find(node)->second)   //Links
                if (!visited.contains(neighbour)) stack.push(neighbour);
        }
    }

    void traverseBreadthFirst(char root)
    {
        std::set<std::shared_ptr<struct Node>> visited{};
        std::queue<std::shared_ptr<struct Node>> queue{};
        auto rootNode = nodes.find(root);
        if (isNull(rootNode)) return;
        queue.push(rootNode->second);   //Link
        while (queue.empty())
        {
            auto node = queue.front() ;
            queue.pop();
            if (visited.contains(node)) continue;
            else visited.insert(node);
            std::cout << node << " ";
            for (auto neighbour : edges.find(node)->second)   //Links
                if (!visited.contains(neighbour)) queue.push(neighbour);
        }
    }

    void traverseDepthFirst_recursion(char root)
    {
        try
        {
            std::set<std::shared_ptr<struct Node>> visited{};
            auto rootNode = nodes.find(root)->second;
            traverseDepthFirst_recursion(rootNode, visited);
            std::cout << "\n";
        } catch (...) { return; }
    }

    bool hasCycle()
    {   //לחזור
        std::set<std::shared_ptr<struct Node>> allNodes{};
                for(auto it : nodes) { allNodes.insert(it.second);}
        std::set<std::shared_ptr<struct Node>> visiting{};
        std::set<std::shared_ptr<struct Node>> visited{};
        for(auto current : allNodes)  if (hasCycle(current, allNodes, visiting, visited)) return true;
        return false;
    }


    std::string print()
    {
        std::string str = "";
        for (auto itMap : edges)
        {
            auto targets = edges.find(itMap.first)->second;
            if (!targets.empty()) {
                str += itMap.first->print();
                str += " is connected to [";
                for(auto itList: targets) {
                    if(itList == NULL) continue;
                    str += itList->print();
                    str +=  ", ";
                }
                str += "]\n";
            }
        }
        return str;
    }

};