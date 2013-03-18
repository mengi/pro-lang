#include <stdio.h>
#include <string.h>

int main(void) {
	char *c = "muhammet";
	int i = 0, j = 0;

	for(i=0; i < strlen(c)-1; i++) {
		for(j=0; j <= i; j++) {
			printf("%c", c[j]);
		}
		printf("\n");
	}

	for(; i >= 0; i--) {
		for(j=0; j <= i; j++) {
			printf("%c", c[j]);
		}
		printf("\n");
	}

	return 0;
}
