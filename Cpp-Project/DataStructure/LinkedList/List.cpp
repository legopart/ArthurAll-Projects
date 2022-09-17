
#include <iostream>
#include <string>
//move to smart pointer
//move to string_view to print
//fix destructures!     List.root   List.last
//delete in the middle

struct Node
{
    int data;
    Node* next;
    explicit Node(int data) { this->data = data; next = NULL; }
    ~Node() { std::cout << "deleted:" << data << "\n"; }
};

class List
{
private:
    Node* root;
    Node* last;
    int count;
    bool isReversed;
    bool isEmpty() { return root == 0; }
    void resetList() { delete(root); root = NULL; last = NULL; }
public:
    explicit List() {
        root = NULL;
        last = NULL;
        count = 0;
        isReversed = false;
    }
    ~List() { while (root != 0 && !isReversed) { removeLast(); } }
    void insertLast(int data)
    {
        Node* node = new Node(data);
        if (isEmpty()) { root = node; last = node; }
        else { last->next = node; last = node; }
        count++;
    }
    void insertFirst(int data)
    {
        Node* node = new Node(data);
        if (isEmpty()) { root = node; last = node; }
        else { node->next = root; root = node; }
        count++;
    }
    int removeFirst()
    {
        if (isEmpty()) throw 0;
        int value = root->data;
        if (root == last) { resetList(); return value; };
        Node* current = root;
        root = root->next;
        delete(current);
        count--;
        return value;
    }
    int removeLast()
    {
        if (isEmpty()) throw 0;
        int value = last->data;
        if (root == last) { resetList(); return value; };

        Node* current = root->next;
        Node* previous = root;
        while (current->next != 0)
        {
            previous = previous->next;
            current = current->next;
        }
        previous->next = NULL;
        last = previous;
        delete(current);
        count--;
        return value;
    }

    int kth(int subplace) {
        if (isEmpty()) throw 0;
        if (subplace > count || subplace <= 0) throw 0;
        Node* kth = root;
        Node* current = root;
        for (int i = 0; i < subplace - 1; ++i)  current = current->next;
        while (current != last)
        {
            current = current->next;
            kth = kth->next;
        }
        return kth->data;
    }

    void reverse() {
        if (isEmpty()) return;
        List* newList = new List();
        //List* newList = &list;
        Node* current = root;
        while (current != 0)
        {
            newList->insertFirst(current->data);
            current = current->next;
        }
        this->root = newList->root;
        this->last = newList->last;
        newList->isReversed = true;
        delete(newList);
    }


    std::string print()
    {
        Node* current = root;
        std::string str{};
        while (current != 0)
        {
            str += std::to_string(current->data) + ", ";
            current = current->next;
        }
        str += "\n";
        return str;
    }

};