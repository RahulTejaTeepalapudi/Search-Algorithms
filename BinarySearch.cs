using System;

// Time Complexity: O(log n)
namespace BinarySearch
{
  class Program
  {
    private static int[] A;
    private static int key;
    private static int BinarySearch(int leftIndex, int rightIndex)
    {
      int mid = (leftIndex + rightIndex) / 2; // Taking the Middle Index

      //int mid = (rightIndex - leftIndex) / 2 + leftIndex; //Taking the Middle Index

      if (rightIndex > leftIndex)
      {
        if (key == A[mid]) // Key Exists at index mid
        {
          return mid;
        }

        if (key > A[mid]) // Key Exists in Second Half
        {
          return BinarySearch(mid + 1, rightIndex);
        }

        return BinarySearch(leftIndex, mid - 1); // Key Exists in First Half
      }
      return -1;
    }
    public static void Main(string[] args)
    {
      Console.WriteLine($"Enter the Elements: ");
      A = Array.ConvertAll(Console.ReadLine().Split(' '), e => int.Parse(e));
      key = int.Parse(Console.ReadLine());
      int index = BinarySearch(0, A.Length - 1);
      Console.WriteLine($"Elements you Entered: ");
      Console.WriteLine(String.Join(" ", A));
      Console.WriteLine(index != -1 ? $"Key Found at Index: {index}" : $"Key Not Found");
      Console.ReadLine();
    }
  }
}
