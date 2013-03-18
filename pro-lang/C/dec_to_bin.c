#include <stdio.h>

int main(void) {
	int dec;
	printf("Bir sayi giriniz :");
	scanf("%d", &dec);
	int binary[100];
	int i = 0, k = 0, j = 0;

	printf("dec: %d\nbinary: ", dec);

	for (i=0; dec > 0; i++) {
		k = dec % 2;
		binary[i] = k;
		dec /= 2;
	}

	for(j=0; j < i; j++){
		printf("%d", binary[i - j - 1]);
	}
	printf("\n");
	return 0;
}
