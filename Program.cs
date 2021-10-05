using System;

namespace OpenKattis5
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.Write("Please enter N, W and H: ");

			string[] inputString = Console.ReadLine().Split(' ');

			int N = Int32.Parse(inputString[0]);
			int W = Int32.Parse(inputString[1]);
			int H = Int32.Parse(inputString[2]);
			double D = Math.Sqrt(W * W + H * H);

			for (int i = 0; i < N; i++)
			{
				Console.Write("Please enter length of match: ");
				int match = Int32.Parse(Console.ReadLine());
				if (match <= D)
				{
					Console.WriteLine("DA");
				}
				else
				{
					Console.WriteLine("NE");
				}
			}
		}
    }
}
