using System;

// Time Complexity : O(log n)
namespace ExponentialSearch
{
  class Program
  {
    private static int[] A;
    private static int key;
    private static int ExponentialSearch(int left, int right)
    {
      int n = A.Length; // Taking the Length to n

      if (key == A[0])
      {
        return 0; // Returning Index 0
      }

      int i = 1;

      while (i < n && A[i] <= key) // Iteration from Left to Right to find the Range
      {
        i = i * 2; // Doubling i in every Iteration
      }

      return BinarySearch(i/2, Math.Min(i, n));
    }
    private static int BinarySearch(int left, int right)
    {
      int mid = (left + right) / 2; // Finding the Mid

      if (right > left)
      {
        if (key == A[mid]) // key is Found at the Index mid
        {
          return mid;
        }

        if (key > A[mid]) // Key falls in the Right side of mid
        {
          return BinarySearch(mid + 1, right);
        }

        return BinarySearch(left, mid - 1); // Key falls in the Left side of mid
      }
      return -1;
    }
    public static void Main(string[] args)
    {
      Console.WriteLine($"Enter the Elements: ");
      A = Array.ConvertAll(Console.ReadLine().Split(' '), e => int.Parse(e));
      key = int.Parse(Console.ReadLine());
      int index = ExponentialSearch(0, A.Length - 1);
      Console.WriteLine($"Elements you Entered: ");
      Console.WriteLine(String.Join(" ", A));
      Console.WriteLine(index != -1 ? $"Key Found at Index: {index}" : $"Key Not Found");
      Console.ReadLine();
    }
  }
}
