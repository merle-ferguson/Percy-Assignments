using Assignment2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCalculator
{
  [TestClass]
  public class TestFibonacci
  {
    [TestMethod]
    public void testFib1()
    {
      var calculator = new SuperCalculator();
      Assert.IsTrue(calculator.fibonacci(0) == 0);
      Assert.IsTrue(calculator.fibonacci(1) == 1);
      Assert.IsTrue(calculator.fibonacci(3) == 2);

      // @TODO: Add more checks here
    }
  }
}
