using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tamagotchi.Models;

namespace Tamagotchi.Tests
{
  [TestClass]
  public class PetTests
  {

    [TestMethod]
    public void PetConstructor_CreatesInstanceOfTypePet_Pet()
    {
      Pet bukerio = new Pet();
      Assert.AreEqual(typeof(Pet), bukerio.GetType());
    }
  }
}