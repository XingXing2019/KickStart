using System;
using System.Linq;

namespace Retype
{
	class Program
	{
		static void Main(string[] args)
		{
			var cases = Convert.ToInt32(Console.ReadLine());
			for (int i = 1; i <= cases; i++)
			{
				var line1 = Console.ReadLine().Split(' ').Select(x => Convert.ToInt64(x)).ToArray();
				long N = line1[0], K = line1[1], S = line1[2];
				long res = Retype(N, K, S);
				Console.WriteLine($"Case #{i}: {res}");
			}
		}

		private static long Retype(long N, long K, long S)
		{
			return Math.Min(K + N, 2 * K - 2 * S + N);
		}
	}
}
