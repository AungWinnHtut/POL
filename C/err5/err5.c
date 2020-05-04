#pragma warning(disable : 4996)
#pragma warning(disable : 28183)
#pragma warning(disable : 6387)
#pragma warning(disable : 6031)


#include <stdio.h>
#include <stdlib.h>


void fun1();
void fun2();
void fun3();
void fun4();


int main()
{
	int ans = -1;

	do {
		ans = -1;
		system("cls");
		//print menu
		printf("*************\n");
		printf("* Main Menu *\n");
		printf("*************\n");
		printf("0-Exit\n");
		printf("1-Addition\n");
		printf("2-Subtraction\n");

		//ask ans
		printf("Choose your answer (0,1,2):  ");
		scanf("%d", &ans);

		//do as ans   switch()
		switch (ans)
		{
			case 0: exit(0);
			case 1: fun1(); break;
			case 2: fun2(); break;
			default: printf("Error! you must choose (0 or 1 or 2)!\n");
		}

	} while (ans != 0);

	return 0;
}

void fun1()
{
	system("cls");
	printf("Addition\n");
	_getch();
}

void fun2()
{
	int ans1 = -1;

	do {
		ans1 = -1;
		system("cls");
		//print menu
		printf("Sub Menu\n");
		printf("=========\n");		
		printf("0-Exit to Main Menu\n");
		printf("1-Addition\n");
		printf("2-Subtraction\n");

		//ask ans
		printf("Choose your answer (0,1,2):  ");
		scanf("%d", &ans1);

		//do as ans   switch()
		switch (ans1)
		{
		case 0: main();
		case 1: fun3(); break;
		case 2: fun4(); break;
		default: printf("Error! you must choose (0 or 1 or 2)!\n");
		}

	} while (ans1 != 0);

}

void fun3()
{
	system("cls");
	printf("function 3 \n");
	_getch();
}

void fun4()
{
	system("cls");
	printf("function 4 \n");
	_getch();
}

void fun5()
{
	
}