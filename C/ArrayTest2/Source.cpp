#include<stdio.h>
#include<conio.h>
int g = 100;
void funCount();
void funPrint();
int main()
{
	

	register int k=224;
	int a[6] = { 1,2,3,4,5,NULL };
	int b[7] = { 11,12,13,14,15,16,NULL };
	int i = 0;
	&i;
	&k;

	char c[4] = { 'a','b','c' ,'\0'};
	char d[5] = { 'd','e','f' ,'g','\0'};
	funPrint();

	funCount();
	funCount();
	funCount();

	return 0;
}

void funCount()
{
	static int count = 0;
	int c = 0;
	c++;
	count++;
	printf("count = %d c = %d\n", count,c);
}