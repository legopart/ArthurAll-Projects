//fix the issue with too much destructures

#include <iostream>


#include "Trie.cpp"
#include "TrieC.c"
using  std::cout;
int main() {

    cout << "TrieTree\n";   //retrieval
    {
        Trie trie{};
        trie.insert("cat");
        trie.insert("can");
        trie.insert("cant");
        trie.insert("cada");
        trie.remove("cada");
        cout << "\n" << trie.print() + "\n";
        cout << trie.contains("cat") << "\n";
        cout << trie.contains("caty") << "\n";
        //trie.traversePostOrder();
        auto x = trie.root;
        cout << "";
    }

    printf("\n\n");
    printf("Trie Tree C:\n");
    struct node *root = NULL;
    insert(&root, "KIT");
    insert(&root, "KITTTE");
    insert(&root, "CATTLE");
    insert(&root, "KIR");
    insert(&root, "KIAR");
    print(root);


    return EXIT_SUCCESS;
}