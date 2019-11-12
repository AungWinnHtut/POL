#include<stdio.h>
#include<conio.h>
int funFOut(char* fname, char* mode, char* msg);
int funFin(char* fname, char* mode);

int main()
{
	//funFOut("test.txt","w","I am aung win htut\nI am a green Hackers");
	funFin("test.txt","r");
	//_getch();
	return 0;
}

int funFOut(char* fname, char* mode, char* msg)
{
	FILE *fout;
	fout = fopen(fname,mode);
	fputs(msg,fout);	
	fclose(fout);
	return 0;
}

int funFin(char* fname, char* mode)
{
	FILE *fin;
	char ch;
	fin = fopen(fname,mode);
	while(1)
	{
		ch = fgetc(fin);
		if(ch==EOF)
			break;
		else
			printf("%c",ch);
	}
	fclose(fin);
	_getch();
	return 0;
}