//This program is example code
//for Green Hackers C fundamentals Online Course
//By Dr. Aung Win Htut
//fiotemplate.c

#include<stdio.h>

int main()
{
	FILE * fp = NULL;
	fp = fopen("test.txt","r");
	if(fp==NULL)
	{
		return 1;
	}


	if(fp!=NULL)
	{
		fclose(fp);
	}
}