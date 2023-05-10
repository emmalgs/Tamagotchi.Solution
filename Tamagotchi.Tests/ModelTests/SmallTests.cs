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
  }
}