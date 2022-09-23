//fix the issue with too much destructures

#include <iostream>
#include "Graph.cpp"
using  std::cout;
int main() {

    cout << "Graph\n";   //retrieval

    Graph graph{};
    graph.addNode('a');


    cout << "asfasfas";

    graph.addNode('b');

    graph.addNode('c');
    graph.removeNode('b');
    graph.addNode('d');
    cout << "\n";

    graph.addNode('e');
    cout << "\n";



    return 0;
}