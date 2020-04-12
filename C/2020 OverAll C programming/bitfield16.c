
#include <stdio.h>
#include <string.h>

struct {
	unsigned int age : 4;
} Age;

int main16() {

	Age.age = 9;
	printf("Sizeof( Age ) : %d\n", sizeof(Age));
	printf("Age.age : %d\n", Age.age);

	Age.age =10;
	printf("Age.age : %d\n", Age.age);

	Age.age = 11;
	printf("Age.age : %d\n", Age.age);

	return 0;
}