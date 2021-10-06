using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenKattis5
{
    class Program
    {
        static void Main(string[] args)
        {
			/*
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
			} */
			IDictionary<char, int> alphaDict = new Dictionary<char, int>()
			{
				{'A', 0},{'B', 1},{'C', 2},{'D', 3},{'E', 4},{'F', 5},{'G', 6},{'H', 7},{'I', 8},{'J', 9},{'K', 10},{'L', 11},{'M', 12},{'N', 13},
				{'O', 14},{'P', 15},{'Q', 16},{'R', 17},{'S', 18},{'T', 19},{'U', 20},{'V', 21},{'W', 22},{'X', 23},{'Y', 24},{'Z', 25}
			};

			string nouns = Console.ReadLine();
			string deciphered1 = "";
			string deciphered2 = "";
			string decipheredFinal = "";

			int mid = nouns.Length / 2;

			string half1 = nouns.Substring(0,mid);
			string half2 = nouns.Substring(mid);

			int sumOfHalf1 = 0;
			for (int i = 0; i < mid; i++) 
			{
				var myVal = alphaDict[half1[i]];
				sumOfHalf1 += myVal;
			};
			for (int i = 0; i < mid; i++)
			{
				int newVal = alphaDict[half1[i]] + sumOfHalf1;
				if (newVal > 25)
				{
					newVal = newVal % 26;
				}
				string myKey = Convert.ToString(alphaDict.FirstOrDefault(x => x.Value == newVal).Key);
				deciphered1 += myKey;
			};

			int sumOfHalf2 = 0;
			for (int i = 0; i < mid; i++)
			{
				var myVal = alphaDict[half2[i]];
				sumOfHalf2 += myVal;
			};
			if (sumOfHalf2 > 25)
			{
				sumOfHalf2 = sumOfHalf2 % 26;
			}
			for (int i = 0; i < mid; i++)
			{
				int newVal = alphaDict[half2[i]] + sumOfHalf2;
				if (newVal > 25)
				{
					newVal = newVal % 26;
				}

				string myKey = Convert.ToString(alphaDict.FirstOrDefault(x => x.Value == newVal).Key);
				deciphered2 += myKey;
			};

			for (int i = 0; i < mid; i++)
			{
				var myVal = alphaDict[deciphered2[i]];
				sumOfHalf1 += myVal;
			};

			for (int i = 0; i < mid; i++)
			{
				int newVal = alphaDict[deciphered1[i]] + alphaDict[deciphered2[i]];
				if (newVal > 25)
				{
					newVal = newVal % 26;
				}
				string myKey = Convert.ToString(alphaDict.FirstOrDefault(x => x.Value == newVal).Key);
				decipheredFinal += myKey;
			};
			Console.WriteLine($"{decipheredFinal}");
		}
	}
}
