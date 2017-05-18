#include <stdio.h>

main(){
	int mult, rlt, i;
	scanf("%d", &mult);
	for(rlt = mult, i = 2; rlt < 100; rlt = mult * i, i++){
		printf("%d ", rlt);
		if(rlt % 10 == 0)
			break;
	}
}
