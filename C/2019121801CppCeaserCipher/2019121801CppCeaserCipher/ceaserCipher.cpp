#include<stdio.h>
#include<conio.h>

int main()
{
	int i;
	char alpha[27]=       {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z',' '};
	char substitute[27]={'1','2','3','4','5','6','7','8','9','!','@','#','$','%','^','&','*','(',')','-','+','=','_','?','>','/','<'};
	char ch;
	char plain[1000];
	int index1 =0;
	char cipher[1000];
	int status =0 ; //0 not found 1 found

	for (int j=0;j<1000;j++)
	{
		cipher[j]='\n';
	}

	printf("Please Enter Plain Text end by \n ");
	do{
		ch = getc(stdin);
		if(ch=='\n')
		{
			plain[index1]='\n';
			cipher[index1++]='\n';
			status=0;
			break;
		}
		for( i=0;i<27;i++)
		{
			if(alpha[i]==ch)
			{
				status = 1;
				break;
			}
		}
		if(status==1)
		{
			cipher[index1]=substitute[i];
			status =0;
		}

		plain[index1++]=ch;
	}while(ch!='\n');

	int index2=0;
	while(plain[index2]!='\n')
	{
		printf("%c		->		",plain[index2]);
		printf("%c\n",cipher[index2++]);
	}
	index1=0;
	char cip[27];
	char pln[27];
	printf("\nPlease Enter Cipher Text end by \n ");
	do{
		ch = getc(stdin);
		if(ch=='\n')
		{
			pln[index1]='\n';
			cip[index1++]='\n';
			status=0;
			break;
		}
		for( i=0;i<27;i++)
		{
			if(substitute[i]==ch)
			{
				status = 1;
				break;
			}
		}
		if(status==1)
		{
			pln[index1]=alpha[i];
			status =0;
		}

		cip[index1++]=ch;
	}while(ch!='\n');

	index2=0;
	while(pln[index2]!='\n')
	{
		printf("%c		->		",cip[index2]);
		printf("%c\n",pln[index2++]);
	}


	_getch();
	return 0;
}