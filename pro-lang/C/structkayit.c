#include <stdio.h>


struct kayit{
	char ad[10];
	long no;
	int sinif;
	};
int main(){
	
	struct kayit ogr;
	
	printf("Ogrenci Nosu : "); scanf("%ld",&ogr.no);
	printf("Ogrenci Adi: "); scanf("%s" , ogr.ad);
	printf("Ogrenci Sinifi: "); scanf("%d" ,&ogr.sinif);

	printf("\n*** Girilen bilgiler ***");

	printf("\nNo: %ld",ogr.no);
	printf("\nAdi: %s ",ogr.ad);
	printf("\nSinifi: %d ",ogr.sinif);
	return 0;
}
