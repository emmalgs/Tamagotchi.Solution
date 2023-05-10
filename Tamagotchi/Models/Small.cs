// using System.Collections.Generic;

namespace Tamagotchi.Models
{
  public class Small : Pet
  {
    public int Id { get; }
    public Small(string name)
    {
      Name = name;
      AllPets.Add(this);
      Id = AllPets.Count;
    }
  }
}