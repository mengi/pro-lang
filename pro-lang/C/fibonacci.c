#include <stdio.h>
int main(){
	int a = 0, b = 1, c, sayi;
	printf("sayi giriniz:");
	scanf("%d",&sayi);
	while (b < sayi){
		a = b;
		b = c;
		c = a + b;
	}
	printf("%d",c);
	return 0;
}
