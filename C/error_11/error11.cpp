#include<stdio.h>
#include<conio.h>
#define ARR 5
int main()
{
    char arr[ARR];
    printf("Please enter your name");
    scanf_s("%s", arr,5);

    printf("this is data %s", arr);

    _getch();
    return 0;
}