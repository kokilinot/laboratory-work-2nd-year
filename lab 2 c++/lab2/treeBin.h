#pragma once

#include <iostream>
#include "node.h"
#include <queue>

class TreeBin
{
private:
	Node* head;


	void PuchHelperFunction(Node* header, Node* elem)
	{
		if(header->Date == elem->Date )
		{
			std::cout << "action imposible\n";
		}
		else if (header->Date > elem ->Date)
		{
			//��������� � ����� �����
			if (header->left == NULL)
			{
				//��������� �������
				header->left = elem;
			}
			else
			{
				PuchHelperFunction(header->left, elem);
			}
		}
		else
		{
			//��������� � ������ �����
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
public:
	TreeBin(int a)
	{
		Node* node = new Node(a);
		this->head = node;
	}
	~TreeBin()
	{
		head->Delete();
	}
	void Puch(int a)
	{
		Node* NewElem = new Node(a);
		PuchHelperFunction(head, NewElem);
	}
	void Print()
	{
		head->Print();
	}
	// ����� � �������
	void BFS()
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
	// ����� � �������
	void DFS()
	{
		head->DFS();
	}
};