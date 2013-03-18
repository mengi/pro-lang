#include <stdio.h>
#include <string.h>
int main(){
	char *str = "muhammet";
	int i, j;
	for (i = 0; i < strlen(str); i++){
		for (j = i; j <strlen(str) ; j++){
			printf("%c", *(str + j));
			}
		for (j = 0; j < i; j++){
			printf("%c", *(str + j));
			}
		printf("\n");
		}
	return 0;
}
