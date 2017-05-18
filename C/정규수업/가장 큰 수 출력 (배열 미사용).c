#include <stdio.h>

main(){
	int num;
	int coupleKing = 0, soloKing = 0;
	
	int i;
	for(i = 0; i < 8; i++)
	{
		scanf("%d", &num);
		if (num % 2 == 0 && num > coupleKing)
			coupleKing = num;
		else if (num % 2 != 0 && num > soloKing)
			soloKing = num;
	}
	
	if(coupleKing > 0)
		printf("%d ", coupleKing);
	if(soloKing > 0)
		printf("%d", soloKing);
}
