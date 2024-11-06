#pragma once
#include "node.h"


class TreeBin
{
private:
	Node* head;


	void PuchHelperFunction(Node* header, Node* elem);
public:
	TreeBin(int a);//конструктор дерева
	~TreeBin(){head->Delete();}//деструктор дерева
	void Puch(int a); // добавленние элемента в дерево
	void Print(){head->Print();} // вывод дерева как осортированный массив
	void BFS(); //обход в ширину
	void DFS() { head->DFS();  } // обход в глубину
};