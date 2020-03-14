
#include <stdio.h>
#include <stdlib.h>
#include <limits.h>
#include <float.h>

int main5(int argc, char** argv) {

	printf("CHAR_BIT    :   %d\n", CHAR_BIT);
	printf("CHAR_MAX    :   %d\n", CHAR_MAX);
	printf("CHAR_MIN    :   %d\n", CHAR_MIN);
	printf("INT_MAX     :   %d\n", INT_MAX);
	printf("INT_MIN     :   %d\n", INT_MIN);
	printf("LONG_MAX    :   %ld\n", (long)LONG_MAX);
	printf("LONG_MIN    :   %ld\n", (long)LONG_MIN);
	printf("SCHAR_MAX   :   %d\n", SCHAR_MAX);
	printf("SCHAR_MIN   :   %d\n", SCHAR_MIN);
	printf("SHRT_MAX    :   %d\n", SHRT_MAX);
	printf("SHRT_MIN    :   %d\n", SHRT_MIN);
	printf("UCHAR_MAX   :   %d\n", UCHAR_MAX);
	printf("UINT_MAX    :   %u\n", (unsigned int)UINT_MAX);
	printf("ULONG_MAX   :   %lu\n", (unsigned long)ULONG_MAX);
	printf("USHRT_MAX   :   %d\n", (unsigned short)USHRT_MAX);

	printf("%d bytes\n", sizeof(int));
	printf("%d bytes\n", sizeof(long));
	printf("%d bytes\n", sizeof(short));
	printf("%d bytes\n", sizeof(float));
	printf("%d bytes\n\n\n", sizeof(double));

	int a = 3;
	int b = 4;
	float c = (float) a / b;
	int d = a % b;
	double e = 55.6;


	printf("%d\n", a);
	printf("%d\n", b);
	printf("%f\n", c);
	printf("%d\n", d);
	printf("%g\n", e);
	



	return 0;
}