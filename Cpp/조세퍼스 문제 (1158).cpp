#include <iostream>

main(){
	int m, n;

	std::cin>>n;
	//std::cout<<" ";
	std::cin>>m;
	int point = m - 1;
	int queue[n] = {0}, output[n] = {0};

	for(int i = 0; i < n; i++)
		queue[i] = i+1;
	
	for(int i = 0; i < n; i++)
	{
		output[i] = queue[point];
		queue[point] = 0;
		
		for(int j = 0; j < m;)
		{
			if(output[n - 1] != 0)
				break;
			point++;
			if(point == n)
			{
				point = 0;
			}
			if(queue[point] == 0)
			{
				continue;
			}
			j++;
		}
	}
	
	std::cout<<"<";
	for(int i = 0; i < n; i++)
	{
		std::cout<<output[i];
		if(i != n-1)
			std::cout<<", ";
	}
	std::cout<<">";
}
