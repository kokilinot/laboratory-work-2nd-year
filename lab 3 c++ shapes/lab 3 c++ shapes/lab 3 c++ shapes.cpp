

#include <iostream>

void Print1()
{
	std::cout << "choice shapes: \n 1 - trinagle \n 2 - Circle \n 3 - Rectangle \n 0 - exit \n";
}

void Print2()
{
	std::cout << " 1 - Shift \n 2 - scale \n 3 - GetCoordinates \n 4 - GetSides \n";
}

class Shapes
{
public:
	virtual void Shift(int deltaX, int deltaY)  = 0;
	virtual void Scale(int coefficient)  = 0;
	virtual void Getcoordinates() = 0;
	virtual void GetSides() = 0;
};

class triangle : public Shapes
{
private:
	int x;
	int y;
	int side_a;
	int side_b;
	int side_c;
public:
	triangle()
	{
		x = 0;
		y = 0;
		side_a = 2;
		side_b = 3;
		side_c = 4;
	}
	triangle(int x1, int y1, int side_a1, int side_b1, int side_c1)
	{
		x = x1;
		y = y1;
		side_a = side_a1;
		side_b = side_b1;
		side_c = side_c1;
	}
	void Shift(int deltaX, int deltaY) override
	{
		x = x + deltaX;
		y = y + deltaY;
	}
	void Scale(int coefficient) override
	{
		side_a = side_a * coefficient;
		side_b = side_b * coefficient;
		side_c = side_c * coefficient;
	}
	void Getcoordinates()
	{
		std::cout << "coordinates X = " << x << "\n";
		std::cout << "coordinates Y = " << y << "\n";
	}
	void GetSides()
	{
		std::cout << "side a = " << side_a << "\n";
		std::cout << "side b = " << side_b << "\n";
		std::cout << "side c = " << side_c << "\n";
	}
};

class Circle : public Shapes
{
private:
	int x;
	int y;
	int radius;
public:
	Circle()
	{
		x = 0;
		y = 0;
		radius = 1;
	}
	Circle(int X1, int Y1, int radius1)
	{
		x = X1;
		y = Y1;
		radius = radius1;
	}
	void Shift(int deltaX, int deltaY) override
	{
		x = x + deltaX;
		y = y + deltaY;
	}
	void Scale(int coefficient) override
	{
		radius = radius * coefficient;
	}
	void Getcoordinates()
	{
		std::cout << "coordinates X = " << x << "\n";
		std::cout << "coordinates Y = " << y << "\n";
	}
	void GetSides()
	{
		std::cout << "radius = " << radius << "\n";
	}
};

class Rectangle : public Shapes
{
private:
	int x;
	int y;
	int height;
	int weight;
public:
	Rectangle()
	{
		x = 0;
		y = 0;
		height = 1;
		weight = 2;
	}
	Rectangle(int x1, int y1, int height1, int weight1)
	{
		x = x1;
		y = y1;
		height = height1;
		weight = weight1;
	}
	void Shift(int deltaX, int deltaY) override
	{
		x = x + deltaX;
		y = y + deltaY;
	}
	void Scale(int coefficient) override
	{
		height = height * coefficient;
		weight = weight * coefficient;
	}
	void Getcoordinates()
	{
		std::cout << "coordinates X = " << x << "\n";
		std::cout << "coordinates Y = " << y << "\n";
	}
	void GetSides()
	{
		std::cout << "height = " << height << " \n";
		std::cout << "weight = " << weight << " \n";
	}
};

int main()
{
	int i = 9;
	int k = 9;
	triangle a;
	Circle b;
	Rectangle c;
	Shapes* shapes[3] = { &a, &b, &c };

	while (true)
	{
		Print1();
		std::cin >> i;
		if (i != 0)
		{
			i--;
			Print2();
			std::cin >> k;
			switch (k)
			{
			case 1:
			{
				std::cout << "Shift coefficent : \n";
				std::cin >> k;
				std::cout << "Shift coefficent : \n";
				int a;
				std::cin >> a;
				shapes[i]->Shift(k, a);
				shapes[i]->Getcoordinates();
				shapes[i]->GetSides();
				break;
			}
			case 2:
			{
				std::cout << "Scale coefficent : \n";
				std::cin >> k;
				shapes[i]->Scale(k);
				shapes[i]->Getcoordinates();
				shapes[i]->GetSides();
				break;
			}
			case 3:
			{
				shapes[i]->Getcoordinates();
				break;
			}
			case 4:
			{
				shapes[i]->GetSides();
				break;
			}
			default:
				break;
			}
		}
		else
		{
			break;
		}
		i = 9;
	}
}

