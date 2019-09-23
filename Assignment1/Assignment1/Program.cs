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
        public static bool checkPalindrome(string strXval)
        {
            int vx1 = strXval.Length;
            int vx2 = vx1 - 1;
            var vstr1 = strXval.ToUpper();
            bool vstat0 = true;

            if (vstr1.Length == 1)
            { return (vstat0); }
            else
            {
                for (int vx3 = 0; vx3 < vx1 && vx2 >= 1;)
                {
                    if (vstr1[vx3] != vstr1[vx2])

                    {
                        vstat0 = false;
                        vx3 = vx1;
                    }
                    vx3++;
                    vx2--;
                }
                return (vstat0);
            }
        }
  }
}
