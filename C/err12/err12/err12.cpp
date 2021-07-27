#include<stdio.h>
#include<conio.h>
#include<string.h>
int main()
{
    char uname[] = "aaa";
    char pass[] = "bbb";
    char your_name[20];
    char passward[20];


    printf("please enter useer name:");
    scanf_s("%[^\n]", your_name, 20);


    printf("\nPlease enter your passward:");
    scanf_s(" %[^\n]", passward, 20);

    if ((strcmp(uname, your_name)) == 0 && (strcmp(pass, passward) == 0))
    {
        printf("Access granted!");
    }
    else
    {
        printf("Access denied!");
    }
    _getch();
    return 0;
}