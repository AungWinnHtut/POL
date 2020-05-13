#pragma warning(disable : 4996)
#pragma warning(disable : 28183)
#pragma warning(disable : 6387)
#pragma warning(disable : 6031)



#include<stdio.h>

int main()
{
	int ko = 0;

	auto int g=2;
	printf("%d", g);
	printf("%d", &g);

	if(1)
	{
		auto int g = 4;
		if (1)
		{
			auto int g = 5;
		}

	}


	return 0;
}