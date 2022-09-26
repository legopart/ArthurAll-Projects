

#include <iostream>
#include <list>
#include "Tree.cpp"
using  std::cout;
int main() {
    cout << "AVLTree\n";

    Tree tree{};
    tree.insert(30);
    tree.insert(20);
    tree.insert(10);
    tree.insert(9);
    tree.insert(8);
    tree.insert(7);
    tree.insert(40);
    tree.insert(6);
    tree.insert(5);
    tree.insert(4);
    cout << tree.print() << "\n";
    return EXIT_SUCCESS;
}