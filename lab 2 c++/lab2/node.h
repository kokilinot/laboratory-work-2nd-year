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
	void Print();//���������� ������� ������
	void DFS();// ��������������� �������
	Node operator = (Node& node); //��������������� ���������
	friend TreeBin;//������������
};