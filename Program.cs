using System;

// Time Complexity: O(log n)
// Ternary Search does more number of comparisions than Binary Search in Worst Case.
namespace TernarySearch
{
  class Program
  {
    private static int[] A;

    private static int key;
    private static int TernarySearch(int left, int right)
    {
      if (right >= left)
      {
        int mid1 = left + (right - left) / 3; // Mid1 is first one-third

        int mid2 = mid1 + (right - left) / 3; // Mid2 is third one-third

        if (key == A[mid1])
        {
          return mid1;
        }

        if (key == A[mid2])
        {
          return mid2;
        }

        if (key < A[mid1]) // Key falls in the Left side of Mid1
        {
          return TernarySearch(left, mid1 - 1);
        }

        if (key > A[mid2]) // Key falls in the Right Side of Mid2
        {
          return TernarySearch(mid2 + 1, right);
        }

        return TernarySearch(mid1 + 1, mid2 - 1); // Key Might be present in the Second one-third.
      }
      return -1;
    }
    public static void Main(string[] args)
    {
      Console.WriteLine($"Enter the Elements: ");
      A = Array.ConvertAll(Console.ReadLine().Split(' '), e => int.Parse(e));
      key = int.Parse(Console.ReadLine());
      int index = TernarySearch(0, A.Length - 1);
      Console.WriteLine($"Elements you Entered: ");
      Console.WriteLine(String.Join(" ", A));
      Console.WriteLine(index != -1 ? $"Key Found at Index: {index}" : $"Key Not Found");
      Console.ReadLine();
    }
  }
}
