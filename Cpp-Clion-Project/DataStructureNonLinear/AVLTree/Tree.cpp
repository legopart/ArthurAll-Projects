#include <iostream>
#include <string>
#include <list>
using std::string, std::to_string, std::cout, std::max;
class Tree {
private:
    struct Node {
        int data;
        struct Node *left;
        struct Node *right;

        explicit Node(int data) : data(data), left(NULL), right(NULL) {}

        ~Node() { cout << "deleted:" << data << "\n"; }
    };

    struct Node *root;

    bool isNull(const Node *node) { return node == NULL; }
public:
    explicit Tree() : root(NULL) { }
    ~Tree(){ /*delete(root);*/ }
};