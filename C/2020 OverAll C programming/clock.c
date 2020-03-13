#include <stdio.h>
#include <stdlib.h>
#include <time.h>    //for clock() function

#include<stdio.h>
// Driver code to test above function 
int main6()
{
	printf("Clocks per second = %d", CLOCKS_PER_SEC);

	for (;;) {
		printf("%d \n",clock());
	}

	return 0;
}