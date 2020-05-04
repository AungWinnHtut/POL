#include<stdio.h>
#include<conio.h>

int main()
{
    int a = 1, b = 4;
    int resulti=0;

    double c, d;
    c = 2.4;
    d = 5.6;
    double resultf=0;

    printf("float size is %d bytes", sizeof(float));
    printf("double size is %d bytes", sizeof(double));

    char e = 'A', f = '0';

    printf("a+b=%d\n", a + b);
    printf("a-b=%d\n", a - b);
    printf("c*d=%lf\n", c * d);
    printf("c/d=%f\n", c / d);
    printf("a mod b=%d\n", a % b);

    printf("a++=%d\n", a++);
    printf("a=%d\n", a);

    printf("++a=%d\n", ++a);
    printf("a=%d\n", a);

    printf("a--=%d\n", a--);
    printf("a=%d\n", a);

    printf("--a=%d\n", --a);
    printf("a=%d\n", a);

    _getch();
    return 0;
}