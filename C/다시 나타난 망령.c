#include <stdio.h>

int arr[12] = {2,2,1,5,9,5,4,11,7,6,10,3};

void qs(int left, int right)
{
	int pivot = right, i = left, j = right-1;
	
	printf("<pivot : %d / i : %d / j : %d>\n", pivot+1, i+1, j+1);
	int k;
	for(k = 0; k < 12; k++)
	{
		printf("%d ", arr[k]);
	}
	printf("\n");

	while (i < j) {
		while (arr [pivot] > arr [i])
		{
			i++;
		}
		printf("i move to %d\n", i);
		
		while (arr [pivot] < arr [j])
		{
			j--;
		}
		printf("j move to %d\n", j);

		if (i > j)
			break;

		int temp = arr [i];
		arr [i] = arr [j];
		arr [j] = temp;
		
	}
	
	int temp = arr[i];
	arr[i] = arr[pivot];
	arr[pivot] = temp;
	
	printf("left side : %d to %d\n", left+1, i);
	printf("right sidde : %d to %d\n\n\n", i+2, right+1); 
	
	if(left < i-1)
		qs(left, i-1);
	if(i+1 < right)
		qs(i+1, right);
}

main(){
	qs(0,11);
	int i;
	for(i = 0; i < 12; i++)
	{
		printf("%d ", arr[i]);
	}
}
