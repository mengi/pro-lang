#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main(){
	
	char *dizi = "ali";
	char *cpy;
	
	cpy = (char *) malloc(sizeof(char)*strlen(dizi));
	
	int i = 0;
	for (i = 0; dizi[i] != '\0'; i++)
		cpy[i] = dizi[i];

	printf("%s",cpy);
	return 0;
}
