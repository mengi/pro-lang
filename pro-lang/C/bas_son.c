#include<stdio.h>
#include<string.h>
#include<stdio.h>

int main(){
	char *str = "muhammet enginar";
	int i = 0, k; 
	if(i == 0)
		printf("%c", toupper(str[i]));
	for (k = 1; k < strlen(str) - 1 ; k++){
		printf("%c", str[k]);
		}
	printf("%c",toupper(str[strlen(str) - 1]));
	return 0;	
}
