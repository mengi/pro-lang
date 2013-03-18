#include <stdio.h>


typedef struct{
	int re;
	int sa;
}COMPLEX;


void topla(COMPLEX c1, COMPLEX c2){
	
	int sumre, sumsa ;
	sumre = (c1.re + c2.re);
	sumsa = (c1.sa + c2.sa);
	printf("topla = %d + %di \n",sumre, sumsa);
}

void cikar(COMPLEX c1, COMPLEX c2){
	
	int sumre, sumsa ;
	sumre = (c1.re - c2.re);
	sumsa = (c1.sa - c2.sa);
	printf("cikar = %d + %di \n",sumre, sumsa);

}



void carp(COMPLEX c1, COMPLEX c2){
	int sumre, sumsa ;
	
	sumre = (c1.re * c2.re) + ((-1) * (c1.sa * c2.sa));
	sumsa = (c1.re * c2.sa) + (c1.sa * c2.re);
	
	printf("carpma = %d + %di \n", sumre, sumsa);

}


void bolme(COMPLEX c1, COMPLEX c2){
	float sumre, sumsa ;
	float esit;
	c2.sa = c2.sa * (-1);
	esit = (c2.re * c2. re) + (c2.sa * c2.sa);
	sumre = ((c1.re * c2.re) + ((-1) * (c1.sa * c2.sa))) / esit ;
	sumsa = ((c1.re * c2.sa) + (c1.sa * c2.re)) / esit;
	printf("bolme = %f + %fi \n", sumre, sumsa);

}
	

int main(){
	
	COMPLEX c1, c2;
	c1.re = 1;
	c1.sa = 2;
	c2.re = 2;
	c2.sa = 3;
	
	topla(c1, c2);
	cikar(c1, c2);
	carp(c1, c2);
	bolme(c1, c2);
	return 0;
	}
