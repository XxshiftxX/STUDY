#include <stdio.h>

int input; 
int yarr[100];
int arr[100];

void sort(){
	int temp;
	
	int i, j;
	for(i = 0; i < input; i++)
	{
		for (j = i+1; j < input; j++)
		{
			if(arr[i] < arr[j])
			{
				//printf("swap %d and %d\n", arr[i], arr[j]);
				temp = arr[i];
				arr[i] = arr[j];
				arr[j] = temp;
				//printf("%d %d %d %d\n", arr[0], arr[1], arr[2], arr[3]);
			}
		}
	}
	printf("\n\n");
}

int search(int n)
{
	int i;
	for(i = 0; i < input; i++)
	{
		if(n == arr[i])
			return i;
	}
}

main(){
	scanf("%d", &input);
	
	int i;
	for(i = 0; i < input-1; i++){
		scanf("%d ", &arr[i]);
		yarr[i] = arr[i];
	}
	scanf("%d", &arr[input-1]);
	yarr[i] = arr[i];
		
	sort();
	
	printf(" ���� ��� : ");
	for(i = 0; i < input; i++)
		printf("%d ", arr[i]);
	printf("\n");
	
	for(i = 0; i < input; i++)
	{
		printf("%d�� �л��� %d���Դϴ�\n", i+1, search(yarr[i]) + 1);
	}
}
