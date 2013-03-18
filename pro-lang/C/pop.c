#include<stdio.h>
#include<string.h>

int append(char *s){
	int i = 0;
	while (s[i] != '\0'){
		printf("%c", s[i - 1]);
		i++;
	}
	return 0;
}

int main(){
	char *str = "muhammet";
	printf("%c", append(str));
	return 0;	

}
