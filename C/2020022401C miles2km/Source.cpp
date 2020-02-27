#include<stdio.h>
#include<conio.h>

int main()
{
	float km;
	float miles;

	printf("How much miles? ");
	scanf_s("%f", &miles);

	km = 1.60934 * miles;

	printf("miles = %0.2f  equals %0.2f km", miles, km);
	_getch();
	return 0;
}