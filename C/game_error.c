#include <stdio.h>
#include <stdlib.h>
 
int player1=28;
int player2=28;
int Random;
char Kkey;
int player=2;
 
int RollNum1();
int RollNum2();
 
int main()
{
      
 
    while (player1!=30 || player2!=30)
    {
 
        if(player==1)
        {
            Random=RollNum1();
            player=2;
        }
        else if(player==2)
        {
            Random=RollNum2();
            player=1;
        }
       
    }
   
 
    return 0;
}
 
int RollNum1()
{
    printf("Player1 : Please rolling the dice by entering a key: \n");
 
        scanf("%c",&Kkey);
        int num;
 
        if(Kkey=='a')
        {
            num = rand() % 6+1;
            printf("You get number : %d \n",num);
        }
 
        player1++;
        return num;
 
}
 
int RollNum2()
{
    printf("Player2 : Please rolling the dice by entering b key: \n");
 
        scanf("%c",&Kkey);
        int num;
 
        if(Kkey=='b')
        {
            num = rand() % 6+1;
            printf("You get number : %d \n",num);
        }
 
        player2++;
        return num;
 
}