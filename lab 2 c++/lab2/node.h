#pragma once


class TreeBin;

class Node
{

private:
	int Date;
	Node* left;
	Node* right;
	Node();//конструктор по умолчанию
	Node(int a);//конструктор 
	void Delete();//функци€ вызываема€ в деструкторе дерева
	void Delete2() { delete this; }
	void Print();//внутренн€€ функци€ вывода
	void DFS(int& a);
	void DFS();// вспомогательна€ функци€
	Node operator = (Node& node); //переопределение оператора
	friend TreeBin;//инкапсул€ци€
};