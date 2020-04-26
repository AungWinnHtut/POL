//Snake game value range 1-30
//snake head and tail
//ladder bottom and top
//final goal (30)

#include<stdio.h>
#include<conio.h>
#include<stdlib.h>
#include<time.h>

int main()
{
    int dice = 0;//rolling dice no.
    int start = 1;//start point
    int mov = 0; //movement
    time_t t;//system time to generate random number
    int game = 0; //game value to coniue or quick
    int roll = 1;
    srand((unsigned)time(&t));
    while (start == 1)
    {
        printf("*******Welcome To $nake Game*******\n");
        _getch();
        mov = start;
        printf("You are now at start point\n");
        printf("Please enter 1 key to roll the dice : ");
        scanf_s("%d", &roll);

        while (roll == 1)
        {

            dice = rand() % 5 + 1;
            printf("The number of dice : %d\n", dice);
            _getch();
            mov = dice + mov;
            printf("Your location is : %d\n", mov);
            _getch();

            if ((mov == 3) || (mov == 5) || (mov == 11) || (mov == 20))
            {
                switch (mov)
                {
                case 3:
                    mov = 22;
                    printf("3 used ladder and now at %d\n", mov);
                    _getch();
                    break;
                case 5:
                    mov = 8;
                    printf("5 used ladder and now at %d\n", mov);
                    _getch();
                    break;
                case 11:
                    mov = 26;
                    printf("11 used ladder and now at %d\n", mov);
                    _getch();
                    break;
                case 20:
                    mov = 29;
                    printf("20 used ladder and now at %d\n", mov);
                    _getch();
                    break;

                }
            }
            else if ((mov == 17) || (mov == 19) || (mov == 21) || (mov == 27))
            {
                switch (mov)
                {
                case 17:
                    mov = 4;
                    printf("17 ate by snake and now at %d\n", mov);
                    _getch();
                    break;
                case 19:
                    mov = 7;
                    printf("19 ate by snake and now at %d\n", mov);
                    _getch();
                    break;
                case 21:
                    mov = 9;
                    printf("21 ate by snake and now at %d\n", mov);
                    _getch();
                    break;
                case 27:
                    mov = 1;
                    printf("27 ate by snake and now at %d\n", mov);
                    _getch();
                    break;
                }
            }
            else if (mov > 30)
            {
                printf("You are over the goal : %d\n", mov);
                _getch();
                mov = 30 - (mov - 30);//to move back as the value of over 30
                printf("You've been moved back to : %d\n", mov);
                _getch();
            }
            else if (mov == 30)
            {
                printf("*****Congratulations! You are winner*****\n");
                printf("If you want to play again press 1 or end  press 0 : \n");
                scanf_s("%d", &game);
                if (game == 1)
                {
                    printf("You can enjoy again!\n");
                    mov = start;
                    system("cls");
                    _getch();
                }

                else if (game == 0)
                {
                    printf("Thank you for playing\n");
                    printf("HAVE A GOOD DAY! BYE!!!\n ");
                    _getch();
                    exit(0);
                }

            }

        } /*while(mov!=30);
        printf("*****Congratulations! You are winner*****\n");
            _getch();*/
    }
    return 0;
}