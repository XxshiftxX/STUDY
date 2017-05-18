#include <stdio.h>

int arr[9] = {8,3,2,5,1,4,7,9,6};

void qs(int left, int right)
{
	printf("left : %d  right : %d\n", left, right);
	int pivot = right, i = left, j = right-1;

	while (i <= j) {
		while (arr [pivot] > arr [i])
			i++;
		
		while (arr [pivot] < arr [j])
			j--;

		if (i > j)
			break;

		int temp = arr [i];
		arr [i] = arr [j];
		arr [j] = temp;
	}

	int temp = arr[i];
	arr[i] = arr[pivot];
	arr[pivot] = temp;
	
	for(i = 0; i < 9; i++)
	{
		printf("%d", arr[i]);
	}
	printf("\n");
	
	printf("i : %d\n", i);
	if(left != i-1)
		qs(left, i-1);
	if (i+1 != right)
		qs(i+1, right);
}

main(){
	qs(0,8);
	int i;
	for(i = 0; i < 9; i++)
	{
		printf("%d", arr[i]);
	}
}
