#include<stdio.h>
#include<conio.h>

int main()
{
	float kyat = 0;
	float pae = 0;
	float yway = 0;
	float gold_weight_in_kyat = 0;
	float gold_price_per_kyat = 0;
	float total_gold_price = 0;

	printf("Enter current godl price per kyat ");
	scanf("%f",&gold_price_per_kyat);

	printf("Enter Kyat ");
	scanf("%f",&kyat);

	printf("Enter Pae ");
	scanf("%f",&pae);

	printf("Enter Yway ");
	scanf("%f",&yway);


	gold_weight_in_kyat = kyat + pae/16 + yway/(16*8) ;
	total_gold_price = gold_price_per_kyat * gold_weight_in_kyat;

	printf("the total gold price is %0.2f ",total_gold_price);
	_getch();
	return 0;
}