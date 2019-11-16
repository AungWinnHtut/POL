#include<stdio.h>
#include<conio.h>
#include<stdlib.h>
#include<process.h>

void printHello();
double areaOfCircle(double r);
void mySelf(char* name);
void calVolume(void);
void calGoldPrice();

int main()
{
	int ans=4;

	printHello();
	mySelf("Green Hackers");
	
	do{
		system("cls");
		printf("1: Calculate Volume\n");
		printf("2: Calculate Gold Price\n");
		printf("0: Exit\n\n");

		printf("Please choose (0,1,2):		");
		scanf("%d",&ans);
		system("cls");
		switch(ans){
			case 0: exit(0); break;
			case 1: printf("Calculation of Volume\n"); printf("**********************\n"); calVolume(); break;
			case 2: printf("Calculation of Gold Price\n"); printf("**********************\n"); calGoldPrice(); break;
			default: printf("wrong input\n"); break;
		}
			
		printf("\n\nPress ANY key to continue....");
		_getch();
	}while(ans!=0);

	_getch();
	return 0;
}

void printHello() //function definition
{
		printf("Hello World\n");
}

double areaOfCircle(double r)
{
	double a;
	a=3.14*r*r;
	return a;
}

void mySelf(char* name)
{
	printf("I am %s\n",name);
	
}

void calVolume(void)
{
	double Area=0.0;
	double Volume;
	Area=areaOfCircle(22);
	Volume = Area * 100;
	printf("Volume = %f Area = %f\n\n",Volume,Area);

}

void calGoldPrice()
{
	float kyat=0.0;
	float pae=0.0;
	float yway=0.0;
	float gprice_per_kyat=0.0;
	float total_gold_price=0.0;
	float total_gold_weight_in_kyat=0.0;

	printf("pls enter gold price per kyat:	");
	scanf("%f",&gprice_per_kyat);
	printf("pls enter Kyat:	");
	scanf("%f",&kyat);
	printf("pls enter Pae:	");
	scanf("%f",&pae);
	printf("pls enter Yway:	");
	scanf("%f",&yway);

	total_gold_weight_in_kyat = kyat + (pae/16) + (yway / 128);
	total_gold_price = gprice_per_kyat * total_gold_weight_in_kyat;

	printf("total gold price = %f\n\n",total_gold_price);

}