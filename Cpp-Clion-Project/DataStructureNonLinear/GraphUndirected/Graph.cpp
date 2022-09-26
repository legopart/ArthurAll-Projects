// להוסיף remove node

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


struct Node
{
    typedef std::shared_ptr<struct Node> sp_Node;
    typedef std::shared_ptr<struct Edge> sp_Edge;
    typedef std::weak_ptr<struct Edge> wp_Edge;
    char label;
    list<sp_Edge> edges; /*!*/
    explicit Node(char& label) : label{label}, edges{} {   }
    ~Node(){ cout << "del:" << label << "; "; }
    void addEdge(sp_Node to, int weight) /*!*/
    {
        auto newEdge = make_shared<Edge>(this, to, weight);
        edges.push_back(newEdge);
    }
    string print() const { string toString{}; return toString+label; }
};
struct Edge {
    typedef std::weak_ptr<struct Node> wp_Node;
    typedef std::shared_ptr<struct Node> sp_Node;
    int weight;
    Node* from;
    wp_Node to;
    explicit Edge(Node* from, sp_Node to, int weight) : from{from}, to{to}, weight{weight} {   }
    ~Edge(){ cout << "del:" << print() << "; "; }
    string print() const {return from->print() + ">" + (!to.expired() ? sp_Node(to)->print() : "*") + "(" + to_string(weight) + ")";}
};

struct NodePriority {
    typedef std::shared_ptr<struct Node> sp_Node;
    sp_Node node;
    int priority;
    explicit NodePriority(sp_Node node, int priority) : node{node}, priority{priority} {}
    ~NodePriority() { cout << "del_priority:" << "" + node->label; }
    /*!*/// bool operator<(const struct NodePriority &other) const { return this->priority < other.priority; } /*!*/
};


class Graph {   //for example only
private:
    typedef std::shared_ptr<struct Node> sp_Node;
    typedef std::shared_ptr<struct Edge> sp_Edge;
    typedef shared_ptr<struct NodePriority> sp_NodePriority;
    map<char, sp_Node> nodes;
    bool isNull(auto itNode) const { return itNode == nodes.end(); }
    void addNode(sp_Node& node) { addNode(node->label); }
    void addEdge(sp_Node& from, sp_Node& to, sp_Edge& edge) const { addEdge(from->label, to->label, edge->weight); }
    list<char> buildPath(map<sp_Node, sp_Node>& previousNodes, sp_Node& toNode) const {
        stack<sp_Node> stack{};
        stack.push(toNode);
        auto previous = previousNodes.find(toNode)->second;
        while (true)
        { //!IsNull(previous!)
            stack.push(previous);
            try
            {
                previous = previousNodes.find(previous)->second;
                if (previous == NULL) throw exception();
            }
            catch (...) { break; } //previous = previousNodes.GetValueOrDefault(previous, null);
        }
        return toList(stack);
    }
    list<char> toList(stack<sp_Node> &stack) const {   //fix to insert with it
        list<char> sortedList{};
        while (stack.empty()) { sortedList.push_back(stack.top()->label); stack.pop(); }
        return sortedList;
    }
    bool hasCycle(sp_Node node, sp_Node parent, set<sp_Node> visited)
    {
        visited.insert(node);
        for (auto edge : node->edges)
        {
            auto edgeTo = sp_Node(edge->to);
            if (edgeTo == sp_Node(parent)) continue;
            if (visited.contains(edgeTo)
                || hasCycle(edgeTo, node, visited)) return true;
        }
        return false;
    }
    bool containsNode(sp_Node node) { return nodes.contains(node->label); }


public:
    explicit Graph() : nodes{} {}
    ~Graph() { }
    void addNode(char& label)
    {
        auto newNode = make_shared<Node>(label);
        nodes.insert({label, newNode});
    }
    void addEdge(char from, char to, int weight) const
    { // relationship
        if (isNull(nodes.find(from)) || isNull(nodes.find(to))) throw exception();
        auto fromNode = nodes.find(from)->second;
        auto toNode = nodes.find(to)->second;
        fromNode->addEdge(toNode, weight);
        toNode->addEdge(fromNode, weight);
    }
    list<char> getShortestPath(char& from, char& to) const
    {
        if (isNull(nodes.find(from)) || isNull(nodes.find(to))) throw exception();
        auto fromNode = nodes.find(from)->second;
        auto toNode = nodes.find(to)->second;
        map<sp_Node, int> distances{};
        for (auto node: nodes) distances.insert({node.second, INT_MAX});
        distances[fromNode] = 0;//.insert({fromNode, 0}); // java: replace(,) // A 0
        map<sp_Node, sp_Node> previousNodes{};
        set<sp_Node> visited{};
        std::queue<sp_NodePriority> queue{}; //java: PriorityQueue<NodeEntry> queue = new PriorityQueue<>(Comparator.comparingInt(ne->ne.priority));
        queue.push(make_shared<NodePriority>(fromNode, 0)); // only item in the queue
        while (!queue.empty()) {
            auto current = queue.front();
            queue.pop();
            visited.insert(current->node);
            for (auto edge: current->node->edges) {
                auto edgeToNode = sp_Node(edge->to);
                if (visited.contains(edgeToNode)) continue;
                /*!*/   int newDistance = distances.find(current->node)->second + edge->weight;
                if (newDistance < distances.find(edgeToNode)->second)
                {
                    distances[edgeToNode] = newDistance; // java: replace(,)
                    previousNodes.insert({edgeToNode, current->node});
                    queue.push(make_shared<NodePriority>(edgeToNode, newDistance));
                }
            }
        }
        //return distances.get(toNode);
        return buildPath(previousNodes, toNode);
    }
    bool hasCycle()
    {   //לחזור
        set<sp_Node> visited{};
        for(auto node : nodes)
            if (!visited.contains(node.second)
                && hasCycle(node.second, sp_Node(NULL), visited)) return true;
        return false;
    }
    bool containsNode(char label) { return nodes.contains(label); }



    Graph getMinimumSpanningTree()
    {
        Graph tree{};
        if (nodes.empty()) return tree;
        queue<NodePriority> edges{};
//        auto startNode = nodes.First().Value; //java: nodes.values().iterator().next();
//        for (auto edge : startNode.edges) edges.Enqueue(edge, edge.Weight);
//        tree.AddNode(startNode.Label);
//
//        if (edges.Count == 0) return tree;
//
//        while (tree.Nodes.Count < Nodes.Count)
//        {
//            var minEdge = edges.Dequeue();
//            var nextNode = minEdge.To;
//            if (tree.ContainsNode(nextNode.Label)) continue;
//            tree.AddNode(nextNode);
//            tree.AddEdge(minEdge.From, nextNode, minEdge);
//            foreach (var edge in nextNode.EdgeList)
//            if (!tree.ContainsNode(edge.To))
//                edges.Enqueue(edge, edge.Weight);
//        }
        return tree;
    }


    string print() const
    {
        string str = "";
        for (auto node: nodes) {
            auto targets = node.second->edges;// adjacencyList.get(source);
            str += node.second->print() += " is connected to [";
            if (!targets.empty()) for (auto t: targets) str += t->print() += ", ";
            str += "]\n";
        }
        return str;
    }





};
