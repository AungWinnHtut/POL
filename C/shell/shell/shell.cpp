#include<stdio.h>
#include<conio.h>
#include<process.h> //system()
int main()
{
	system("dir g:\\ >> g:\\systeminfo2.txt");
	system("notepad g:\\systeminfo2.txt");
	_getch();
	return 0;
}