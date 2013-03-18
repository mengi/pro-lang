#include <stdio.h>
#include <string.h>

int ara(char *dizi, char *hece){
	int boyut1 = strlen(dizi), boyut2 = strlen(hece);
	int i, j;
	for (i = 0; i < boyut1; i++){
		if (dizi[i] == hece[j]){
			for (j = 0; j < boyut2; j++){
				if (dizi[i + j] != hece[j]){
					return 0;
				}
			}
		}
		
	}if(j == 0)
		return 0;
	return 1;
}
int main(void) {
	char kelime[20];
	char hece[20];

	printf("kelime gir = ");
	scanf("%s", kelime);
	printf("hece gir = ");
	scanf("%s",hece);

	if (ara(kelime, hece))
		printf("True");
	else
		printf("False");

	printf("\n");
	return 0;
}
