#include <stdio.h>

int sq(int a, int b)
{
	int i, rtn = a;
	for(i = 0; i < b; i++)
	{
		rtn *= a;
	}
	return rtn;
}

int f(int a)
{
	int i, rtn = 0;
	int arr[4];

	for(i = 0; i < 4; i++)
	{
		arr[i] = a%10;
		a /= 10;
	}
	for(i = 0; i < 4; i++)
	{
		//printf("%d ÀÌ¶û %d\n", arr[i], arr[i] * sq(10, 3-i));
		rtn += arr[i] * sq(10, 3-i);
	}
	
	while(rtn % 10 == 0)
		rtn /= 10;
	
	return rtn;
}

main(){
	int input, out;
	scanf("%d", &input);
	printf("È¸¹®Àº %d\n\n", f(input));
	out = f(input) + input;
	
	if(out == f(out))
		printf("YES!");
	else
		printf("No!");
}
