#include<iostream>
using namespace std;

int main()
{

	int num = 1; //to ask number 5 times
	int number;  //to save user input
	int total = 0; //total value for all user inputs

	for(num=1;num<=5;num++)
	{
		cin >> number;
		total += number; // total = total + number;		
	}

	cout << total << endl;

	return 0;
}