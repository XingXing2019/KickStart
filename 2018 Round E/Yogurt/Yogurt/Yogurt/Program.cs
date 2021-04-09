using System;
using System.Linq;

namespace Yogurt
{
	class Program
	{
		static void Main(string[] args)
		{
			var cases = Convert.ToInt32(Console.ReadLine());
			for (int i = 1; i <= cases; i++)
			{
				var line1 = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
				int N = line1[0], K = line1[1];
				var yogurts = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
				int res = EatYogurt(K, yogurts);
				Console.WriteLine($"Case #{i}: {res}");
			}
		}

		private static int EatYogurt(int K, int[] yogurts)
		{
			int res = 0, index = 0, today = 0;
			Array.Sort(yogurts);
			while (index < yogurts.Length)
			{
				int count = 0;
				while (index < yogurts.Length && count < K)
				{
					if (yogurts[index++] > today)
					{
						res++;
						count++;
					}
				}
				today++;
			}
			return res;
		} 
	}
}
