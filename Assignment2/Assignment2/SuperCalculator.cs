using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
  public class SuperCalculator
  {
    // This function should calculates the nth fibonacci recursively
    public int fibonacci(int n)
    {
      if (n < 2) return n;
      return fibonacci(n - 1) + fibonacci(n - 2);
    }

    // @TODO: This function should calculate n! recursively
    public int factorial(int n)
    {
      return 0;
    }

  }
}
