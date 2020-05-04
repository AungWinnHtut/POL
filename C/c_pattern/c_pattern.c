#include<stdio.h>
void full_pyramid();
void half_pyramid();
void starA();

int main()
{
	starA();
	return 0;
}

void half_pyramid()
{

	int n = 0;
	int row = 0;
	int star = 0;

	printf("enter total number of roles: ");
	scanf_s("%d", &n);

	for (row = 1; row <= n; row++)
	{
		for (star = 1; star <= row; star++)
		{
			printf("*");
		}
		printf("\n");
	}
}

void full_pyramid()
{

	int n = 0;
	int row = 0;
	int star = 0;
	int space = 0;

	printf("enter total number of roles: ");
	scanf_s("%d", &n);

	for (row = 1; row <= n; row++)
	{

		for (space = 1; space <= n - row; space++)
		{
			printf(" ");
		}

		for (star = 1; star <= row*2-1; star++)
		{
			printf("*");
		}
		printf("\n");
	}
}

void starA()
{

	int n = 0;
	int row = 0;
	int starA = 0;
	int space = 0;

	printf("enter total number of roles: ");
	scanf_s("%d", &n);

	for (row = 1; row <= n; row++)
	{

		for (space = 1; space <= n - row; space++)
		{
			printf(" ");
		}

		for (starA = 1; starA <= row  - 1; starA++)
		{
			printf("*A");
		}

		printf("*\n");
	}
}