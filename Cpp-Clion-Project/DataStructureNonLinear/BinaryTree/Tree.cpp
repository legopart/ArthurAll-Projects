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
    bool isNull(const Node *node){  return node == NULL; }
    bool isLeaf(const Node *node) { return isNull(node->left) && isNull(node->right) ; }
    int height(const Node *node)
    {
        if(isNull(node)) return -1; //INT_MIN
        if(isLeaf(node)) return 0;
        return 1 + std::max(height(node->left), height(node->right));
    }
    int min(const Node *node)
    {
        if(isNull(node)) return INT_MAX;
        if(isLeaf(node)) return node->data;
        auto left = min(node->left);
        auto right = min(node->right);
        return std::min(std::min(left, right), node->data);
    }
    bool equals(Node *a, Node *b)
    {
        if(isNull(a) && isNull(b)) return true;
        if(!isNull(a) && !isNull(b))
            return
                a->data == b->data
                && equals(a->left, b->left)
                && equals(a->right, b->right);
        return false;
    }
    bool isBinarySearchTree(Node *node, int min, int max)
    {
        if (isNull(node)) return true;
        if ( !(node->data >= min && node->data <= max) ) return false;
        return
            isBinarySearchTree(node->left, min, node->data)
            && isBinarySearchTree(node->right, node->data, max);
    }
    void getNodesAtDistance(Node *node, int distance, std::list<int> *list)
    {
        if (isNull(node)) return;
        if (distance == 0) { list->push_back(node->data); /*System.out.print( node.value + " " );*/ return; }
        getNodesAtDistance(node->left, distance - 1, list);
        getNodesAtDistance(node->right, distance - 1, list);
    }
public:
    explicit Tree() : root(NULL) { }
    ~Tree(){ /*delete(root);*/ }
    void insert(int data)
    {
        Node* node = new Node( data );
        if(isNull(root)) root = node;
        auto* current = root;
        while(1)
        {
            if(data < current->data)
            {
                if(isNull(current->left)){ current->left = node; break; }
                current = current->left;
            }
            else if (data > current->data)
            {
                if(isNull(current->right)){ current->right = node; break; }
                current = current->right;
            }
            else /*==*/ break;
        }
    }
    bool find(int data)
    {
        auto* current = root;
        while(!isNull(current))
        {
            if(data == current->data) return true;
            current = data < current->data ? current->left : current->right;
        }
        return false;
    }
    int height(){ return height(root); }
    int min(){ return min(root); }
    int min_binarySearchTree()
    {
        if(isNull(root)) throw 0;
        auto* current = root;
        while(!isNull(current->left)) current = current->left;
        int data = current->data;
        return data;
    }

    bool equals(const Tree *other)
    {
        if(other == NULL) return false;
        return equals(root, other->root);
    }
    bool isBinarySearchTree() { return isBinarySearchTree(root, INT_MIN, INT_MAX); }
    void swapRoot(){ auto* temp = root->left; root->left= root->right; root->right = temp; }
    std::list<int> getNodesAtDistance(int distance)
    {
        std::list<int> list{};
        getNodesAtDistance(root, distance, &list); /*Console.WriteLine("");*/
        return list;
    }
    void traverseLevelOrder()
    {
        for (int i{}; i <= height(); ++i)
        {
            auto list = getNodesAtDistance(i);
            std::cout << i << "| ";
            for(auto data: list) std::cout << data << ", ";
            std::cout << "\n";
        }
    };

    /*1*/
    /*2*/
    /*3*/


};