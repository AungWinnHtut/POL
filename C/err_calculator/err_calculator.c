#include <stdio.h>
#include <conio.h>

void calc(void);

int main()
{
    calc();
    _getch();
    return 0;
}

// no return function

void calc(void)
{
    int num1, num2;
    char opera;
    int result;

    printf(" Add 1st number: ");
    scanf_s("%d", &num1);

    printf("Add 2nd number : ");
    scanf_s("%d", &num2);

    printf("Add Operator : ");
    opera=getchar();
    if (opera == '\n')
    {
        opera = getchar();
    }

    if (opera == '+')
    {
        result = num1 + num2;
        printf("Result of adding two number is %d.", result);
    }
    else if (opera == '-')
    {

    }
    else if (opera == '*')
    {

    }
    else if (opera == '/')
    {

    }
    else if (opera == '%')
    {

    }
    else
    {
        printf("Wrong Operator");
    }
}