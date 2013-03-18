#include <stdio.h>
#include <string.h> 
#include <ctype.h> 

int pars_int(char s[]) {
	int i = 0;
	int n = 0;
	for (i = 0; i < strlen(s); i++){ 
		if (isdigit(s[i]))
				n = n * 10 + (s[i] - 48); 
		if ((s[i] == ',') || (s[i] ==  '.'))
                break;
        }

        if (s[0] == '-')
		     return n = n * (-1);

	   else 
		     return n;

}	

int main() {
	printf("%d \n",pars_int("12ab4k57"));
	printf("%d \n",pars_int("-12ab4k57"));
	printf("%d \n",pars_int("-12ab4k57,125698abc"));
	printf("%d \n",pars_int("12ab4h57.0075"));
	return 0;
}
