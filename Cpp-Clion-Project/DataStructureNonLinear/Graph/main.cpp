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

    graph.addNode('d');
    graph.addNode('e');
    cout << "\n";

    graph.addEdge('a', 'b');
    graph.addEdge('b', 'c');
    graph.addEdge('a', 'd');
    graph.addEdge('c', 'a');
    cout << graph.hasCycle() << "\n";



    cout << graph.print() << "\n";
    graph.removeNode('b');
    cout << "\n";
    cout << graph.print() << "\n";
    return 0;
}