#include <iostream>
#include <string>
#include <list>
#include <cmath>
using std::string, std::to_string, std::cout, std::max;
class Tree {
private:
    struct Node {
        int data;
        int height;
        struct Node *left;
        struct Node *right;
        explicit Node(int data) : data{data}, left{NULL}, right{NULL}, height{} {}
        ~Node() { if(left != 0) delete(left);if(right != 0) delete(right); cout << "del:" << data << "\n"; }
    };

    struct Node *root;
    bool isNull(const Node *node) { return node == NULL; }
    bool isLeaf(const Node *node) { return isNull(node->left) && isNull(node->right) ; }
    int getHeight(Node *node) { return isNull(node) ? -1 : node->height; }
    int getMaxHeight(Node *node) { return 1 + std::max(getHeight(node->left), getHeight(node->right)); }
    int balanceFactor(Node *node) { return isNull(node) ? 0 : getHeight(node->left) - getHeight(node->right); }

    Node* insert(int value, Node* node, Node* newNode)
    {
        if (isNull(node)) node = newNode;
        else if (value < node->data) node->left =  insert(value, node->left, newNode);
        else if (value > node->data) node->right =  insert(value, node->right, newNode);
        else throw 0;
        node->height = getMaxHeight(node); // for balancing

        return balance(node); //node;
    }

    Node* balance(Node *node)
    {
        if (balanceFactor(node) > 1)    // RR
        {
            if (balanceFactor(node->left) < 0) /*LR*/ { node->left = rotateLeft(node);}
            return rotateRight(node);   /*RR*/
        }
        else if (balanceFactor(node) < -1) //LL
        {
            if (balanceFactor(node->right) > 0) /*RL*/ { node->right = rotateRight(node);}
            return rotateLeft(node);    /*LL*/
        }
        else return node;   // balance ok -1 <=> 1
    }
    Node* rotateLeft(Node* node)
    {   //maybe new root
        auto* topNode = node->right;
        node->right = topNode->left;
        topNode->left = node;
        node->height = getMaxHeight(node);
        topNode->height = getMaxHeight(topNode);
        return topNode;
        // 10		  20
        //  20	=>	10  30
        //   30
    }
    Node* rotateRight(Node* node)
    {   //maybe new root
        auto* topNode = node->left;
        node->left = topNode->right; // node.ChildLeft.ChildRight;
        topNode->right = node;
        node->height = getMaxHeight(node);
        topNode->height = getMaxHeight(topNode);
        return topNode;
        //   30		  20
        //  20	=>	10  30
        // 10
    }
    int height(Node *node)
    {
        if (isNull(node)) return INT_MIN;//-1;
        if (isLeaf(node)) return 0; // base condition
        return 1 + std::max(height(node->left), height(node->right));
    }
    void getNodesAtDistance(Node* node, int distance, std::list<int>* list)
    {
        if (isNull(node)) return;
        if (distance == 0) { list->push_back(node->data); return; }
        getNodesAtDistance(node->left, distance - 1, list);
        getNodesAtDistance(node->right, distance - 1, list);
    }
    bool isPerfect(Node* node)
    {
        if (isNull(node)) return true;
        if (isNull(node->left) && !isNull(node->right) || !isNull(node->right) && isNull(node->left)) return false;
        return isPerfect(node->left) && isPerfect(node->right);
    }
public:
    explicit Tree() : root(NULL) { }
    ~Tree(){ /*delete(root);*/ }
    void insert(int data)
    {
        Node* node = new Node( data );
        if(isNull(root)) {root = node; return;}
        root = insert(data, root, node);
    }
    int height() { return height(root); }

    std::list<int> getNodesAtDistance(int distance)
    {
        std::list<int> list{};
        getNodesAtDistance(root, distance, &list);
        return list;
    }
    string traverseLevelOrder() {
        string str{};
        for (int i{}; i <= height(); i++) {
            str += std::to_string(i) + "| ";
            for (auto data: getNodesAtDistance(i))
                str += std::to_string(data) + ", ";
            str += "\n";
        }
        return str;
    }
    string print() {  return traverseLevelOrder(); }
    /*1*/
    bool isBalanced() { return std::abs(balanceFactor(root)) <= 1 ; }
    /*2*/
    bool isPerfect() { return isPerfect(root); }
};