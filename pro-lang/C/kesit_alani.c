#include <stdio.h>

typedef struct {
       int x;
       int y;
}nokta;
typedef struct {
       nokta *a;
       nokta *b;
}dik;
int 
kesismeAlani(dik *d, dik *k)
{
               int dXust, dXalt, dYust, dYalt;
               int kXust, kXalt, kYust, kYalt;
               
               if(d->a->x > d->b->x){
                          dXust = d->a->x;
                          dXalt = d->b->x;
               }else{
                          dXust = d->b->x;
                          dXalt = d->a->x;
               }
               if(d->a->y > d->b->y){
                          dYust = d->a->y;
                          dYalt = d->b->y;
               }else{
                          dYust = d->b->y;
                          dYalt = d->a->y;
               }
               if(k->a->x > k->b->x){
                          kXust = k->a->x;
                          kXalt = k->b->x;
               }else{
                          kXust = k->b->x;
                          kXalt = k->a->x;
              }
              if(k->a->y > k->b->y){
                          kYust = k->a->y;
                          kYalt = k->b->y;
              }else{
                          kYust = k->b->y;
                          kYalt = k->a->y;
              }
              
              
              int lXust, lXalt, lYust, lYalt;
              if((dXust > kXust)){
                       lXust = kXust;
              }else{
                       lXust = dXust;
              }
              if((dXalt > kXalt)){
                       lXalt = dXalt;
              }else{
                       lXalt = kXalt;
              }
              if((dYust > kYust)){
                       lYust = kYust;
              }else{
                       lYust = dYust;
              }
              if((dYalt > kYalt)){
                       lYalt = dYalt;
              }else{
                       lYalt = kYalt;
              }
              if((lXust - lXalt)> 0 && (lYust - lYalt)> 0)
                        return (lXust - lXalt) * (lYust - lYalt);
              else
               return 0;
}

int 
main(void)
{
          nokta *a = malloc(sizeof(nokta));
          a->x = 0;
          a->y = 0;
          nokta *b = malloc(sizeof(nokta));
          b->x = 10;
          b->y = 10; 
          dik *d = malloc(sizeof(dik));
          d->a = a;
          d->b = b;
          
          nokta *soru = malloc(sizeof(nokta));
          soru->x = 25;
          soru->y = 25;
          
          nokta *sor = malloc(sizeof(nokta));
          sor->x = -6;
          sor->y = -6;
          
           
          dik *k = malloc(sizeof(dik));
          k->a = sor;
          k->b = soru;
          printf("%d\n", kesismeAlani(d,k));          
getch();
}
