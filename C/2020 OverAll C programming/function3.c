#include<stdio.h>
float area(float r); //function declaration
float volume(float r, float h);
int main3()
{
	float v1 = volume(22.5, 44);
	printf("volume is %f", v1);
	return 0;
}

float area(float r) //function definition
{
	
	float a=0.0;

	a = 3.14 * r * r;

	return a;
}

float volume(float r, float h)
{
	float v = 0.0;
	v = area(r) * h;
	return v;
}