#pragma once
#include "node.h"


class TreeBin
{
private:
	void count(Node* Deletetempl, Node* templ);
	void PuchHelperFunction(Node* header, Node* elem);
public:
	Node* head;
	TreeBin(int a);
	~TreeBin(){head->Delete();}
	void Puch(int a);
	void Print(){head->Print();}
	void BFS();
	void DFS() { head->DFS();  }
	void Delete(int a, Node* temp);//удаление листа
	Node* search(int a, Node* temp);
};