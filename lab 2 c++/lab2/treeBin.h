#pragma once
#include "node.h"


class TreeBin
{
private:
	Node* head;


	void PuchHelperFunction(Node* header, Node* elem);
public:
	TreeBin(int a);
	~TreeBin(){head->Delete();}
	void Puch(int a);
	void Print(){head->Print();}
	void BFS();
	void DFS() { head->DFS();  }
};