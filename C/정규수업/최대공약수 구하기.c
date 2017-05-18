#include <stdio.h>
min(int a, int b){
	if(a > b)
		return b;
	else
		a;
}

main(){
	int inA, inB, inC;
	int max;
	
	scanf("%d %d %d", &inA, &inB, &inC);
	
	int i;
	for(i = 1; i <= min(min(inA, inB), inC); i++)
	{
		if(inA % i == 0 && inB % i == 0 && inC % i == 0)
			max = i;
	}
	
	printf("%d", max); 
}
