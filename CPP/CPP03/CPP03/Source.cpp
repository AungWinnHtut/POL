#include<iostream>
void row(int s1, int sp, int s2);
using namespace std;



int main()
{
	int rows = 0;
	int col = 0;
	cout << "enter rows ";
	cin >> rows;
	cout << "enter col ";
	cin >> col;

	row(col / 2, 0, col / 2);
	for (int k = 0; k < rows - 2; k++)
	{
		row(1, col-2, 1);
	}
	row(col / 2, 0, col / 2);

	return 0;
}


void row(int s1,int sp,int s2)
{
	for (int i = 0; i < s1; i++)
	{
		cout << "*";
	}
	for (int i = 0; i < sp; i++)
	{
		cout << " ";
	}
	for (int i = 0; i < s2; i++)
	{
		cout << "*";
	}
	cout << endl;
}


int main2()
{

	int a=0;
	int b=0;
	char ans = '\0';

	do {
		cout << "enter a ";
		cin >> a;
		cout << "enter b ";
		cin >> b;

		if (a > b)
		{
			cout << "a is larger";
		}
		else if (b > a)
		{
			cout << "b is larger";
		}
		else
		{
			cout << "equal";
		}
		cout << endl<<"try again? y or n ";
		cin >> ans;
	} while ((ans!='n') && (ans!='N'));


	return 0;
}


int main1()
{
	int max = 0;
	cout << "enter max limit ";
	cin >> max;
	for (int i = 1; i <= max; i++)
	{
		cout << i << " ";
		if ((i % 10) == 0)
		{
			cout << endl;
		}
	}
	
	return 0;
}