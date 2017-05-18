using System;

namespace Program
{
	public class Computer
	{
		bool powerOn;
		public void Boot(){}
		public void Shutdown(){}
	}

	public class Notebook : Computer
	{
		bool fingerScan;
	}

	public static void Main(string[] args)
	{
		Computer c = new Computer();
		Notebook n = new Notebook();

		c.powerOn = true;
		n.powerOn = true;

		c.	
	}
}
