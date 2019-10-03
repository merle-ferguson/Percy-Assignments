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
      // @TODO: This should sufficiently test your factorial function
      Assert.IsTrue(false);
    }
  }
}
