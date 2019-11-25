#include<stdio.h>
int main(int argc, char **argv)   //{  "claexample", argv[0]
													//"input1",  argv[1]
													//"input2"}  argv[2]
{
	printf("number of arguments %d\n",argc);

	for(int i=0;i<argc;i++)
	{
		printf("%d-%s\n",i,argv[i]);
	}

	return 0;
}