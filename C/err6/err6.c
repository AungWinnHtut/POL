#include <stdio.h>
int main()
{
    int n, c, k;

    printf("Enter number of rows\n");
    scanf_s("%d", &n);

    for (c = 1; c <= n; c++)
    {
        for (k = 1; k <= n - c; k++)
            printf(" ");

        for (k = 1; k < c; k++)
            printf("*A");

        printf("*\n");
    }
    return 0;
}