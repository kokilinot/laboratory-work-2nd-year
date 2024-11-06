#pragma once
#include "node.h"
#include <iostream>

Node::Node()
{
	this->Date = NULL;
	this->left = NULL;
	this->right = NULL;
}

Node::Node(int a)
{
	this->Date = a;
	this->left = NULL;
	this->right = NULL;
}

void Node::Delete()
{
	if (left != NULL)
		left->Delete();
	if (right != NULL)
		right->Delete();
	delete this;
}

void Node::Print()
{
	if (left != NULL)
		left->Print();

	std::cout << Date << "\n";

	if (right != NULL)
		right->Print();
}

void Node::DFS()
{
	if (left != NULL)
		left->DFS();
	if (right != NULL)
		right->DFS();
	std::cout << Date << "  ";
}

void Node::DFS(int &a)
{
	if (this->left != NULL)
	{
		a++;
		left->DFS(a);
	}
	if (this -> right != NULL)
	{
		a++;
		right->DFS(a);
	}
}

Node Node::operator = (Node& node) //переопределение оператора
{
	this->Date = node.Date;
	this->left = node.left;
	this->right = node.right;
	return *this;
}