#include <stdio.h>
#include <string.h>

int palidrom(char *str){
	int uz = strlen(str), i = 0;
	while(i < uz){
		if (str[i] != str[uz - i - 1]){
			return 0;
		}
		i++;
	}
	return 1;
}

int main(){
	char str[] = "radar";
	
	if (palidrom(str))
		printf("palidrom");
	else
		printf("palidrom degil");
	
	return 0;
}	
