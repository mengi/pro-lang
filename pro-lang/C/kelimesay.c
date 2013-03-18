#include<stdio.h>

int kelime_say(char *str){
	int i = 0, sayac = 1;
	while (str[i] != '\0'){
		if (str[i] == ' ')
			sayac ++;
		i++;	
	}
	return sayac;
}

int harf_say(char *str){
	int i = 0 ,sayac = 0;
	while (*(str + i) != '\0'){
		if(* (str + i) == ' ')
			sayac ++;
		i++;
		}
		return (i - sayac);
}

int main(){
	char str[100];
	puts("Bir cumle giriniz");
	gets(str);
	printf("Kelime sayisi = %d \n", kelime_say(str));
	printf("Harf sayisi = %d", harf_say(str));
	return 0;
}
