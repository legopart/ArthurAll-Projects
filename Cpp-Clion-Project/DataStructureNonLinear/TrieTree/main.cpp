
#include <iostream>

#include "Trie.cpp"

using  std::cout;
int main() {
    cout << "TrieTree\n";
    Trie trie{};
    trie.insert("cat");
    trie.insert("can");
    trie.insert("cant");
    trie.insert("cada");
    cout << "\n" << trie.print() + "\n";
    cout << trie.contains("cat") << "\n";
    cout << trie.contains("caty") << "\n";
    trie.traversePostOrder();
    cout << "\n\n\n";
    auto x = trie.root;
    cout << "";
}