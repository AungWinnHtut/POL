#include <stdio.h>
#include <stdlib.h>
#include <time.h>    //for clock() function
void delay(int milli_seconds);
void sleep(int number_of_seconds);

void sleep(int number_of_seconds)
{
	delay(1000 * number_of_seconds);
}

void delay(int milli_seconds)
{
	// Storing start time 
	clock_t start_time = clock();

	// looping till required time is not achieved 
	while (clock() < start_time + milli_seconds)
		;
}


// Driver code to test above function 
int main4()
{
	int i;

	for (unsigned int hour = 0; hour < 24; hour++) {
		for (unsigned int minute = 0; minute < 60; minute++) {
			for (unsigned int second = 0; second < 60; second++) {
				// delay of one second 
				sleep(1);
				printf("%d hours : %d minutes : %d seconds have passed\n", hour, minute, second);
			}
		}
	}

	return 0;
}