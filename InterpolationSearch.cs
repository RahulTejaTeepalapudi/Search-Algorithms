using System;

// Average Time Complexity : O(log log(n)), Assuming the elements are uniformly distributed
// Worst Time Complexity : O(n)
namespace InterpolationSearch
{
  class Program
  {
    private static int[] A;
    private static int key;
    private static int InterpolationSearch(int key)
    {
      int left = 0; // Taking Left as Index O
      int right = A.Length - 1; // Taking Right as N-1 Index

      while (left <= right && key >= A[left] && key <= A[right])
      {
        // Calculate the position using Interpolation Formula
        //int position = ((key - A[left]) * (right - left) / A[right] - A[left]) + left;

        int position = left + (((right - left) / (A[right] - A[left])) * (key - A[left]));

        if (key == A[position]) // key is Found at Position Index
        {
          return position;
        }

        if (key > A[position]) // Key falls in Right Side of the Postion Index
        {
          left = position + 1;
        }
        else // Key falls in Left Side of the Position Index
        {
          right = position - 1;
        }
      }
      return -1;
    }
    public static void Main(string[] args)
    {
      Console.WriteLine($"Enter the Elements: ");
      A = Array.ConvertAll(Console.ReadLine().Split(' '), e => int.Parse(e));
      key = int.Parse(Console.ReadLine());
      int index = InterpolationSearch(key);
      Console.WriteLine($"Elements you Entered: ");
      Console.WriteLine(String.Join(" ", A));
      Console.WriteLine(index != -1 ? $"Key Found at Index: {index}" : $"Key Not Found");
      Console.ReadLine();
    }
  }
}
