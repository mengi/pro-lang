#include <stdio.h>
#define ROT 13

int main(void)
{
  int c, c_yeni;

  while((c = getchar()) != EOF){
    if(c >= 'A' && c <= 'Z'){
      if((c_yeni = c + ROT) <= 'Z')
        putchar(c_yeni);
      else{
        c_yeni = c - ROT;
      putchar(c_yeni);
      }
    }
    else if(c >= 'a' && c <= 'z'){
      if((c_yeni = c + ROT) <= 'z')
        putchar(c_yeni);
      else{
        c_yeni = c - ROT;
      putchar(c_yeni);
      }
    }
  }
  return 0;
}

