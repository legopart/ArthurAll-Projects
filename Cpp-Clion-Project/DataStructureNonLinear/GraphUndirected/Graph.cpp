
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
        struct Edge {
            typedef shared_ptr<struct Node> p_Node;
            int weight;
            Node* from;
            p_Node to;
            explicit Edge(Node* from, p_Node to, int weight) : from{from}, to{to}, weight{weight} {   }
            ~Edge(){cout << "del:" << from->label << ">" << to->label << "(" << weight << ") ";}
            //bool operator<(const struct Node& other) const { return this->label < other.label; }
            string print() const {return "<" + to_string(weight) + ">" + to->print();}
        };
        typedef shared_ptr<struct Node> p_Node;
        typedef shared_ptr<struct Edge> p_Edge;
        char label;
        list<Edge*> edges; /*!*/
        explicit Node(char& label) : label{label}, edges{} {   }
        ~Node(){cout << "del:" << label << " ";}
        //bool operator<(const struct Node& other) const { return this->label < other.label; }
        int a = 5;
        void addEdge(p_Node to, int weight) /*!*/
        {
            auto thisNode = this;
            auto newEdge =  Edge(thisNode, to, weight);
            edges.push_back(&newEdge);
        }
        char print() const { return label; }
    };
    struct NodePriority
    {
        typedef shared_ptr<struct Node> p_Node;
        p_Node node;
        int priority;
        explicit  NodePriority(p_Node node, int priority) : node{node}, priority{priority} { }
        ~NodePriority(){cout << "del_priority:" << "" + node->label;}
        /*!*/ bool operator<(const struct NodePriority& other) const { return this->priority < other.priority; } /*!*/
    };

    typedef shared_ptr<struct Node> p_Node;
    typedef shared_ptr<struct Node::Edge> p_Edge;
    typedef std::_Rb_tree_iterator<pair<const char, p_Node>> it_Node;

    map<char, p_Node> nodes;

    bool isNull(it_Node itNode) { return itNode == nodes.end();}
    void addNode(p_Node node) { addNode(node->label); }
    void addEdge(p_Node from, p_Node to, p_Edge edge) { addEdge(from->label, to->label, edge->weight); }

    list<char> buildPath(map<p_Node, p_Node> previousNodes, p_Node toNode)
    {
        stack<p_Node> stack{};
        stack.push(toNode);
        auto previous = previousNodes.find(toNode)->second;
        while (true) //!IsNull(previous!)
        {
            stack.push(previous);
            try {
                previous = previousNodes.find(previous)->second;
                if(previous == NULL) throw exception();
            }
            catch (...) { break; } //previous = previousNodes.GetValueOrDefault(previous, null);
        }
        return toList(stack);
    }
    list<char> toList(stack<p_Node>& stack) {   //fix to insert with it
        list<char> sortedList{};
        while (stack.empty()) {sortedList.push_back(stack.top()->label); stack.pop();}
        return sortedList;
    }
public:
    explicit Graph() : nodes{} {}
    ~Graph() {cout << "graph end";}
    void addNode(char label)
    {
        auto newNode = make_shared<Node>(label);
        nodes.insert({label, newNode});
    }
    void addEdge(char from, char to, int weight)
    { // relationship
        if(isNull(nodes.find(from)) || isNull(nodes.find(to))) throw exception();
        auto fromNode =nodes.find(from)->second;
        auto toNode = nodes.find(to)->second;
        fromNode->addEdge(toNode, weight);
        toNode->addEdge(fromNode, weight);
    }

    typedef shared_ptr<struct NodePriority> p_NodePriority;

    list<char> getShortestPath(char from, char to)
    {
        if (isNull(nodes.find(from)) || isNull(nodes.find(to))) throw exception();
        auto fromNode = nodes.find(from)->second;
        auto toNode = nodes.find(to)->second;
        map<p_Node, int> distances{};
        for (auto node : nodes) distances.insert({node.second, INT_MAX});
        distances[fromNode] = 0;//.insert({fromNode, 0}); // java: replace(,) // A 0
        map<p_Node, p_Node> previousNodes{};
        set<p_Node> visited{};
        std::queue<p_NodePriority> queue{}; //java: PriorityQueue<NodeEntry> queue = new PriorityQueue<>(Comparator.comparingInt(ne->ne.priority));
        queue.push(make_shared<NodePriority>(fromNode, 0)); // only item in the queue

        while (!queue.empty())
        {
            auto current = queue.front();
            queue.pop();
            visited.insert(current->node);

            for (auto edge : current->node->edges)
            {
                if (visited.contains(edge->to)) continue;
                /*!*/   int newDistance = distances.find(current->node)->second + edge->weight;
                if (newDistance < distances.find(edge->to)->second)
                {
                    distances[edge->to] = newDistance; // java: replace(,)
                    previousNodes.insert({edge->to, current->node});
                    queue.push(make_shared<NodePriority>(edge->to, newDistance));
                }
            }
        }
        //return distances.get(toNode);
        return buildPath(previousNodes, toNode);
    }



    string print()
    {
        string str = "";
        for (auto node : nodes)
        {
            auto targets = node.second->edges;// adjecencyList.get(source);
            if (!targets.empty())
                str += (char)node.second->print();
                str += " is connected to [";
                for(auto t: targets){
                    str += t->print();
                    str += ",";
                }
                str += "]\n";
        }
        return str;
    }

};