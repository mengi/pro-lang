#include <stdio.h>

int ekok(int sayi1, int sayi2){
	int max = 0;
	
	if (sayi1 > sayi2)
		max = sayi1;
	
	else max = sayi2;
	
	while ((max % sayi1 != 0)  || (max % sayi2 != 0))
		max += 1; 
	
	return max;
}

int ebob(int sayi1, int sayi2, int max){
	return (sayi1 * sayi2) / max;
}

int main(){
	int a = 36, b = 24;
	printf("sayilarin ekok = %d \n", ekok(a, b));
	printf("sayilarin ebob = %d", ebob(a, b, ekok(a, b)));
 	return 0; 
}


