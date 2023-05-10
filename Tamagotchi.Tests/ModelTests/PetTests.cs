using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tamagotchi.Models;
using System;

namespace Tamagotchi.Tests
{
  [TestClass]
  public class PetTests
  {

    [TestMethod]
    public void PetConstructor_CreatesInstanceOfTypePet_Pet()
    {
      Cat bukerio = new Cat();
      bool expected = true;
      Assert.AreEqual(expected, (bukerio is Pet));
    }
  }
}