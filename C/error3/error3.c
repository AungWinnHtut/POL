#pragma warning(disable : 4996)
#pragma warning(disable : 28183)
#pragma warning(disable : 6387)
#pragma warning(disable : 6031)

/*
	1.ask age
	2.read age

	if(age>17) play the game
	else exit

	//play the game
	1. ask password or id
	if correct play continue
	else exit


	//if id is OK
	1. ask if he has money
	2. ask amount to bet

	//if win
	1. smoney = ( umoney * 10 ) + smoney;

	//if lose
	1. smoney = smoney - umoney


*/

#include<stdio.h>
#include<stdlib.h>
int main() {

	int age = 0;
	int id = 0;
	int smoney = 0;
	int num = 0;
	int data = 0;
	int umoney = 0;
	printf("    WELLCOME TO OUR LOTTERT GAME    \n Please enter your age:");
	scanf("%d", &age);
	if (age > 17) {

		printf("You Can Play The Game!\n Please Enter Your ID:");
		scanf("%d", &id);
		while (id == 111) {
			printf("Please Show Your Money:");
			scanf("%d", &smoney);
			printf("Please Enter The Money You Want To Use\n(It must be more than 1000ks) 🙂");
			scanf("%d", &umoney);
			while (umoney > 999)
			{
				printf("Please Enter The Number You Like: ");
				scanf("%d", &num);
				if (num == 333) {
					
					smoney = (smoney + (umoney * 10 ));
					printf("##Congracutions you win the game##\n Now your money is:%d\n", smoney);

					printf("If you want to continue,press 1:  ");
					scanf("%d", &data);
					printf("You Can Play the Game again");
				}
				else {
					printf("Sorry! Try Again!\n Now your money is:%d", smoney);
					smoney = smoney - umoney;
					printf("##Ohh sorry you lose the game##\n Now your money is:%d\n", smoney);
				}
				if (data == 1) {
					printf("You Can Play Again Now\n");
				}
				else { 
					exit(0); 
				}
			}
		}

	}
	else {
		printf("Sorry! You Can't Play The Game");
		exit(0);
	}



	return 0;
}