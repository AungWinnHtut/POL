/*
	caesarcipher.c
	cipher very basic 2 Caeser cipher
	by  Dr. Aung Win Htut
	Green Hackers Online Training
	17-03-2020
*/
#pragma warning(disable : 4996)

#include<stdio.h>


char caesaren(char c,int key);
char caesarde(char c,int key);


int main()
{
	char ch = '\0';
	int i = 0;

	char input[5000] = { '\0' };
	char cipher[5000] = { '\0' };
	char plain[5000] = { '\0' };

	FILE* fin;
	FILE* fcip;
	FILE* fout;
	   	 
	if ((fin = fopen("d:\\c\\c\\plaintext.txt", "r")) == NULL) {
		printf("Error! opening file");
		// Program exits if file pointer returns NULL.
		exit(1);
	}
	if ((fcip = fopen("d:\\c\\c\\cipher.txt", "w")) == NULL) {
		printf("Error! opening file");
		// Program exits if file pointer returns NULL.
		exit(1);
	}

	if ((fout = fopen("d:\\c\\c\\out.txt", "w")) == NULL) {
		printf("Error! opening file");
		// Program exits if file pointer returns NULL.
		exit(1);
	}

	while (((ch = fgetc(fin)) != EOF) && (i < 5000))
	{
		input[i++] = ch;
	}
	if (ch == EOF)
	{
		printf("Successfully Read the file till end\n");
	}
	else
	{
		printf("Unknown Error! Cannot read the file till end\n");
	}




	printf("\nyou entered:  ");
	for (int j = 0; j < i; j++)
	{
		printf("%c", input[j]);
	}

	for (int j = 0; j < i; j++)
	{
		cipher[j]=caesaren(input[j],23);
	}

	printf("\ncipher text:  ");
	for (int j = 0; j < i; j++)
	{
		printf("%c", cipher[j]);
		fprintf(fcip,"%c", cipher[j]);
	}

	for (int j = 0; j < i; j++)
	{
		plain[j] = caesarde(cipher[j],23);
	}

	printf("\nplain text:  ");
	for (int j = 0; j < i; j++)
	{
		printf("%c", plain[j]);
		fprintf(fout, "%c", plain[j]);
	}

	fclose(fin);
	fclose(fcip);
	fclose(fout);

	return 0;
}

char caesaren(char c,int key)
{
	if ((c != '\0') && (c != '\n') && (c != '\r'))
	{
		char out = c - key;
		return out;
	}
	else
	{
		return '\0';
	}
}

char caesarde(char c,int key)
{
	if ((c != '\0') && (c != '\n') && (c != '\r'))
	{
		char out = c + key;
		return out;
	}
	else
	{
		return '\0';
	}
}