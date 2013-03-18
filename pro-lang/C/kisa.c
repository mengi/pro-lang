#include<stdio.h>
#include<string.h>

int kisalt(char str[], int uzunluk){
	int i;
	for (i = 0; i < uzunluk; i++){
		if(i == 0)
			printf("%c", str[i]);
		if(str[i] == ' ')
			printf("%c", str[i + 1]);
		
	}
	return 0;
}



int main(void){
	char *str = "Muhammet Enginar Mühendis Olacak";
	printf("%c", kisalt(str, strlen(str)));
	return 0;
}
