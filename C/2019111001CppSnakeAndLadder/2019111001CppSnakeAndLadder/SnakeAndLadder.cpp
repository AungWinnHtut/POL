







/*
	This Program is Written By Dr. Aung Win Htut
	Green Hackers 2020-02-18
*/
#include<stdio.h>
#include<stdlib.h>
#include<time.h>
#include<conio.h>

int home = 1;
int goal = 36;
int scount = 0;
int lcount = 0;
//Snakes
int sh1 = 17;
int st1 = 4;
int sh2 = 20;
int st2 = 6;
int sh3 = 24;
int st3 =16;
int sh4 = 32;
int st4 = 30;
int sh5 = 34;
int st5 = 12;

//Ladders
int lh1 = 15;
int lt1 = 2;
int lh2 = 7;
int lt2 = 5;
int lh3 = 27;
int lt3 =9;
int lh4 = 29;
int lt4 = 18;
int lh5 = 35;
int lt5 = 25;

int main()
{
	int counter =0;
	int u1loc = home;
	int dice =0;
	srand(time(NULL));
	printf("Snake and Ladder Game is Starting...\n\n");
	while(u1loc!=36)
	{
		counter++;
		dice = (rand()%6) +1;		
		printf("dice is %d\n",dice);
		u1loc = u1loc + dice;
		printf("User one location is now at %d\n\n",u1loc);

		if(u1loc==lt1) 
		{
			u1loc=lh1;
			lcount++;
			printf("Wow...Great!\nWe found a ladder!!!!\nNow User One Move to %d\n\n",u1loc);
		}
		else if(u1loc==lt2) 
		{
			u1loc=lh2;
			lcount++;
			printf("Wow...Great!\nWe found a ladder!!!!\nNow User One Move to %d\n\n",u1loc);
		}
		else if(u1loc==lt3) 
		{
			u1loc=lh3;
			lcount++;
			printf("Wow...Great!\nWe found a ladder!!!!\nNow User One Move to %d\n\n",u1loc);
		}
		else if(u1loc==lt4) 
		{
			u1loc=lh4;
			lcount++;
			printf("Wow...Great!\nWe found a ladder!!!!\nNow User One Move to %d\n\n",u1loc);
		}
		else if(u1loc==lt5) 
		{
			u1loc=lh5;
			lcount++;
			printf("Wow...Great!\nWe found a ladder!!!!\nNow User One Move to %d\n\n",u1loc);
		}
	

		if(u1loc==sh1) 
		{
				u1loc=st1;
				scount++;
				printf("Ahhh...Snake!\nIt swallow me!!!!\nNow User One Move to %d\n\n",u1loc);
		}
		else if(u1loc==sh2) 
		{
				u1loc=st2;
				scount++;
				printf("Ahhh...Snake!\nIt swallow me!!!!\nNow User One Move to %d\n\n",u1loc);
		}
		else if(u1loc==sh3) 
		{
				u1loc=st3;
				scount++;
				printf("Ahhh...Snake!\nIt swallow me!!!!\nNow User One Move to %d\n\n",u1loc);
		}
		else if(u1loc==sh4) 
		{
				u1loc=st4;
				scount++;
				printf("Ahhh...Snake!\nIt swallow me!!!!\nNow User One Move to %d\n\n",u1loc);
		}
		else if(u1loc==sh5) 
		{
				u1loc=st5;
				scount++;
				printf("Ahhh...Snake!\nIt swallow me!!!!\nNow User One Move to %d\n\n",u1loc);
		}
		if(u1loc>36) 
		{		
			u1loc=goal-(dice-(goal-u1loc));
			printf("Ohhh... you reach over home, please come back to new loc %d\n\n",u1loc);
		}
	}

	

	printf("Victory!!!\n");
	printf("You climb ladder %d times\n",lcount);
	printf("You bite by snake %d times\n",scount);
	printf("Total number of rolling dice %d\n\n",counter);
	printf("Thank you for playing\n");
	printf("******************");
	_getch();
	return 0;
}
//goal-(dice-(goal-u1loc))

