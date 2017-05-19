#include <stdio.h>
#include <stdlib.h>

int arr[128] = {0, 2, 5, 8, 3, 9, 6, 1, 4, 7};
int arrR[128];

void RemoveNode(int index)
{
	
}

void main()
{
	printf("정렬 전 배열 상태 >>\n");
	
	int i;
	for(i = 1; i <= 100; i++)
	{
		arr[i] = rand() % 100 + 1;
		printf("%d   ", arr[i]);
		if(i % 10 == 0)
			printf("\n");
	}
	
	int node;
	for(node = 100; node > 0; node--)
	{
		for(i = 2; i <= node; i++)
		{
			int j = i;
			while(arr[j] > arr[j/2])
				{
					int temp = arr[j];
					arr[j] = arr[j/2];
					arr[j/2] = temp;
					
					if(j/2 == 1)
						break;
					else
						j /= 2;
				}
		}
		int temp = arr[1];
		arr[1] = arr[node];
		arr[node] = temp;
	}
	

	printf("\n\n정렬 후 배열 상태>>\n");
	for(i = 1; i <=100; i++)
	{
		printf("%d  ", arr[i]);
		if(i % 10 == 0)
			printf("\n");
	}
}
