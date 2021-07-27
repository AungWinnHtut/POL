#include<iostream>
using namespace std;

class Circle {
private:
	float r;
	float a;
public:
	float area()
	{
		a = 3.14 * r * r;
		return a;
	}
	void setR(float rr)
	{
		r = rr;
	}
	float getA()
	{
		return a;
	}

};

int main()
{
	Circle c;
	c.setR(22.3);
	c.area();
	cout << c.getA();

}