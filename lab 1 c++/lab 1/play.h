#pragma once

#include <iostream>
#include <stdlib.h>

class Play
{
private:
	int pole[3][3];
	bool zna4;
public:
	Play();//конструктор по умолчанию

	bool Exam(int a, int b);//проверка на выход за пределы массива и на занятось

	bool ExamForWin();//проверка для победы

	void Moove(int a, int b);//заполнение блока

	void Print();

};