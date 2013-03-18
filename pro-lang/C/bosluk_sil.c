#include<stdio.h>
#include<ctype.h>
#include<string.h>
int main(){
	char str[150];
	puts("Bir cumle giriniz =>");
	gets(str);
	int i;
	
	for (i = 0; i < strlen(str) ; i++){
		if (isalnum(str[i]))
			putchar(str[i]);
		if(str[i] == ' ' && str[i + 1] == ' ')
			continue;
		if(str[i] == ' ')
			putchar(str[i]);
	}
	return 0;
}
