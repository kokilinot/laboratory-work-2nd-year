#include <iostream>

#include "treeBin.h"



void Printik()
{
	std::cout << " 1 - Puch\n 2 - print\n 3 - exit\n 4 - BFS\n 5 - DFS\n";
}

int main()
{
	int a;
	int b;
	std::cout << "print root tree\n";
	std::cin >> a;
	TreeBin Treex(a);
	while (true)
	{
		Printik();
		std::cin >> a;
		switch (a)
		{
		case 1:
			std::cout << "print number\n";
			std::cin >> b;
			Treex.Puch(b);
			break;
		case 2:
			Treex.Print();
			break;
		case 3:
			break;
		case 4:
			Treex.BFS();
			break;
		case 5:
			Treex.DFS();
			break;
		default:
			std::cout << "there is no such point\n";
			break;
		}
		if (a == 3)
			break;
	}
}

