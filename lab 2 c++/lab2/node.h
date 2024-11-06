#pragma once
#include <queue>
class TreeBin;

class Node
{

private:
	int Date;
	Node* left;
	Node* right;
	Node()
	{
		this->Date = NULL;
		this->left = NULL;
		this->right = NULL;
	}
	Node(int a)
	{
		this->Date = a;
		this->left = NULL;
		this->right = NULL;
	}
	void Delete()
	{
		if (left != NULL)
			left->Delete();
		if (right != NULL)
			right->Delete();
		delete this;
	}
	void Print()
	{
		if (left != NULL)
			left->Print();

		std::cout << Date << "\n";

		if (right != NULL)
			right->Print();
	}
	void DFS()
	{
		if (left != NULL)
			left->DFS();
		if (right != NULL)
			right->DFS();
		std::cout << Date << "  ";
	}
	Node operator = (Node& node)
	{
		this->Date = node.Date;
		this->left = node.left;
		this->right = node.right;
	}
	friend TreeBin;
};