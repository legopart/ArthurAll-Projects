

#include <iostream>
#include <list>
#include "Tree.cpp"
using  std::cout;
int main() {
    cout << "BinaryTree\n";
    Tree tree{};
    tree.insert(5);
    tree.insert(10);
    tree.insert(20);
    tree.insert(2);

    Tree tree2{};
    tree2.insert(5);
    tree2.insert(10);
    tree2.insert(20);
    tree2.insert(435643);

    cout << "height: " << tree.height() << "\n";
    cout << "min tree: "  << tree.min() << "\n";
    cout << "min binary tree: " <<tree.min_binarySearchTree() << "\n";
    cout << "equals: " << tree.equals(&tree2) << "\n";
    for(auto data: tree.getNodesAtDistance(1)) cout << data << ", ";
    cout << "\n\n";
    tree.traverseLevelOrder();
    cout << "print: " << tree.print() << "\n";
    cout << "\nend\n";

    return 0;
}