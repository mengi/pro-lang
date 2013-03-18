#include<stdio.h>

int yuvarla(float f){
	 return (f - (int) f) < 0.5 ? (int) f : (int) f + 1;
}

int main()
{ 
	int x = yuvarla(1.2);
	
	int y = yuvarla(2.5);
	
	int z = yuvarla(3.7);
	 
    printf("%d\n", x ) ;
    printf("%d\n", y ) ;
    printf("%d\n", z ) ;
    return 0;
}
