#include<stdio.h>
#include<conio.h>
char text11[100];
char text22[100];
char text33[100];


void fileWrite(char *fileName,char *text){
    FILE *fWri;
    fWri = fopen(fileName,"w");
    fputs(text,fWri);
    fclose(fWri);
}

void fileRead(char *fileName){
    FILE *fRe;
    char text1;
    char text2;
    char text3;
	int index1 = 0;
	int index2 = 0;
	int index3 = 0;

    fRe = fopen(fileName,"r");
    while(1){
        text1 = fgetc(fRe);
        index1 += 1;
        if(text1 == ' ')
            break;
        else{
            printf("%c",text1);
            text11[index1] = text1;
            }
    }
    printf("\n\n\n");
    while(1){
        text2 = fgetc(fRe);
        index2 += 1;
        if(text2 == '\n')
            break;
        else
            printf("%c",text2);
            text22[index2] = text2;
    }
    printf("\n\n\n");
    while(1){
        text3 = fgetc(fRe);
        index3 += 1;
        text33[index3] = text3;
        if(text3 == EOF){
            break;
            }
        else
            printf("%c",text3);
    }

    fclose(fRe);
}

int main(){
	int index1 = 0;
	int index2 = 0;
	int index3 = 0;
    fileWrite("File1.txt","Hello! I am MTH!\nI am a student!");
    fileRead("File1.txt");
    printf("\n");
    for(int i=0;i<20;i++){
        printf("%c",text11[i]);
    }
    printf("\n");
    for(int j=0;j<20;j++){
        printf("%c",text22[j]);
    }
    printf("\n");
    for(int k=0;k<20;k++){
        printf("%c",text33[k]);
    }
	_getch();
    return 0;
}

