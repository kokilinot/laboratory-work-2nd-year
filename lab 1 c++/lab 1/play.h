#pragma once

#include <iostream>
#include <stdlib.h>

class Play
{
private:
	int pole[3][3];
	bool zna4;
public:
	Play();//����������� �� ���������

	bool Exam(int a, int b);//�������� �� ����� �� ������� ������� � �� ��������

	bool ExamForWin();//�������� ��� ������

	void Moove(int a, int b);//���������� �����

	void Print();

};