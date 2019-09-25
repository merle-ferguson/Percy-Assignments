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
  public class TestFactorial
  {
    public SuperCalculator calculator = new SuperCalculator();

    [TestMethod]
    public void testFact1()
    {
      Assert.IsTrue(calculator.factorial(0) == 1);
      Assert.IsTrue(calculator.factorial(1) == 1);
      Assert.IsTrue(calculator.factorial(3) == 6);

      // @TODO: Add more checks here
    }
  }
}
