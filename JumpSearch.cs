using System;

// Time Complexity: O(root n)
namespace JumpSearch
{
  class Program
  {
    private static int[] A;
    //private static int key;
    public static int JumpSearch(int key)
    {
      int n = A.Length; // Taking Length of the Array

      int step = (int)Math.Floor(Math.Sqrt(n)); // Finding the Step Size
      //The best step size is m = Root(n).

      int prev = 0;
      while (A[Math.Min(step, n) - 1] < key) // Checking if value at each Block end with Key
      {
        prev = step;
        step += step; // Reaching to Next Step 
        if (prev >= n) // Key Not Found this particular block
        {
          return -1;
        }
      }

      // Key can be Found in this Block. We Need to Perform Linear Search on that Block.
      // Begining with prev
      while (A[prev] < key)
      {
        if (prev == Math.Min(step, n)) // Key Not Found in that Block
        {
          return -1;
        }
        prev++;
      }

      if (A[prev] == key)
      {
        return prev;
      }

      return -1;
    }

    public static void Main(string[] args)
    {
      Console.WriteLine($"Enter the Elements: ");
      A = Array.ConvertAll(Console.ReadLine().Split(' '), e => int.Parse(e));
      int key = int.Parse(Console.ReadLine());
      int index = JumpSearch(key);
      Console.WriteLine($"Elements you Entered: ");
      Console.WriteLine(String.Join(" ", A));
      Console.WriteLine(index != -1 ? $"Key Found at Index: {index}" : $"Key Not Found");
      Console.ReadLine();
    }
  }
}
