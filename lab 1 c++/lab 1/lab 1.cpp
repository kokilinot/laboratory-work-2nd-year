#include "play.h"

Play::Play()//конструктор по умолчанию
{

	zna4 = true;
	for (int i = 0; i < 3; i++)
	{
		for (int j = 0; j < 3; j++)
		{
			pole[i][j] = 2;
		}
	}
	std::cout << "space creat\n";
}

bool Play::ExamForWin()//проверка для победы
{
	for (int i = 0; i < 3; i++)
	{
		if (((pole[i][0] == pole[i][1] && pole[i][0] == pole[i][2]) || ((pole[0][i] == pole[1][i])) && (pole[0][i] == pole[2][i])) && pole[i][i] != 2)
		{
			this->Print();
			std::cout << "win players" << pole[i][i];
			return true;
		}
	}
	if (((pole[0][0] == pole[1][1] && pole[0][0] == pole[2][2]) || (pole[0][2] == pole[1][1] && pole[0][2] == pole[2][0])) && (pole[1][1]) != 2)
	{
		this->Print();
		std::cout << "win players " << pole[1][1];
		return true;
	}
	for (int i = 0; i <3 ; i++)//проверка на ничью
	{
		for (int j = 0; j < 3; j++)
		{
			if (pole[i][j] == 2)
				return false;
		}
	}
	Print();
	std::cout << "draw\n";
	return true;
}

void Play::Moove(int a, int b)//заполнение блока
{
	if (Exam(a, b))
	{
		pole[a][b] = zna4;
		zna4 = !zna4; // смена хода;
	}
	else
	{
		std::cout << "enter value\n\n";
		std::cin >> a >> b;
		Moove(a - 1, b - 1);
	}
}

bool Play::Exam(int a, int b)//проверка на выход за пределы массива и на занятось
{
	system("cls");
	this->Print();
	if (a > 3 || b > 3)
	{
		std::cout << "going beyond\n";
		return false;
	}
	if (pole[a][b] != 2)
	{
		std::cout << "busy\n";
		return false;
	}
	return true;
}

void Play::Print()
{
	std::cout << "space\n";
	for (int i = 0; i < 3; i++)
	{
		for (int j = 0; j < 3; j++)
		{
			if (pole[i][j] == 0)
				std::cout << "0  ";
			else if (pole[i][j] == 1)
				std::cout << "X  ";
			else
				std::cout << "   ";
			if (j != 2)
				std::cout << "|  ";
		}
		if (i != 2)
			std::cout << "\n_____________\n";
	}
	std::cout << "\n\n";
}


int main()
{
	int a;
	int b;
	Play space;
	while (true)
	{
		space.Print();
		std::cout << "enter value\n\n";
		std::cin >> a >> b;
		space.Moove(a - 1, b - 1);
		if (space.ExamForWin())
		{
			break;
		}
		system("cls");
	}
	return 1;
}

