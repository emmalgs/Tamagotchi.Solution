using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tamagotchi.Models;
using System;

namespace Tamagotchi.Tests
{
  [TestClass]
  public class SmallTests : IDisposable
  {
    public void Dispose()
    {
      Small.ClearAll();
    }
    [TestMethod]
    public void SmallConstructor_CreatesInstanceOfSmall_Small()
    {
      Small opal = new Small("Opal");
      Assert.AreEqual(typeof(Small), opal.GetType());
    }
    [TestMethod]
    public void SmallConstructor_CreatesInstanceOfSmallWithUniqueId_Int()
    {
      Small opal = new Small("Opal");
      int result = opal.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void SmallConstructor_RestSetToTen_Int()
    {
      Small buckets = new Small("Buckets");
      int result = buckets.Rest;
      Assert.AreEqual(10, result);
    }

    [TestMethod]
    public void AllAnimals_AddsAnimalsToList_Int()
    {
      Small buckets = new Small("Buckets");
      Dog doggie = new Dog("Doggie");
      Cat cattie = new Cat("Cattie");
      string result = Small.AllPets[1].Name;
      Assert.AreEqual("Doggie", result);
    }
  }
}