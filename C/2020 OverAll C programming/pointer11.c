#include<stdio.h>

int main11()
{
	int a[3] = { 10,100,2000 };
	int* p = NULL;
	int* q = NULL;
	int* r = NULL;
	int* s = NULL;
	p = a;
	q = &a[0];
	r = &a[1];
	s = &a[2];

	return 0;
}