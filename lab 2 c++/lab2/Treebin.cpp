#pragma once
#include "treeBin.h"
#include <iostream>
#include <queue>

TreeBin::TreeBin(int a)
{
	Node* node = new Node(a);
	this->head = node;
}

void TreeBin::Puch(int a)
{
	Node* NewElem = new Node(a);
	PuchHelperFunction(head, NewElem);
}

void TreeBin::BFS()
{
	std::queue<Node*> q;
	Node* temp = new Node();
	q.push(this->head);
	while (!q.empty())
	{
		temp = q.front();
		std::cout << temp->Date << "  ";
		q.pop();
		if (temp->left != NULL)
		{
			q.push(temp->left);
		}
		if (temp->right != NULL)
		{
			q.push(temp->right);
		}
	}
	std::cout << std::endl;

}

void TreeBin::PuchHelperFunction(Node* header, Node* elem)
{
	if (header->Date == elem->Date)
	{
		std::cout << "action imposible\n";
	}
	else if (header->Date > elem->Date)
	{
		//переходим в левую ветку
		if (header->left == NULL)
		{
			//вставляем элемент
			header->left = elem;
		}
		else
		{
			PuchHelperFunction(header->left, elem);
		}
	}
	else
	{
		//переходим в правую ветку
		if (header->right == NULL)
		{
			header->right = elem;
		}
		else
		{
			PuchHelperFunction(header->right, elem);
		}
	}
}



