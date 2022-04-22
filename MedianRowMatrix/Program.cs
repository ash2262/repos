using System;

namespace MedianRowMatrix
{
    class Program
    {
		static int binaryMedian(int[,] m,
						int r, int c)
		{
			int max = int.MinValue;
			int min = int.MaxValue;

			for (int i = 0; i < r; i++)
			{
				// Finding the minimum
				// element
				if (m[i, 0] < min)
					min = m[i, 0];

				// Finding the maximum
				// element
				if (m[i, c - 1] > max)
					max = m[i, c - 1];
			}

			int desired = (r * c + 1) / 2;
			while (min < max)
			{
				int mid = min + (max - min) / 2;
				int place = 0;
				int count = 0;

				// Find count of elements
				// smaller than mid
				for (int i = 0; i < r; ++i)
				{
					count = Array.BinarySearch(
							GetRow(m, i), mid);

					// If element is not found
					// in the array the binarySearch()
					// method returns (-(insertion_
					// point) - 1). So once we know
					// the insertion point we can
					// find elements Smaller than
					// the searched element by the
					// following calculation
					if (count < 0)
						count = Math.Abs(count) - 1;

					// If element is found in the
					// array it returns the index(any
					// index in case of duplicate). So
					// we go to last index of element
					// which will give the number of
					// elements smaller than the number
					// including the searched element.
					else
					{
						while (count < GetRow(m, i).GetLength(0) &&
							m[i, count] == mid)
							count += 1;
					}

					place = place + count;
				}

				if (place < desired)
					min = mid + 1;
				else
					max = mid;
			}
			return min;
		}

		public static int[] GetRow(int[,] matrix,
								int row)
		{
			var rowLength = matrix.GetLength(1);
			var rowVector = new int[rowLength];

			for (var i = 0; i < rowLength; i++)
				rowVector[i] = matrix[row, i];

			return rowVector;
		}

		// Driver code
		public static void Main(String[] args)
		{
			int r = 3, c = 3;
			int[,] m = {{1,3,5,2},
			{2,6,9,2},
			{3,6,9,4} };

			Console.WriteLine("Median is " +
								binaryMedian(m, r, c));
		}
	}

}

