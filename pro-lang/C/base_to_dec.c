
#include<stdio.h>
#define      ARRAY_SIZE      100
 
int base_to_dec(const char *str, int base);
 
int main()
{
   char a[ARRAY_SIZE];
 
   printf("\n Decimal  bir sayi giriniz: ");
   gets(a);
   printf("number = %d\n",  base_to_dec(a, 10));
   
   printf("Octal bir sayi giriniz: ");
   gets(a);
   printf("number = %d\n",  base_to_dec(a, 8));
   
   printf("Binary bir sayi giriniz: ");
   gets(a);
   printf("number = %d\n",  base_to_dec(a, 2));
   
   printf("Hexadecimal bir sayi giriniz: ");
   gets(a);
   printf("number = %d\n",  base_to_dec(a, 16));
 
   return 0;
}
/*******************************************/
int  base_to_dec(const char *str, int base){
   int number = 0, sign = 0, digit;
 
   while ((*str == ' ') || (*str == '\t'))
      str++;
 
   if (*str == '+')
      str++;
   else if (*str == '-') {
      str++;
      sign = 1;
   }
 
   for (;;) {
      digit = *str++;
      if (digit >= '0' && digit <= '9')
         digit -= '0';
      else if (digit >= 'a' && digit <= 'z')
         digit -= 'a' - 10;
      else if (digit >= 'A' && digit <= 'Z') 
         digit -= 'A' - 10;
      else
         break;
      if (digit >= base)
         break;
      number = number * base + digit;
   }
   return (sign) ? -number : number;
}


