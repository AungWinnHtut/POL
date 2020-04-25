#pragma warning(disable : 4996)
#pragma warning(disable : 28183)
#pragma warning(disable : 6387)
#pragma warning(disable : 6031)

#include <stdio.h>
#include <stdlib.h>
#include <conio.h>

void fwritestring(void);
void getstring(char* strr, int count);

int main() {

    fwritestring();
    return(0);
}

void getstring(char* strr, int count)
{
    char ch = '\0';
    int i = 0;
    ch = getche();
    
    while((ch!='\n')&& (ch != '\r') &&(i<count))
    {
        
        strr[i++] = ch;
        ch = getche();
    }
}


void fwritestring(void)
{
    char str[50] =  "";
    int i = 0;
    
 
    printf("please enter a string: ");
    //scanf("%[^\n]", str);
    //fgets(str,sizeof(str),stdin);
    //gets_s(str);
    getstring(str,5);

    FILE* fp = NULL;
    fp = fopen("fwrite.txt", "w");
    if (fp == NULL)
    {
        printf("Err! Cannot open file");
        exit(1);
    }


   while((str[i]!='\0') && (str[i] !='\n'))
    {
        fputc(str[i++], fp);        
    }

   

    if (fp != NULL)
    {
        fclose(fp);
    }
    system("notepad fwrite.txt");
}


