#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <time.h>

int main()
{
	int iGameCount=0;
	int iU1Loc=1;
	int iU2Loc=1;
	int dice=0;

	srand (time(NULL));

	while(1)
	{
		dice = rand()%6+1;

		if((iGameCount%2)==0)
		{
			iU1Loc+=dice; //iU1Loc=iU1Loc+dice;
			printf("User 1 location now is %d\n",iU1Loc);
			if(iU1Loc>36)
			{
				printf("User 1 won\n");
				break;
			}
		}

		else if((iGameCount%2)==1)
		{
			iU2Loc+=dice; //iU1Loc=iU1Loc+dice;
			printf("User 2 location now is %d\n",iU2Loc);
			if(iU2Loc>36)
			{
				printf("User 2 won\n");
				break;
			}			
		}

		iGameCount++;

	}
	_getch();
	return 0;
}