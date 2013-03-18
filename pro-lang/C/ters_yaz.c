#include <stdio.h>
#include <string.h>
#include <stdlib.h>
int main(){
	char *l = "muhammet enginar";
	int uz = strlen(l);
	ters_yaz(l, uz);
	return 0;  
}

int ters_yaz(char *str, int boyut){
	char *ptr = calloc(boyut, sizeof(char));
	int i;
	for (i = 0; i < boyut ; i++){
		ptr[i] = str[boyut - 1 - i];
	}
	printf("%s", ptr);
	return 0;
}
