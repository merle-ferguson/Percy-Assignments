using System;

namespace Assignment1
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Please enter a Satellite ID. I will tell you whether it's a palindrome.");

      // Get input from the user
      string scId = Console.ReadLine();

      // Write checkPalindrome to return whether the spacecraft is a palindrome!
      bool isPalindrome = checkPalindrome(scId);
      if (isPalindrome)
      {
        Console.WriteLine($"{scId} is a palindrome! Please choose a different Spacecraft ID immediately.");
      }
      else
      {
        Console.WriteLine($"{scId} is not a palindrome! Carry on.");
      }

      // Prevent the console from closing until it gets user input
      Console.ReadLine();
    }

    /// <summary>
    /// ________________________
    /// </summary>
    /// <param name="________________________">________________________</param>
    /// <returns>________________________</returns>
    public static bool checkPalindrome(string str)
    {
      return false;
    }

  }
}
