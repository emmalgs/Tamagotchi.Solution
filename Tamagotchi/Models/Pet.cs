using System.Collections.Generic;

namespace Tamagotchi.Models
{
  public abstract class Pet
  {

    public string Name { get; set; }
    public int AmtFood { get; set; }
    public int Attention { get; set; }
    public int Rest { get; set; }
    public static List<Pet> AllPets { get; set; } = new List<Pet> { };
    public static void ClearAll()
    {
      AllPets.Clear();
    }
  }
}
