//This program is example code
//for Green Hackers C fundamentals Online Course
//By Dr. Aung Win Htut
//charcount.c

#pragma warning(disable : 4996)
#pragma warning(disable : 28183)
#pragma warning(disable : 6387)
#pragma warning(disable : 6031)

#include<stdio.h>
#include<stdlib.h>

int main()
{
	FILE* fp = NULL;
	fp = fopen("test.txt", "a+");
	char ch = '\0';
	float f = 4.56;
	int i = 1234;
	char c = 'k';
	if (fp == NULL)
	{
		printf("ErrCode 001: File test.txt cannot open!\n");
		return 1;
	}
	
	/*while (!feof(fp))
	{
		ch = fgetc(fp);
		if (ch!=EOF)
		{
			putc(ch, stdout);
		}
	}*/



	

	if (fp != NULL)
	{
		fclose(fp);
	}

	system("notepad test.txt");

	return 0;
}