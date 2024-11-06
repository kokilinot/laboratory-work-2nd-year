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

void TreeBin::count(Node* Deletetempl, Node* templ)
{
	int a = 0;
	int b = 0;
	Deletetempl->left->DFS(a); // считаем сколько элементов в левом поддереве
	Deletetempl->right->DFS(b); // считаем сколько элементов в правом поддереве
	if (a > b )// если количество элементов в левом поддереве больше чем в правом то заменять будем на элемент из правого поддерева
	{
		if (a != 0)// если это не лист дерева то ищем замену на место заменяемого элемента
		{
			count(templ, templ->left);
		}
		else// если лист
		{
		Deletetempl->left->right = Deletetempl->right;
			if (templ->right == Deletetempl)
			{
				templ->right = Deletetempl->left;
			}
			else
			{
				templ->left = Deletetempl->left;
			}
		}
	}
	if (b >= a)
	{
		if (b != 0)
		{
			count(templ, templ->right);
		}
		else
		{
			Deletetempl->right->left = Deletetempl->left;
			if (templ->right == Deletetempl)
			{
				templ->right = Deletetempl->right;
			}
			else
			{
				templ->left = Deletetempl->right;
			}
		}
	}
	Deletetempl->Delete2();
}

void TreeBin::Delete(int a, Node* temp)
{
	if (temp == NULL)//проверка на то существует ли голова
	{
		std::cout << "elements do not exist\n";
		return;
	}
	if (temp->Date < a)// сравниваем с а если а больше, то начинаем проверку правого поддерева
	{
		if (temp->right != NULL) // проверяем существует ли правое поддерево если не существуе значит а не неайдено в дереве
		{
			if (temp->right->Date == a) // если правое поддерево начинается с листа у которого значение равняется а то вызываем удаление 
			{
				count(temp->right, temp);
			}
			else
			{
				Delete(a, temp->right);// иначе рекурсивно вызываем эту же функцию для правого поддерева
			}
		}
		else
		{
			std::cout << "element does not exist\n";
			return;
		}
	} 
	if(temp->Date > a)// аналагично для левого поддерева
	{
		if (temp->left != NULL)
		{
			if (temp->left->Date == a)
			{
				count(temp->left, temp);
			}
			else
			{
				Delete(a, temp->left);
			}

		}
		else
		{
			std::cout << "element does not exist\n";
			return;
		}
	}
}



