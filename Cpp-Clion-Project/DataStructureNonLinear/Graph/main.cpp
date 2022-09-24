//fix the issue with too much destructures

#include <iostream>
#include "Graph.cpp"
using  std::cout;
int main() {

    cout << "Graph\n";   //retrieval

    Graph graph{};
    graph.addNode('a');
    graph.addNode('b');
    graph.addNode('c');
    graph.removeNode('b');
    graph.addNode('d');
    graph.addNode('e');
    cout << "\n";



    return 0;
}