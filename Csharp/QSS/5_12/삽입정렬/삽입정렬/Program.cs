using System;

namespace sort
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			public int[] arr = new int[9];
			MainClass m = new MainClass ();
			arr [0] = 8;
			arr [1] = 3;
			arr [2] = 2;
			arr [3] = 5;
			arr [4] = 1;
			arr [5] = 4;
			arr [6] = 7;
			arr [7] = 9;
			arr [8] = 6;
			m.qs (0, 8);
			Console.Write (arr [0] + " " + arr [1] + " " + arr [2] + " " + arr [3] + " " + arr [4] + " " + arr [5] + " " + arr [6] + " " + arr [7] + " " + arr [8]);
		}

		public void qs(int left, int right)
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
		}
	}
}
