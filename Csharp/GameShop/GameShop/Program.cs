using System;

namespace GameShop
{
	class Item
	{
		protected string name;
		protected string description;
		protected int weight;
		protected int value;

		public Item(string n, string d, int w, int v)
		{
			name = n;
			description = d;
			weight = w;
			value = v;
		}

		virtual public void Describe()
		{
			Console.WriteLine ("name : " + name);
			Console.WriteLine ("description : " + description);
			Console.WriteLine ("weight : " + weight + " lbs");
			Console.WriteLine ("value : " + value + " gold coins");
		}
	}

	class Weapon : Item
	{
		int damage;

		public Weapon(string n, string d, int w, int v, int dm) : base(n, d, w, v)
		{
			name = n;
			description = d;
			weight = w;
			value = v;
			damage = dm;
		}

		override public void Describe()
		{
			base.Describe ();
			Console.WriteLine ("damage : " + damage);
		}
	}

	class Armor : Item
	{
		int defense;

		public Armor(string n, string d, int w, int v, int df) : base(n, d, w, v)
		{
			name = n;
			description = d;
			weight = w;
			value = v;
			defense = df;
		}

		override public void Describe()
		{
			base.Describe ();
			Console.WriteLine ("defense : " + defense);
		}
	}

	class main
	{
		public static void Main(string[] args)
		{
			Item Excalibur = new Weapon("Excalibur", "The legendary sword of King Arthur", 12, 1024, 24);
			Excalibur.Describe();

			Console.WriteLine ();

			Item Steel_Armor = new Armor ("Steel Armor", "Protective covering made by steel", 15, 805, 18);
			Steel_Armor.Describe ();
		}
	}
}
