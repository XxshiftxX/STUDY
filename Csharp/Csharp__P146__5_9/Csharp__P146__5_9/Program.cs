using System;

namespace Propert
{
	class Circle
	{
		double pi = 3.14;
		double piI = 3;

		public double Pi
		{
			get { return pi; }
			set { pi = value; piI = value + value;}
		}

		public double PP 
		{
			get { return piI; }
		}
	}

	class MainClass
	{
		public static void Main(string[] args)
		{
			Circle o = new Circle();
			Circle p = new Circle ();

			Console.WriteLine (p.Pi);
			Console.WriteLine (o.Pi);
			o.Pi = 3.14159;
			Console.WriteLine (p.Pi);
			Console.WriteLine (o.Pi);

			Console.WriteLine (o.PP);


		}
	}
}
