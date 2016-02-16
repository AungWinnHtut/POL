#include<stdio.h>
#include<conio.h>
//nclude <windows.h>
//#include <tchar.h>
#include<process.h> //system()

int main()
{
	int iAns;
	system("cls");
	printf("Advanced APK installer\n");
	printf("======================\n");
	printf("1 - Games\n");
	printf("2 - Musics\n");
	printf("3 - Exit\n");
	printf("Please Choose One of this  ");
	scanf("%d",&iAns);
	//printf("the ans is %d",iAns);
	if(iAns==1)
	{
		system("adb install game.apk");
	}
	if(iAns==2)
	{
		system("adb install music.apk");
	}
	if(iAns==3)
	{
		exit(0);
	}

	_getch();
	return 0;
}





//void test()// _tmain(int argc, TCHAR *argv[])
//{
//   WIN32_FIND_DATA FindFileData;
//   HANDLE hFind;
//   argc==2;
//   //if( argc != 2 )
//   //{
//   //   _tprintf(TEXT("Usage: %s [target_file]\n"), argv[0]);
//	  //_getch();
//   //   return;
//   //}
//   argv[1]="*.apk";
//   _tprintf (TEXT("Target file is %s\n"), argv[1]);
//   hFind = FindFirstFile(argv[1], &FindFileData);
//   if (hFind == INVALID_HANDLE_VALUE) 
//   {
//      printf ("FindFirstFile failed (%d)\n", GetLastError());
//	  _getch();
//      return;
//   } 
//   else 
//   {
//      _tprintf (TEXT("The first file found is %s\n"), 
//                FindFileData.cFileName);
//      FindClose(hFind);
//   }
//   _getch();
//}