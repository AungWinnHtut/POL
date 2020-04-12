//This Program is Part of C fundamentals Online Training Class
//by Dr. Aung Win Htut (Green Hackers)

#pragma warning(disable : 4996)
#pragma warning(disable : 28183)
#pragma warning(disable : 6387)
#pragma warning(disable : 6031)

#include<stdio.h>
#include<stdlib.h>

void area3();
void area4();

int main18()
{
	area4();
	
	return 0;
}

void area4()
{
	FILE* fin = NULL;
	FILE* fout2 = NULL;

	fin = fopen("r.txt", "r"); //w a r 
	fout2 = fopen("a2.txt", "w"); //w a r 

	if ((fin == NULL) || (fout2 == NULL))
	{
		printf("fout.txt cannot open");
		return 1;
	}


	float r = 0.0;
	float a = 0.0;

	while (!feof(fin))
	{
		r = 0.0;
		int ret=fscanf(fin, "%f", &r);
		if(ret>0) //(!feof(fin)) //if(r!=0)
		{
			a = 3.14 * r * r;
			printf("the area is %0.2f\n", a);
			fprintf(fout2, "%0.2f\n", a);
		}
		
	}

	if (fin != NULL)
	{
		fclose(fin);
	}
	if (fout2 != NULL)
	{
		fclose(fout2);
	}
}




void area3()
{
	FILE* fout1 = NULL;
	FILE* fout2 = NULL;

	fout1 = fopen("r.txt", "a"); //w a r 
	fout2 = fopen("a.txt", "a"); //w a r 

	if ((fout1 == NULL) || (fout2==NULL))
	{
		printf("fout.txt cannot open");
		return 1;
	}
	

	float r = 0.0;
	float a = 0.0;

	printf("please enter r : ");
	scanf("%f", &r);

	a = 3.14 * r * r;

	printf("the area is %f", a);
	fprintf(fout1,"%0.2f\n",r);
	fprintf(fout2, "%0.2f\n", a);

	if (fout1 != NULL)
	{
		fclose(fout1);
	}
	if (fout2 != NULL)
	{
		fclose(fout2);
	}	

}