#include<stdio.h>
#include<conio.h>

int main()
{
    int element[100] = { 0 };
    int size = 0;

    printf("Choose Your Array Size (1 - 100): ");
    scanf_s("%d", &size);

    for (int i = 0; i < size; i++)
    {
        printf("Please enter index %d element: ", i);
        scanf_s("%d", &element[i]);
    }

    for (int i = 1; i < size; i++)
    {
        if (element[0] < element[i])
        {
            element[0] = element[i];
        }
    }
    printf("The Largest Element Is %d", element[0]);

    _getch();
    return 0;
}