using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedsSolution
{
	public class SpeedsSolution
	{
		static void Main(string[] args)
		{
			var carSpeeds = ReadCarSpeeds();
			var carGroups = CreateCarGroups(carSpeeds);
			var longestCarGroups = FindLongestCarGroups(carGroups);
			var carGroupsSpeedsSum = CalculateCarGroupsSpeedsSum(longestCarGroups);
			carGroupsSpeedsSum.Sort();
			Console.WriteLine(carGroupsSpeedsSum[carGroupsSpeedsSum.Count - 1]);
		}

		private static List<int> CalculateCarGroupsSpeedsSum(List<List<int>> carGroups)
		{
			var result = new List<int>();

			for (var i = 0; i < carGroups.Count; i++)
			{
				var currentCarGroupSpeedsSum = 0;
				for (var j = 0; j < carGroups[i].Count; j++)
				{
					currentCarGroupSpeedsSum += carGroups[i][j];
				}
				result.Add(currentCarGroupSpeedsSum);
			}

			return result;
		}

		private static List<List<int>> FindLongestCarGroups(List<List<int>> carGroups)
		{
			var longestGroups = new List<List<int>>();
			longestGroups.Add(carGroups[0]);

			for (var i = 1; i < carGroups.Count; i++)
			{
				if (carGroups[i].Count == longestGroups[0].Count)
					longestGroups.Add(carGroups[i]);
				else if (carGroups[i].Count > longestGroups[0].Count)
				{
					longestGroups.Clear();
					longestGroups.Add(carGroups[i]);
				}
			}

			return longestGroups;
		}

		private static List<List<int>> CreateCarGroups(int[] carSpeeds)
		{
			var carGrpoups = new List<List<int>>();

			var currentCarGroupLength = 1;
			for (var i = 0; i < carSpeeds.Length; i += currentCarGroupLength)
			{
				var carsGroup = CreateCarsGrouop(carSpeeds, i);
				carGrpoups.Add(carsGroup);
				currentCarGroupLength = carsGroup.Count;
			}

			return carGrpoups;
		}

		private static List<int> CreateCarsGrouop(int[] carSpeeds, int startCarSpeedIndex)
		{
			var carsGroup = new List<int>();
			carsGroup.Add(carSpeeds[startCarSpeedIndex]);

			if (startCarSpeedIndex == carSpeeds.Length - 1)
				return carsGroup;

			if (carSpeeds[startCarSpeedIndex] >= carSpeeds[startCarSpeedIndex + 1])
				return carsGroup;

			var minCarsSpeed = carSpeeds[startCarSpeedIndex];

			carsGroup.Add(carSpeeds[startCarSpeedIndex + 1]);

			if (startCarSpeedIndex + 1 == carSpeeds.Length - 1)
				return carsGroup;

			for (var i = startCarSpeedIndex + 2; i < carSpeeds.Length; i++)
			{
				if (carSpeeds[i] <= minCarsSpeed) break;

				carsGroup.Add(carSpeeds[i]);
			}

			return carsGroup;
		}

		private static int[] ReadCarSpeeds()
		{
			var carsCount = int.Parse(Console.ReadLine());

			var cars = new int[carsCount];

			for (var i = 0; i < carsCount; i++)
			{
				cars[i] = int.Parse(Console.ReadLine());
			}

			return cars;
		}
	}
}