#include<stdio.h>
#include<conio.h>

int main()
{
	double a[3] = {};
	double r[3] = { 22.4,44.8,11.2 };
	
	for (int i = 0; i < 3; i++)
	{
		a[i] = 3.14 * r[i] * r[i];
	}
	
	for(int j=0;j<3;j++)
		printf("area = %f for r = %f \n", a[j],r[j]);



	
	//_getch();
	return 0;
}

