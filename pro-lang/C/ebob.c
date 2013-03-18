
#include <stdio.h>

int max(int a, int b){
	if (a < b)
		return b;
	else
		return a;
}

int main(){
	int n, m, kalan;
	printf("ilk sayi giriniz:");
	scanf("%d",&n);
	printf("ilk sayi giriniz:");
	scanf("%d", &m);
	n = max(n, m);
	for ( ; ; ){
		if (n % m != 0){
			kalan = n % m;
			n = m;
			m = kalan;
		}
		else if(n % m == 0){
			printf("%d",m);
			break;
			
		}else{
			printf("ebob sonucu = %d",kalan);
			break;
		}
	}
	return 0;
}

