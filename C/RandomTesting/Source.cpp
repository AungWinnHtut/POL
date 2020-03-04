#include<stdio.h>
#include<stdlib.h>

int main() {

	int One=0;
	int Two=0;
	int Three=0;
	int Four=0;
	int Five=0;

	for (int i = 1; i <= 5000; i++)
	{
		int number = 1 + (rand() % 5);
		switch (number)
		{
		case 1:
			++One;
			break;
		case 2:
			++Two;
			break;
		case 3:
			++Three;
			break;
		case 4:
			++Four;
			break;
		case 5:
			++Five;
			break;
		}
	}

	printf("%s%10s\n", "No", "Value");
	printf("1%10d\n", One);
	printf("2%10d\n", Two);
	printf("3%10d\n", Three);
	printf("4%10d\n", Four);
	printf("5%10d\n", Five);
	


	return 0;
}