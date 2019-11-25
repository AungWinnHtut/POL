#include<stdio.h>
#include<conio.h>
struct Arr avg(int * arr,int size);

struct Arr{
	int *ip;
	int count;
};

int main()
{
	struct Arr A2;
	char ch='k';
	char charr[10]={'1','2','3','4','5','6','7','8','9','0'};
	int iarr[3][3]= {
		{1,2,3},
		{4,5,6},
		{7,8,9}
	};

	int ia2[6]={1,2,3,4,5,6};


	A2=avg(ia2,6);
	for(int j=0;j<A2.count;j++)
	{
		printf("%d ",A2.ip[j]);
	}
	

	_getch();
	return 0;
}


struct Arr avg(int * arr,int size)
{
	struct Arr A1;
	int sum=0;
	float avg;

	for(int k=0;k<size;k++)
	{
		arr[k]*=2;
	}
	
	A1.ip = arr;
	A1.count = size;

	return A1;
}
