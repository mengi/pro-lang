#include <stdio.h>

int main(void) {
	int sayi;

	printf("Sayi gir(sınır 9999 ama dahil bu sayi ): ");
	scanf("%d", &sayi);

	if (sayi > 9999 || sayi < 0)
		printf("0-999 arlığında sayi giriniz\n");
	else {
		while(1) {
			switch (sayi/1000) {
				case 9: printf("Dokuzbin");break;
				case 8: printf("Sekizbin");break;
				case 7: printf("Yedibin");break;
				case 6: printf("Altibin");break;
				case 5: printf("Besbin");break;
				case 4: printf("Dortbin");break;
				case 3: printf("Ucbin");break;
				case 2: printf("İkibin");break;
				case 1: printf("bin");break;
			}
			sayi %= 1000;
			switch (sayi/100) {
				case 9: printf("Dokuzyuz");	break;
				case 8: printf("Sekizyuz");	break;
				case 7: printf("Yediyuz");	break;
				case 6: printf("Altiyuz");	break;
				case 5: printf("Besyuz");	break;
				case 4: printf("Dortyuz");	break;
				case 3: printf("Ucyuz");	break;
				case 2: printf("İkiyuz");	break;
				case 1: printf("Yuz");		break;
			}
			sayi %= 100;
			switch (sayi/10) {
				case 9: printf( "doksan" ); break;
				case 8: printf( "seksen" ); break;
				case 7: printf( "yetmis" ); break;
				case 6: printf( "altmıs" ); break;
				case 5: printf( "elli" ); 	break;
				case 4: printf( "kırk" ); 	break;
				case 3: printf( "otuz" ); 	break;
				case 2: printf( "yirmi" ); 	break;
				case 1: printf( "on" ); 	break;
			}
			switch (sayi % 10) {
				case 9: printf( "dokuz" ); 	break;
				case 8: printf( "sekiz" ); 	break;
				case 7: printf( "yedi" ); 	break;
				case 6: printf( "alti" ); 	break;
				case 5: printf( "bes" );	break;
				case 4: printf( "dort" ); 	break;
				case 3: printf( "üc" ); 	break;
				case 2: printf( "iki" );	break;
				case 1: printf( "bir" );	break;
				}
		break;
		}
	}

	if (sayi == 0)
		printf("sifir");
	return 0;
}
