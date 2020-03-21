/*
	cipher8.c
	cipher very basic 1 Caeser cipher	
	by  Dr. Aung Win Htut
	Green Hackers Online Training
	17-03-2020
*/

#include<stdio.h>
char toUpp(char c);
char toLow(char c);
char CaesarEn(char c);
char CaesarDe(char c);

int main8()
{
	char ch;
	char cipher;
	char plain;

	printf("Enter a Plain Text Character: ");
	scanf_s("%c", &ch,1);

	cipher = CaesarEn(ch);

	printf("Cipher code is %c \n",cipher);

	plain = CaesarDe(cipher);

	printf("Plain Text is %c \n\n\n", plain);
	return 0;
}

char CaesarEn(char c)
{
	char out = c + 3;
	return out;
}

char CaesarDe(char c)
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