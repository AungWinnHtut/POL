#include <stdio.h>
#include <stdlib.h>
#include <time.h>    //for clock() function


// Driver code to test above function 
int main1()
{
	//printf("Clocks per second = %d", CLOCKS_PER_SEC);

	for (;;) {
		printf("%d \n",clock());
	}

	return 0;
}