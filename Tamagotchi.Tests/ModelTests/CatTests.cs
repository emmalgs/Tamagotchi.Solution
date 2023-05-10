using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tamagotchi.Models;
using System;

namespace Tamagotchi.Tests
{
  [TestClass]
  public class CatTests : IDisposable
  {
    public void Dispose()
    {
      Cat.ClearAll();
    }
    [TestMethod]
    public void CatConstructor_CreatesInstanceOfCat_Cat()
    {
      Cat berli = new Cat("Berli");
      Assert.AreEqual(typeof(Cat), berli.GetType());
    }
    [TestMethod]
    public void CatConstructor_CreatesInstanceOfCatWithUniqueId_Int()
    {
      Cat berli = new Cat("Berli");
      int result = berli.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void CatConstructor_AttentionMinSetToNegativeInt_Int()
    {
      Cat lilMan = new Cat("Lil Man");
      int result = lilMan.AttnMinMax[0];
      Assert.AreEqual(-10, result);
    }
  }
}