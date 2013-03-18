#include <stdio.h>

typedef struct {
	int x;
	int y;
	}NOKTA;
	
void denklem_bul(NOKTA p1,NOKTA p2){
	int farkx, farky;
	
	
	farkx = (p2.x - p1.x);
    farky = (p2.y - p1.y);
     
    printf("%dy = %dx - %d", farkx, farky, ((-1) * (farkx * p1.y) + (p1.x * farky)));

}
	
	
int main(){
	
	NOKTA p1, p2;
	
	printf("İlk noktayi gir x : ");
	scanf("%d",&p1.x);
	
	printf("İlk noktayi gir y : ");
	scanf("%d", &p1.y); 
    
    printf("İkinci noktayi gir x : ");
	scanf("%d",&p2.x);
	
	printf("İkinci noktayi gir y : ");  
    scanf("%d",&p2.y);
	
	denklem_bul(p1, p2);
	return 0;
	
}	
