#include<stdio.h>
#include<conio.h>

int main()
{
	int a;
	int b;
	int c[10];
	&c[0];
	&c[1];
	&c[2];
	&c[3];
	&c[4];

	a = 1;
	a = 3;
	b = 10;

	&a;
	&b;

	for (int i = 0; i < 10; i++)
	{
		c[i] = 0;
	}
	sizeof(int);
	return 0;
}