/*
	cipher8.c
	cipher very basic 1 Ceaser cipher	
	by  Dr. Aung Win Htut
	Green Hackers Online Training
	17-03-2020
*/

#include<stdio.h>
char toUpp(char c);
char toLow(char c);
char CieserEn(char c);
char CieserDe(char c);

int main()
{
	char ch;
	char cipher;
	char plain;

	printf("Enter a Plain Text Character: ");
	scanf_s("%c", &ch,1);

	cipher = CieserEn(ch);

	printf("Cipher code is %c \n",cipher);

	plain = CieserDe(cipher);

	printf("Plain Text is %c \n\n\n", plain);
	return 0;
}

char CieserEn(char c)
{
	char out = c + 3;
	return out;
}

char CieserDe(char c)
{
	char out = c - 3;
	return out;
}



char toUpp(char c)
{
	char up = c - 32;
	return up;
}

char toLow(char c)
{
	char low = c + 32;
	return low;
}