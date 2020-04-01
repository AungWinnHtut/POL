#include<stdio.h>

int main12()
{
	char str[] = "Hello";
	char* str1 = "Hello";

	for (int i = 0; str[i]!='\0'; i++)
	{
		printf("%c", str[i]);
	}

	
	return 0;
}