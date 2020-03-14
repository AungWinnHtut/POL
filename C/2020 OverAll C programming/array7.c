#include<stdio.h>
#define size 5


int main()
{
	int iArr[size] = {	0, 0, 0, 0, 0 };

	for (int i = 0; i < size; i++)
	{
		iArr[i] = (2*i)+1;
	}

	printf("size of integer is %d\n\n", sizeof(int));

	for (int i = 0; i < size; i++)
	{
		printf("memory address %p \n", &iArr[i]);
	}



	return 0;
}