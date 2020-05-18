#include<iostream>
#include<iomanip>
#include<string>

using namespace std;

int main()
{
	
	string strInput;

	cout << "enter your name ";
	getline(cin, strInput);	
	
	cout << "You enter you name as " << strInput << endl;
	return 0;
}