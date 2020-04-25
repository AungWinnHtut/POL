#pragma warning(disable : 4996)
#pragma warning(disable : 28183)
#pragma warning(disable : 6387)
#pragma warning(disable : 6031)

#include <stdio.h>
int fLen(char* fname);
int fLen2(char* fname);

int main() {

    int l=fLen2("file.txt");
    printf("file size is %d\n\n", l);
    return(0);
}


int fLen2(char* fname)
{
    FILE* fp;
    int len = 0;
    char ch = '\0';

    fp = fopen(fname, "r");
    if (fp == NULL) {
        perror("Error opening file");
        return(-1);
    }

    fseek(fp, 0, SEEK_END);
    len = ftell(fp);


    fclose(fp);
    return len;
}


int fLen(char* fname)
{

    FILE* fp;
    int len = 0;
    char ch = '\0';

    fp = fopen(fname, "r");
    if (fp == NULL) {
        perror("Error opening file");
        return(-1);
    }

    while (1)
    {
        ch = fgetc(fp);
        if (ch == EOF)
        {
            break;
        }
        //printf("%c", ch);
        len++;
    }

    
    fclose(fp);
    return len;

}