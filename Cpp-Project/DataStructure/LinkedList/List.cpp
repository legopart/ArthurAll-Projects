
#include <iostream>


class Node
{
public:
	int data{};
	Node* next{ nullptr };
	Node(int data)
	{
		this->data = data;
		next = nullptr;
	}
};

class List 
{
private:
	Node* root{ nullptr };
	Node* last{ nullptr };
	int count{};
public:
	List() { 
		root = nullptr;
		last = nullptr;
		count = 0;
	}
	void insert(int data) 
	{
		Node node{ data };
		if (root != nullptr) {}
		else{ root = &node; last = root; }
		//else { last->next = &node; last = last->next; }
		
	}
	void print()
	{
		Node* corrent = root;
		while (corrent != nullptr)
		{
			std::cout << "aaaaaaaaaaa " << corrent->data << "\n";
			corrent = corrent->next;
		}

	}



};