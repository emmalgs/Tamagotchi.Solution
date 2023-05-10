using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tamagotchi.Models;
using System;

namespace Tamagotchi.Tests
{
  [TestClass]
  public class CatTests
  {
    [TestMethod]
    public void CatConstructor_CreatesInstanceOfCat_Cat()
    {
      Cat berli = new Cat();
      Assert.AreEqual(typeof(Cat), berli.GetType());
    }
  }
}