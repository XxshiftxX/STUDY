#include <stdio.h>

main(){
	int coupleKing = 0, soloKing = 0;
	int get[8];
	
	int i;
	for(i = 0; i < 8; i++)
	{
		scanf("%d", get+i);
	}
	
	for(i = 0; i < 8; i++)
	{
		if (get[i] % 2 == 0 && get[i] > coupleKing)
			coupleKing = get[i];
		else if (get[i] % 2 != 0 && get[i] > soloKing)
			soloKing = get[i];
	}
	
	if(coupleKing > 0)
		printf("%d ", coupleKing);
	if(soloKing > 0)
		printf("%d", soloKing);
}
