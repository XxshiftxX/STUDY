#include <iostream>

int main(void){
	int lineNum;
	
	std::cin>>lineNum;
	
	char get[lineNum][51];
	for(int i = 0; i < lineNum; i++)
	{
		std::cin>>get[i];
	}
	
	int tf, process;
	for(int i = 0; i < lineNum; i++)
	{
		process = 0, tf = 1;
		int j = 0;
		while(get[i][j] != NULL)
		{
			if(get[i][j] == '(')
				process++;
			else if(get[i][j] == ')')
			{
				if(process-1<0)
				{
					tf = 0;
					break;
				}
				else
					process--;
			}
			j++;
		}
		
		if(process != 0)
			tf =0;
		
		if(tf == 0)
			std::cout<<"NO"<<std::endl;
		else
			std::cout<<"YES"<<std::endl;
	}
}
