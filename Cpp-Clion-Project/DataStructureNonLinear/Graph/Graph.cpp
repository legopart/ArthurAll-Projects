
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

using std::string, std::to_string, std::cout, std::map, std::pair, std::set;
using std::stack, std::queue, std::list, std::shared_ptr, std::make_shared, std::exception;

class Graph {   //for example only
private:
    struct Node {
     char label;
     explicit Node(char& label) : label{label} {   }
     ~Node(){cout << "del:" << label << " ";}
     bool operator<(const struct Node& other) const { return this->label < other.label; }
     char print() const { return label; }
    };

    typedef shared_ptr<struct Node> p_Node;
    typedef std::_Rb_tree_iterator<pair<const char, p_Node>> it_Node;

    map<char, p_Node> nodes;
    map<p_Node, list<p_Node>> edges;
    bool isNull(it_Node itNode) { return itNode == nodes.end();}
    void traverseDepthFirst_recursion(p_Node node, set<p_Node>& visited)
    {
        cout << node->print() << " ";
        visited.insert(node);
        for (auto neighbour : edges.find(node)->second)
        if (!visited.contains(neighbour)) traverseDepthFirst_recursion(neighbour, visited);
    }
    list<char> toList(stack<p_Node>& stack) {   //fix to insert with it
        list<char> sortedList{};
        while (stack.empty()) {sortedList.push_back(stack.top()->label); stack.pop();}
        return sortedList;
    }
    void topologicalSort(p_Node node, set<p_Node> visitedSet, stack<p_Node> stack)
    {
        if (visitedSet.contains(node)) return;
        visitedSet.insert(node);
        for (auto neighbour : edges.find(node)->second)
            topologicalSort(neighbour, visitedSet, stack);
        stack.push(node);
    }
    bool hasCycle(p_Node node, set<p_Node> all, set<p_Node> visiting, set<p_Node> visited)
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
        auto newNode= make_shared<Node>(label);
        nodes.insert({label, newNode});
        auto node = nodes.find(label)->second;
        list<p_Node> newNodeList{};
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
            if(nodes.find(from) == nodes.end() || nodes.find(to) == nodes.end()) throw exception();
            edges.find(nodes.find(from)->second)->second.push_back(nodes.find(to)->second);
        } catch (...) { throw exception(); }    //IsNull
    }
    void removeEdge(char from, char to)
    {   //remove from.to
        try {edges.find(nodes.find(from)->second)->second.remove(nodes.find(to)->second);}
        catch (...) { return; }    //IsNull
    }



    //Iteration
    void traverseDepthFirst(char root)
    {
        set<p_Node> visited{};
        stack<p_Node> stack{};
        auto rootNode = nodes.find(root);
        if (isNull(rootNode)) return;
        stack.push(rootNode->second);   //Link
        while (stack.empty())
        {
            auto node = stack.top() ;
            stack.pop();
            if (visited.contains(node)) continue;
            else visited.insert(node);
            cout << node << " ";
            for (auto neighbour : edges.find(node)->second)   //Links
                if (!visited.contains(neighbour)) stack.push(neighbour);
        }
    }

    void traverseBreadthFirst(char root)
    {
        set<p_Node> visited{};
        queue<p_Node> queue{};
        auto rootNode = nodes.find(root);
        if (isNull(rootNode)) return;
        queue.push(rootNode->second);   //Link
        while (queue.empty())
        {
            auto node = queue.front() ;
            queue.pop();
            if (visited.contains(node)) continue;
            else visited.insert(node);
            cout << node << " ";
            for (auto neighbour : edges.find(node)->second)   //Links
                if (!visited.contains(neighbour)) queue.push(neighbour);
        }
    }

    void traverseDepthFirst_recursion(char root)
    {
        try
        {
            set<p_Node> visited{};
            auto rootNode = nodes.find(root)->second;
            traverseDepthFirst_recursion(rootNode, visited);
            cout << "\n";
        } catch (...) { return; }
    }

    bool hasCycle()
    {   //לחזור
        set<p_Node> allNodes{};
                for(auto it : nodes) { allNodes.insert(it.second);}
        set<p_Node> visiting{};
        set<p_Node> visited{};
        for(auto current : allNodes)  if (hasCycle(current, allNodes, visiting, visited)) return true;
        return false;
    }


    string print()
    {
        string str = "";
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