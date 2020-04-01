#include<stdio.h>
void printbits(int x);
int main10()
{
	int a = 0;
	char* x;
	x = (char*)&a;

	x[0] = 15;  //00001111
	x[1] = 3;   //00000011
	x[2] = 1;   //00000001
	x[3] = 0;   //00000000


	//if little endian   00000000 00000001 00000011 00001111 (00000000000000010000001100001111) dec value       66,319‬
	//if big endian      00001111 00000011 00000001 00000000 (00001111000000110000000100000000) dec value  251,855,104

	printf("the value : %d \n", a);
	printbits(a);

	return 0;
}

void printbits(int x)
{
	for (int i = sizeof(x) << 3; i; i--)
		putchar('0' + ((x >> (i - 1)) & 1));
}