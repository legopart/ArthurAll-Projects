//fix the issue with too much destructures

#include <iostream>
#include "Graph.cpp"
using  std::cout;
int main() {

    cout << "Graph\n";   //retrieval
    {
        Graph graph{};
        graph.addNode('a');
        graph.addNode('b');
        graph.addNode('c');
        graph.addEdge('a', 'b', 3);
         graph.addEdge('a', 'c', 6);

        cout << graph.print() << "\n";
    }

    return EXIT_SUCCESS;
}