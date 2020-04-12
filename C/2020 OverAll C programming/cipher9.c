/*
	cipher8.c
	cipher very basic 1 Caeser cipher
	by  Dr. Aung Win Htut
	Green Hackers Online Training
	17-03-2020
*/

#pragma warning(disable : 4996)
#pragma warning(disable : 28183)
#pragma warning(disable : 6387)

#include<stdio.h>
#include<stdlib.h>

//char toUpp(char c);
//char toLow(char c);
char CaesarEn1(char c);
char CaesarDe1(char c);
void fileRead();
void fileEncrypt();

int main9()
{
	char ch[50];
	char cipher[50];
	char plain[50];

	for (int i = 0; i < 50; i++)
	{
		ch[i] = '\0';
		cipher[i] = '\0';
		plain[i] = '\0';
	}

	printf("Enter a Plain Text Message: To End message, Press  ");
	
	char c = '\0';
	int j = 0;
	while (c != '\n')
	{
		scanf_s("%c", &c, 1);
		ch[j] = c;
		j++;
	}



	for (int i = 0; i < 50; i++)
	{
		cipher[i] = CaesarEn1(ch[i]);		
	}
	

	printf("\nCipher code is %s \n", cipher);

	for (int i = 0; i < 50; i++)
	{
		plain[i] = CaesarDe1(cipher[i]);		
	}

	printf("\nPlain Text is %s \n\n\n", plain);

	fileEncrypt();

	return 0;
}

char CaesarEn1(char c)
{
	if (c != '\0'&& c != '\n'&& c != '\r')
	{
		char out = c + 3;
		return out;
	}
	else
	{
		return '\0';
	}
	
}

char CaesarDe1(char c)
{
	if (c != '\0' && c != '\n' && c != '\r')
	{
		char out = c - 3;
		return out;
	}
	else
	{
		return '\0';
	}
}



void fileRead()
{
	char word[5000] = { '\0' };  //initialize all elements with '\0'
	int i = 0;
	FILE* fptr;
	if ((fptr = fopen("d:\\c\\c\\plaintext.txt", "r")) == NULL) {
		printf("Error! opening file");
		// Program exits if file pointer returns NULL.
		exit(1);
	}

	int c;
	while (((c = fgetc(fptr)) != EOF) && (i<5000))
	{
		word[i++] = c;
	}
	if (c==EOF)
	{
		printf("Successfully Read the file till end\n");
	}
	else
	{
		printf("Unknown Error! Cannot read the file till end\n");
	}
	
	for (int j = 0; j < i; j++)
	{
		printf("%c", word[j]);
	}

}

void fileEncrypt()
{
	char word[5000] = { '\0' };  //initialize all elements with '\0'
	char cip[5000] =  { '\0' };
	char pln[5000] =  { '\0' };
	int i = 0;
	FILE* fptr;

	FILE* fcip;
	FILE* fpln;


	if ((fptr = fopen("d:\\c\\c\\plaintext.txt", "r")) == NULL) {
		printf("Error! opening file");
		// Program exits if file pointer returns NULL.
		exit(1);
	}

	if ((fcip = fopen("d:\\c\\c\\cipher.txt", "w")) == NULL) {
		printf("Error! opening file");
		// Program exits if file pointer returns NULL.
		exit(1);
	}

	if ((fpln = fopen("d:\\c\\c\\plaintext2.txt", "w")) == NULL) {
		printf("Error! opening file");
		// Program exits if file pointer returns NULL.
		exit(1);
	}



	int c;
	while (((c = fgetc(fptr)) != EOF) && (i < 5000))
	{
		word[i++] = c;
	}
	if (c == EOF)
	{
		printf("Successfully Read the file till end\n");
	}
	else
	{
		printf("Unknown Error! Cannot read the file till end\n");
	}

	printf("\n\n\nplain.txt File contents: \n");

	for (int j = 0; j < i; j++)
	{
		printf("%c", word[j]);
	}

	for (int j = 0; j < i; j++)
	{
		cip[j]= CaesarEn1(word[j]);
	}


	printf("\n\n\nCiphers: \n");

	for (int j = 0; j < i; j++)
	{
		printf("%c", cip[j]);
		fprintf(fcip, "%c", cip[j]);
	}


	for (int j = 0; j < i; j++)
	{
		pln[j] = CaesarDe1(cip[j]);
	}


	printf("\n\n\nPlain Text: \n");

	for (int j = 0; j < i; j++)
	{
		printf("%c", pln[j]);
		fprintf(fpln, "%c", pln[j]);
	}

	printf("\n\n\n");
	if (fptr != NULL)
	{
		fclose(fptr);
	}
	if (fcip != NULL)
	{
		fclose(fcip);
	}
	if (fpln != NULL)
	{ 
		fclose(fpln);
	}

}



//char toUpp(char c)
//{
//	char up = c - 32;
//	return up;
//}
//
//char toLow(char c)
//{
//	char low = c + 32;
//	return low;
//}