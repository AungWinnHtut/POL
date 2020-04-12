#pragma warning(disable : 4996)
#pragma warning(disable : 28183)
#pragma warning(disable : 6387)
#pragma warning(disable : 6031)

#include<stdio.h>
#include<stdlib.h>
int filetest();
void putachar();

int main17()
{
	putachar();
	return 0;
}

void putachar()
{
	char name[30];
	int i = 0;
	FILE* fp;
	fp = fopen("person.txt","w");
	printf("Enter Name : ");
	scanf("%[^\n]", name);
	printf("%s", name);

}




int filetest()
{

	FILE* fin = NULL;
	FILE* fout = NULL;
	FILE* fread = NULL;
	char ch = '\n';

	//if (fopen_s(&fin,"fin.txt", "r")!=0 )
	if ((fin = fopen("fin.txt", "r")) == NULL)
	{
		puts("File could not be opened\n");
		return -1;
	}
	else {
		while ((ch = fgetc(fin)) != EOF)
		{
			putchar(ch);
		}
	}

	printf("\n\n");

	if ((fout = fopen("fout.txt", "a")) == NULL)
	{
		puts("File could not be opened\n");
		return -1;
	}

	float a = 0.0;
	float r = 0.0;

	printf("enter r ");
	scanf("%f", &r);

	a = 3.14 * r * r;

	printf("%f\n", a);
	fprintf(fout, "%f\n", a);
	printf("\n\n");


	if (fout != NULL)
		fclose(fout);

	if (fin != NULL)
		fclose(fin);

	if ((fread = fopen("fout.txt", "r")) == NULL)
	{
		puts("File could not be opened\n");
		return -1;
	}

	char s[30];
	while (!feof(fread)) {
		a = 0.0;
		int err = fscanf(fread, "%f", &a);
		if (a > 0)
		{
			printf("%f\n", a);
		}
	}
	if (fread != NULL)
	{
		fclose(fread);
	}
}