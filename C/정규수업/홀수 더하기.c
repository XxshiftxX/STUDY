#include <stdio.h>

main(){
	int count = 0, sum = 0, max;
	int i;
	
	scanf("%d", &max);
	
	for(i = 1; sum < max; i+=2, count++)
		sum += i;
	
	printf("%d %d", count, sum);
}
