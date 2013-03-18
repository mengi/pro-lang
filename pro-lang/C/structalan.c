#include <stdio.h>


typedef struct{
	int x;
	int y;
	}DRTGEN;


int alan(DRTGEN p1, DRTGEN p2){
	
	int farky, farkx, alan;
	
	farkx = (p2.x - p1.x);
    farky = (p2.y - p1.y);
    alan = farkx * farky;
	
	if (alan < 0)
		return alan * (-1);
	else
		return alan;
}	


int main(){
	
	DRTGEN p1, p2;
	printf("İlk noktayi gir x : ");
	scanf("%d",&p1.x);
	
	printf("İlk noktayi gir y : ");
	scanf("%d", &p1.y); 
    
    printf("İkinci noktayi gir x : ");
	scanf("%d",&p2.x);
	
	printf("İkinci noktayi gir y : ");  
    scanf("%d",&p2.y);
	
	printf ("Noktalrın olusturdugu dikdörtgen alani = %d", alan(p1, p2));
	return 0;
}
