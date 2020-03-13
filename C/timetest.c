#include <stdio.h>

int main () {


   for(unsigned hour=0;hour<24;hour++)
   {
       for(unsigned minute=0;minute<=60;minute++)
       {
            for(unsigned second=0;second<=60;second++)
            {
                printf("%d Hours %d minutes %d seconds\n",hour,minute,second);
            }
       }
   }

   return 0;
}
