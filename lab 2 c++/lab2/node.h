#pragma once


class TreeBin;

class Node
{

private:
	int Date;
	Node* left;
	Node* right;
	Node();//����������� �� ���������
	Node(int a);//����������� 
	void Delete();//������� ���������� � ����������� ������
	void Delete2() { delete this; }
	void Print();//���������� ������� ������
	void DFS(int& a);
	void DFS();// ��������������� �������
	Node operator = (Node& node); //��������������� ���������
	friend TreeBin;//������������
};