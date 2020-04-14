//This Program is Part of C fundamentals Online Training Class
//by Dr. Aung Win Htut (Green Hackers)
//fileio19.c
// This program open a txt file and read char , 
// print that char on screen, read again,etc until EOF

#pragma warning(disable : 4996)
#pragma warning(disable : 28183)
#pragma warning(disable : 6387)
#pragma warning(disable : 6031)

#include<stdio.h>
#include<stdlib.h>

void readFile(char* fn);

int main()
{
	char fname[20] = "r.txt";


	readFile(fname);

	return 0;
}

void readFile(char *fn)
{
	FILE* fin = NULL;	
	fin = fopen(fn, "r"); //
	if (fin == NULL) 	
	{
		printf("fin.txt cannot open");
		return 1;
	}

	char ch = '\0';

	while (1)
	{
		//ch = fgetc(fin);
		int ans=fscanf(fin, "%c", &ch);
		//if (ch == EOF) break;
		if (ans <= 0) break;
		printf("%c", ch);
	}

	if (fin != NULL)
	{
		fclose(fin);
	}	
}




