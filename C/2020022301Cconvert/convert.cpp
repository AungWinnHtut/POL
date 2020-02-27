#include<stdio.h>
#include<conio.h>

int main()
{
	//1 yard = 3 feet
	//1feet  = 12 inches
	//1 yard = 36 inches

	int feet;
	int yard;
	int inches;

	printf("Please Enter Yard: ");
	scanf_s("%d", &yard);
	

	feet = 3 * yard;
	inches = 36 * yard;

	printf("%d yards equal %d feet and %d inches", yard, feet, inches);

	_getch();

	return 0;
}