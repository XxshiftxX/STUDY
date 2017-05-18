#include <stdio.h>

int arr[9] = {4,3,2,5,1,6,7,9,8};

void qs(int left, int right)
{
	int pivot = right, i = left, j = right-1;

	while (i <= j) {
		while (arr [pivot] <= arr [i])
		{
			i++;
		}
		printf("i move to %d\n", i);
		
		while (arr [pivot] >= arr [j])
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
	
	printf("left side : %d to %d\n", left, i-1);
	printf("right sidde : %d to %d\n\n\n", i+1, right); 
	
	if(left != i-1)
		qs(left, i-1);
	if(i+1 != right)
		qs(i+1, right);
}

main(){
	qs(0,4);
	int i;
	for(i = 0; i < 9; i++)
	{
		printf("%d", arr[i]);
	}
}
