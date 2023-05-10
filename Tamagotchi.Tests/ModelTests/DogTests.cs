using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tamagotchi.Models;
using System;

namespace Tamagotchi.Tests
{
  [TestClass]
  public class DogTests : IDisposable
  {
    public void Dispose()
    {
      Dog.ClearAll();
    }
    [TestMethod]
    public void DogConstructor_CreatesInstanceOfDog_Dog()
    {
      Dog pi = new Dog("Pi");
      Assert.AreEqual(typeof(Dog), pi.GetType());
    }
    [TestMethod]
    public void DogConstructor_CreatesInstanceOfDogWithUniqueId_Int()
    {
      Dog pi = new Dog("Pi");
      int result = pi.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void DogConstructor_RestMaxSetToTen_Int()
    {
      Dog buck = new Dog("Buck");
      int result = buck.RestMinMax[1];
      Assert.AreEqual(10, result);
    }
  }
}