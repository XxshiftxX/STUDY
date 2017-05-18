#include <stdio.h>

int arr[9] = {4,3,2,5,1,6,7,9,8};

void qs(int left, int right)
{
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
}

main(){
	qs(0,4);
	int i;
	for(i = 0; i < 9; i++)
	{
		printf("%d", arr[i]);
	}
}
