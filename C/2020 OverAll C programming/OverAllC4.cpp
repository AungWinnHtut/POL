
#include <stdio.h>
#include <stdlib.h>
#include <time.h>   



int main4() {
	int age = 0;
	int id = 0;
	int amount = 0;
	int number = 0;
	int num = 0;
	int smoney = 0;
	int mmoney = 0;
	int rmoney = 0;
	int all = 0;

	printf("$$ Welcome Our Lottery $$\n\n");
	printf("Enter Your Age :");
	scanf_s("%d", &age);

	if (age > 17)
	{
		printf("Enter Your Show Money :");
		scanf_s("%d", &smoney);
		printf("This is Your Money :%d\n", smoney);
		while (age > 17) {
			printf("Enter Your ID :");
			scanf_s("%d", &id);
			while (id < 100)
			{
				printf("Start Game\n");
				printf("Enter Your Amount :");
				scanf_s("%d", &amount);
				while (amount > 999)
				{
					printf("Choice Your Lucky Number :");
					scanf_s("%d", &number);

					if (number == 111)
					{
						rmoney = amount * 10;
						all = mmoney + rmoney;
						printf("This is Your All Money : %d\n", all);
						printf("Congratulation You Win\n");
						printf("Press 1 to Play Again\n");
						printf("Press 2 to Exit Game!\n");
						scanf_s("%d", &num);
						if (num == 1)
						{
							printf("Play Again!\n");
						}
						else
						{
							printf("See You Again!");
							exit(0);
						}
					}
					else
					{
						printf("You Lose, Try Again!\n");
						mmoney = smoney - amount;
						printf("This is Your M Money :%d\n", mmoney);
						if (mmoney < 1000)
						{
							printf("You Can't Play!");
							exit(0);
						}
					}
				}
			}
		}
	}
	else
	{
		printf("You Can't Play This Game!");
	}



	return 0;
}

//#include<stdio.h>
//#include<conio.h>
//
//int main()
//{
//
//	_getch();
//	return 0;
//}