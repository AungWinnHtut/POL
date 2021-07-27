#include<iostream>
using namespace std;

class Car {
	public:
		int number_of_wheel;
		int color;
};

int main()
{
	Car jeep, honda;
	jeep.color = 0;
	jeep.number_of_wheel = 4;
	cout << jeep.color << endl;
}