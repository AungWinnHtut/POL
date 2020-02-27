#include<stdio.h>
#include<conio.h>
#include<stdlib.h> //standard library

int main()
{
int x;
int id;
int money;
int number;
int g;
int showm;
		
printf("!!!!!!!!!!!!!!!!!!!!Welcome to Game!!!!!!!!!!!!!!!!!!!\n\n");
printf("Please enter your age:");
scanf("%d", &x);
		
if( x > 17 )
{
printf("Please Show your money:");
scanf("%d", &showm);
printf("This is your money:%d\n",showm);
while( x > 17 )
{
printf("Please enter your id:");
scanf("%d", &id);
while( id==100)
{
printf("Please enter your money:\n At least 1000ks:");
scanf("%d", &money);
while( money > 999 )
{
printf("Please enter your lucky number:");
scanf("%d", &number);
if( number == 123 )
{
printf("Winner\n");
showm=showm+money*2;
printf("This is your remain money:%d\n",showm);
printf("If you wanna play or quit,please enter 1 or 2\n");
scanf("%d", &g);
if( g == 1)
{
printf("You can play next time\n");
}else
{
printf("Good Bye");
exit(0);
}
}else
{
printf("Sorry try again\n");
showm=showm-money;
printf("This is your remain money:%d\n",showm);
if( number != 123 )
{
printf("If you want to play enter 1 or quit to 2:\n");
scanf("%d", &g);
if( g == 1)
{
printf("You can play next time\n");
}else
{
printf("Sorory for quit");
exit(0);
}
}
if( showm < 999 )
{
printf("It is not enough money:%d\n",showm);
printf("Thank for playing");
exit(0);
}
}
}
}
}
}else
{
printf("Now you will not play");
}
		
getch ();	
return 0;	
}