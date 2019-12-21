#include<stdio.h>
#include<conio.h>
#include<string.h>
//size_t strlen(const char *s);
int myStrlen(const char *s);
int main()
{
	char s1[4]={'a','b','c','d'};
	char s2[4]={'e',' ','g','h'};
	int i=0;
	while(s2[i]>0)
	{
		i++;
	}
	printf("count = %d",i);
	printf("\ncount2 = %d",strlen(s2));
	printf("\ncount3 = %d",myStrlen(s2));
	getch();
	return 0;
}

int myStrlen(const char *s)
{
	int i=0;
	while(s[i]!='\0')
	{
		i++;
	}
	return i;
}